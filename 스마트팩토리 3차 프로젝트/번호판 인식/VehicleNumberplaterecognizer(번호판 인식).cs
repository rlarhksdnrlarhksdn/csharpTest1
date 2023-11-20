using OpenCvSharp;
using OpenCvSharp.Extensions;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Data.OracleClient;
using System.Drawing;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace WindowsFormsApp23
{
    public partial class Form1 : Form
    {
        private VideoCapture capture;
        private TesseractEngine tesseractEngine;
        private bool isCameraRunning = false;
        private CascadeClassifier plateCascade;
        private bool captureOneFrame = false;
        private string esp8266Ip = "192.168.38.116";
        private int esp8266Port = 80;


        public Form1()
        {
            InitializeComponent();
        }
        //  Form1_Load 메서드에서 Tesseract OCR 엔진과 번호판 인식을 위한 OpenCV Classifier를 초기화
        private void Form1_Load(object sender, EventArgs e)
        {
            tesseractEngine = new TesseractEngine("C:\\Temp\\tessdata", "kor+digits", EngineMode.Default);
            plateCascade = new CascadeClassifier("C:\\Temp\\haarcascade_russian_plate_number.xml");
        }
        // 이 메서드는 카메라로부터 영상 프레임을 받아와 번호판을 검출하고 인식하는 중요한 부분
        // OpenCV를 사용하여 프레임 처리 및 번호판 검출을 수행
        // Tesseract OCR을 이용하여 번호판에서 텍스트를 추출
        //추출된 텍스트는 레이블에 표시되고, HandleRecognizedPlate 메서드를 호출하여 인식된 번호판을 처리
        private void ProcessFrame(object sender, EventArgs e)
        {
            if (tesseractEngine == null)
            {
                tesseractEngine = new TesseractEngine("C:\\Temp\\tessdata", "kor+digits", EngineMode.Default);
            }

            if (plateCascade == null)
            {
                plateCascade = new CascadeClassifier("C:\\Temp\\haarcascade_russian_plate_number.xml");
            }

            Mat frame = new Mat();
            if (capture.Read(frame) && !frame.Empty())
            {
                Mat gray = new Mat();
                Cv2.CvtColor(frame, gray, ColorConversionCodes.BGR2GRAY);
                Cv2.EqualizeHist(gray, gray);

                OpenCvSharp.Rect[] plates = plateCascade.DetectMultiScale(
                    gray,
                    scaleFactor: 1.08,
                    minNeighbors: 5,
                    minSize: new OpenCvSharp.Size(150, 150)
                );

                foreach (var rect in plates)
                {
                    Cv2.Rectangle(frame, rect, Scalar.Red, 2);

                    Mat plateRegion = new Mat(frame, rect);
                    string fileName = Path.Combine("C:\\Temp", $"plate_{DateTime.Now.Ticks}.png");
                    plateRegion.SaveImage(fileName);

                    pictureBox2.Image = Image.FromFile(fileName);

                    using (Pix pix = PixConverter.ToPix(plateRegion.ToBitmap()))
                    using (Page page = tesseractEngine.Process(pix))
                    {
                        string recognizedText = page.GetText();
                        if (!string.IsNullOrEmpty(recognizedText))
                        {
                            label1.Invoke(new Action(() => label1.Text = recognizedText.Trim()));

                            HandleRecognizedPlate(recognizedText);
                        }
                    }

                    captureOneFrame = true;
                    Application.Idle -= ProcessFrame;

                }
            }

            pictureBox1.Image = frame.ToBitmap();
        }

        // TCP를 통해 데이터를 전송하는 메서드로, ESP8266 모듈 등의 장치와 통신하는 데 사용
        private void SendDataOverTCP(string dataToSend)
        {
            try
            {
                using (TcpClient client = new TcpClient("192.168.111.156", 13000))
                using (NetworkStream stream = client.GetStream())
                {
                    byte[] message = Encoding.UTF8.GetBytes(dataToSend);
                    stream.Write(message, 0, message.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "TCP Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // 카메라를 시작
        private void button1_Click(object sender, EventArgs e)
        {
            if (!isCameraRunning) // isCameraRunning 변수를 사용하여 현재 카메라가 실행 중이지 않은 경우에 다음 동작을 수행
            {
                capture = new VideoCapture(0);
                capture.Set(VideoCaptureProperties.FrameWidth, 640);
                capture.Set(VideoCaptureProperties.FrameHeight, 480);
                isCameraRunning = true;
                Application.Idle += ProcessFrame;
                button1.Enabled = false;
                captureOneFrame = false;
            }
        }
        //  주어진 문자열이 숫자로 변환 가능한지 여부를 확인하는 역할
        private bool IsNumeric(string text)
        {
            double result; //  주어진 문자열 text를 double.TryParse 메서드를 사용하여 double 데이터형으로 변환을 시도하고, 변환 결과를 result 변수에 저장
            return double.TryParse(text, out result); //  변환이 성공하면, 즉 문자열이 숫자로 올바르게 변환되면 true를 반환하고, 그렇지 않으면 false를 반환
        }
        private async Task SendUpOrDownMessageAsync(string message) // 비동기적으로 TCP/IP 프로토콜을 사용하여 메시지를 원격 장치에 전송
        {
            byte[] data; // 메서드는 입력으로 받은 message 문자열을 ASCII 인코딩을 사용하여 바이트 배열로 변환하고

            using (TcpClient client = new TcpClient(esp8266Ip, esp8266Port)) // 지정된 IP 주소 (esp8266Ip)와 포트 번호 (esp8266Port)로 연결된 TcpClient를 생성
            using (NetworkStream stream = client.GetStream()) // TcpClient의 GetStream() 메서드를 사용하여 데이터를 전송할 수 있는 NetworkStream 객체를 가져옴
            {
                data = Encoding.ASCII.GetBytes(message);
                await stream.WriteAsync(data, 0, data.Length); // await 키워드를 사용하여 stream.WriteAsync 메서드를 호출하여 바이트 데이터를 원격 장치로 비동기적으로 전송
            }
        }

        private async void HandleRecognizedPlate(string plateText) //  이 plateText는 번호판에서 인식된 텍스트를 나타냄
        { 
            string message = "1";  // string message = "1"; 코드에서 message 변수에 문자열 "1"을 할당
            await SendUpOrDownMessageAsync(message); // 코드에서 SendUpOrDownMessageAsync 메서드를 호출하여 message를 전송
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (isCameraRunning)
            {
                if (capture != null) // if (isCameraRunning) 블록: 이 부분은 isCameraRunning 변수를 사용하여 현재 카메라가 실행 중인지 확인
                {
                    Application.Idle -= ProcessFrame; // Application.Idle -= ProcessFrame;: 카메라의 프레임을 처리하는 ProcessFrame 메서드가 실행되는 이벤트 핸들러를 해제하여 카메라 프레임 처리를 중지
                    capture.Release();  // capture.Release();: 카메라를 해제하고, 카메라 자원을 반환
                    isCameraRunning = false;  // isCameraRunning = false;: isCameraRunning 변수를 false로 설정하여 카메라가 현재 실행 중이지 않음을 나타냄
                }

                button1.Enabled = true;  // button1.Enabled = true;: "button1" 버튼을 활성화
            }
            else if (captureOneFrame) // captureOneFrame 변수가 true인 경우에 다음 동작을 수행
            {
                capture = new VideoCapture(0); // capture = new VideoCapture(0);: 카메라를 다시 초기화하고, 새로운 비디오 캡처 객체를 생성
                capture.Set(VideoCaptureProperties.FrameWidth, 640);
                capture.Set(VideoCaptureProperties.FrameHeight, 480); // 캡처된 비디오 프레임의 너비와 높이를 설정
                isCameraRunning = true; // isCameraRunning = true;: isCameraRunning 변수를 true로 설정하여 카메라가 실행 중임을 나타냄
                Application.Idle += ProcessFrame; // Application.Idle += ProcessFrame;: 카메라의 프레임을 처리하는 ProcessFrame 메서드가 실행되는 이벤트 핸들러를 추가하여 카메라 프레임 처리를 시작
                button1.Enabled = false; //button1.Enabled = false;: "button1" 버튼을 비활성화시킴
                captureOneFrame = false;
            }
        }
        // 데이터베이스에 차량 정보를 저장
        private void button3_Click(object sender, EventArgs e)
        {
            string recognizedText = label1.Text;

            if (!string.IsNullOrEmpty(recognizedText))
            {
                // 데이터베이스 연결 설정
                Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection("Data Source=(DESCRIPTION=" +
                    "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=localhost)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVER=DEDICATED)" +
                    "(SERVICE_NAME=xe)));" +
                    "User Id=hr;Password=hr;");

                conn.Open();
                Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                cmd.Connection = conn;

                try
                {
                    cmd.CommandText = "INSERT INTO PARKING (NUM_CAR, IN_TIME) " +
                        "VALUES (:numCar, :inTime)";

                    // 매개변수 설정
                    cmd.Parameters.Add("numCar", OracleDbType.Varchar2).Value = recognizedText;
                    cmd.Parameters.Add("inTime", OracleDbType.Date).Value = DateTime.Now;

                    cmd.ExecuteNonQuery();
                    
                    MessageBox.Show("차량 정보를 데이터베이스에 저장했습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("인식된 텍스트가 없습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // 차량 정보를 조회하고 주차 요금을 정산하는 데 사용
        private void button4_Click(object sender, EventArgs e)
        {
            string recognizedText = label1.Text;

            if (!string.IsNullOrEmpty(recognizedText) && recognizedText.Length >= 4)
            {
                // 뒤에서 앞으로 4자리 추출
                string last4Digits = recognizedText.Substring(recognizedText.Length - 4);

                // 데이터베이스 연결 설정
                Oracle.ManagedDataAccess.Client.OracleConnection conn = new Oracle.ManagedDataAccess.Client.OracleConnection("Data Source=(DESCRIPTION=" +
                    "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)" +
                    "(HOST=localhost)(PORT=1521)))" +
                    "(CONNECT_DATA=(SERVER=DEDICATED)" +
                    "(SERVICE_NAME=xe)));" +
                    "User Id=hr;Password=hr;");

                conn.Open();
                Oracle.ManagedDataAccess.Client.OracleCommand cmd = new Oracle.ManagedDataAccess.Client.OracleCommand();
                cmd.Connection = conn;

                try
                {
                    // NUM_CAR의 뒤에서 앞으로 4자리가 일치하는 경우를 확인
                    cmd.CommandText = "SELECT IN_TIME FROM PARKING WHERE SUBSTR(NUM_CAR, -4) = :last4Digits";

                    // 매개변수 설정
                    cmd.Parameters.Add("last4Digits", OracleDbType.Varchar2).Value = last4Digits;

                    Oracle.ManagedDataAccess.Client.OracleDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        DateTime inTime = reader.GetDateTime(0);

                        cmd.CommandText = "UPDATE PARKING SET OUT_TIME = :outTime WHERE SUBSTR(NUM_CAR, -4) = :last4Digits";
                        cmd.Parameters.Clear();
                        cmd.Parameters.Add("outTime", OracleDbType.Date).Value = DateTime.Now;
                        cmd.Parameters.Add("last4Digits", OracleDbType.Varchar2).Value = last4Digits;

                        cmd.ExecuteNonQuery();

                        MessageBox.Show("주차요금이 정산될 예정입니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("끝 4자리가 일치하지 않습니다. 주차 정보를 찾을 수 없습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
            else
            {
                MessageBox.Show("인식된 텍스트가 너무 짧습니다. 끝 4자리를 추출할 수 없습니다.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }

}



