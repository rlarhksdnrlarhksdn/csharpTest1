using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApp19
{
    public partial class Form1 : Form
    {
        private int CpuPrice;
        private int GpuPrice;
        private int MainboardPrice;
        private int RamPrice ;
        private int CasePrice ;
        private int HddPrice ;
        private int SsdPrice ;
        private int PowerPrice ;
        private int TotalPrice;
        private int CpuPower;
        private int GpuPower;
        private int TotalPower;


        public class Com
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public string Cid { get; set; }
            public string Cphone { get; set; }
            public string Ctime { get; set; }
            public string Ctype { get; set; }
            public string Cprice { get; set; }
            public string Cpu { get; set; }
            public string Gpu { get; set; }
            public string Cme { get; set; }
            public string Cmb { get; set; }
            public string Ccase { get; set; }
            public string Cpw { get; set; }
            public string TextBox1 { get; set; }

            public string Cas1 { get; set; }
            public string Cas2 { get; set; }
            public string Cas3 { get; set; }
            public string Cas4 { get; set; }
            public string Cas5 { get; set; }
            public string Cas6 { get; set; }
            public string Cas7 { get; set; }

            public string Opt { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null ||
                comboBox3.SelectedItem == null || comboBox4.SelectedItem == null ||
                comboBox5.SelectedItem == null || comboBox6.SelectedItem == null)
            {
                MessageBox.Show("모든 필수 선택 항목을 선택해주세요.", "경고", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string selectedCpu = comboBox1.SelectedItem.ToString();

            if (selectedCpu == "CPU_i3-13")
            {
                CpuPrice = 200000; 
            }
            else if (selectedCpu == "CPU_i5-12")
            {
                CpuPrice = 310000; 
            }
            else if (selectedCpu == "CPU_i7-11")
            {
                CpuPrice = 522500; 
            }
            else if (selectedCpu == "CPU_i7-13")
            {
                CpuPrice = 545000; 
            }
            else
            {
                CpuPrice = 660000; 
            }

            string selectedMainBoard = comboBox2.SelectedItem.ToString();

            if (selectedMainBoard == "MAIN_MSI")
            {
                MainboardPrice = 168680; 
            }
            else if (selectedMainBoard == "MAIN_GIGABYTE")
            {
                MainboardPrice = 162930; 
            }
            else if (selectedMainBoard == "MAIN_ASUS")
            {
                MainboardPrice = 987950; 
            }
            else
            {
                MainboardPrice = 184600; 
            }

            string selectedGPU = comboBox3.SelectedItem?.ToString();

            if (selectedGPU == null)
            {
                GpuPrice = 0;
            }
            else if (selectedGPU == "GPU_RTX2060")
            {
                GpuPrice = 400000; 
            }
            else if (selectedGPU == "GPU_RTX2070")
            {
                GpuPrice = 550000; 
            }
            else if (selectedGPU == "GPU_RTX3060")
            {
                GpuPrice = 500000; 
            }
            else if (selectedGPU == "GPU_RTX3070")
            {
                GpuPrice = 650000; 
            }
            else if (selectedGPU == "GPU_RTX4060")
            {
                GpuPrice = 600000; 
            }
            else if (selectedGPU == "GPU_RTX4070")
            {
                GpuPrice = 900000; 
            }
            else
            {
                GpuPrice = 0;
            }

            string selectedCase = comboBox4.SelectedItem.ToString();

            if (selectedCase == "CASE_EM2-STEREO_BLACK")
            {
                CasePrice = 48000; 
            }
            
            else if (selectedCase == "CASE_EM2-STEREO_WHITE")
            {
                CasePrice = 48000; 
            }
            else if (selectedCase == "CASE_MASTER_PINK")
            {
                CasePrice = 55000; 
            }
            else if (selectedCase == "CASE_EH1")
            {
                CasePrice = 52000; 
            }
            else
            {
                CasePrice = 101000;
            }
            

            string selectedMemory = comboBox5.SelectedItem.ToString();

            if (checkBox7.Checked)
            {
                if (comboBox5.SelectedItem.ToString() == "RAM_4GB")
                    RamPrice = 2 * 20000;
                else if (comboBox5.SelectedItem.ToString() == "RAM_8GB")
                    RamPrice = 2 * 30000;
                else if (comboBox5.SelectedItem.ToString() == "RAM_16GB")
                    RamPrice = 2 * 50000;
            }
            else
            {
                if (comboBox5.SelectedItem.ToString() == "RAM_4GB")
                    RamPrice = 20000;
                else if (comboBox5.SelectedItem.ToString() == "RAM_8GB")
                    RamPrice = 30000;
                else if (comboBox5.SelectedItem.ToString() == "RAM_16GB")
                    RamPrice = 50000;

            }

            string selectedPower = comboBox6.SelectedItem.ToString();

            if (selectedPower == "500W")
            {
                PowerPrice = 50000; 
            }
            else if (selectedPower == "600W")
            {
                PowerPrice = 60000; 
            }
            else if (selectedPower == "700W")
            {
                PowerPrice = 70000; 
            }
            else
            {
                PowerPrice = 90000; 
            }

            if (checkBox4.Checked)
                SsdPrice += 30000;
            if (checkBox5.Checked)
                SsdPrice += 50000;
            if (checkBox6.Checked)
                SsdPrice += 80000;
            if (checkBox8.Checked)
                SsdPrice += 140000;
            


            if (checkBox1.Checked)
                HddPrice += 60000;
            if (checkBox2.Checked)
                HddPrice += 70000;
            if (checkBox3.Checked)
                HddPrice += 100000; 
            


            TotalPrice = CpuPrice + GpuPrice + MainboardPrice + RamPrice + CasePrice + PowerPrice + HddPrice + SsdPrice;
            label11.Text = "= "+TotalPrice.ToString()+"원";

            CpuPrice = 0;
            GpuPrice = 0;
            MainboardPrice = 0;
            RamPrice = 0;
            CasePrice = 0;
            PowerPrice = 0;
            HddPrice = 0;
            SsdPrice = 0;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("컴퓨터 파워 계산은 컴퓨터의 하드웨어 구성에 따라 전력 소비량을 추정하고 전원 공급 장치(Power Supply Unit, PSU)를 선택하는 프로세스를 말합니다. " +
                "올바른 파워 공급 장치를 선택하는 것은 안정적인 시스템 운영을 보장하고 하드웨어의 장수와 성능에 영향을 미칩니다..\n" + "\n" 
                + "권장 파워 계산 식 : CPU전력 + GPU전력 + 하드,ODD, SSD 개수 x 10 + 20\n" + "\n"+ "선택할 때는 신뢰성 있는 제조업체의 제품을 선택하고, 해당 제품의 평가와 리뷰를 확인하여 최적의 선택하세요!", "알려드립니다.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            return;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedCpu = comboBox1.SelectedItem.ToString();

            if (selectedCpu == "CPU_i3-13")
            {
                CpuPower = 55;
            }
            else if (selectedCpu == "CPU_i5-12")
            {
                CpuPower = 80;
            }
            else if (selectedCpu == "CPU_i7-11")
            {
                CpuPower = 105;
            }
            else if (selectedCpu == "CPU_i7-13")
            {
                CpuPower = 115;
            }
            else
            {
                CpuPower = 150;
            }

            string selectedGPU = comboBox3.SelectedItem?.ToString();

            if (selectedGPU == null)
            {
                GpuPower = 0;
            }
            else if (selectedGPU == "GPU_RTX2060")
            {
                GpuPower = 167;
            }
            else if (selectedGPU == "GPU_RTX2070")
            {
                GpuPower = 205;
            }
            else if (selectedGPU == "GPU_RTX3060")
            {
                GpuPower = 195;
            }
            else if (selectedGPU == "GPU_RTX3070")
            {
                GpuPower = 235;
            }
            else if (selectedGPU == "GPU_RTX4060")
            {
                GpuPower = 225;
            }
            else if (selectedGPU == "GPU_RTX4070")
            {
                GpuPower = 285;
            }

            TotalPower = 0;

            if (checkBox4.Checked)
                TotalPower += 10;
            if (checkBox5.Checked)
                TotalPower += 10;
            if (checkBox6.Checked)
                TotalPower += 10;
            if (checkBox8.Checked)
                TotalPower += 10;
            

            if (checkBox1.Checked)
                TotalPower += 10;
            if (checkBox2.Checked)
                TotalPower += 10;
            if (checkBox3.Checked)
                TotalPower += 10;
            

            label9.Text = "선택하신 부품을 종합한 컴퓨터의 권장 파워\n" + "= " + (TotalPower + CpuPower + GpuPower +20) + "W";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Com data = new Com
            {
                TextBox1 = textBox1.Text,

                Cpu = comboBox1.SelectedItem.ToString(),
                Cmb = comboBox2.SelectedItem.ToString(),
                Gpu = comboBox3.SelectedItem?.ToString() ?? null,
                Ccase = comboBox4.SelectedItem.ToString(),
                Cme = comboBox5.SelectedItem.ToString(),
                Cpw = comboBox6.SelectedItem.ToString(),
                Cprice = TotalPrice.ToString(),

                Cas1 = checkBox1.Checked ? "HDD_512GB" : "선택 안함",
                Cas2 = checkBox2.Checked ? "HDD_1TB" : "선택 안함",
                Cas3 = checkBox3.Checked ? "HDD_3TB" : "선택 안함",
                Cas4 = checkBox4.Checked ? "SSD_128GB" : "선택 안함",
                Cas5 = checkBox5.Checked ? "SSD_256GB" : "선택 안함",
                Cas6 = checkBox6.Checked ? "SSD_512GB" : "선택 안함",
                Cas7 = checkBox8.Checked ? "SSD_1TB" : "선택 안함",

                Opt = checkBox7.Checked ? "2" : "1"

            };

            if (TotalPrice == 0)
            {
                MessageBox.Show("가격 측정 버튼을 눌러주세요!!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("전화 번호룰 입력해주세요!!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TcpClient client = new TcpClient("192.168.111.145", 13000);

            using (NetworkStream stream = client.GetStream())
            {
                string jsonString = System.Text.Json.JsonSerializer.Serialize(data);
                byte[] message = Encoding.UTF8.GetBytes(jsonString);
                stream.Write(message, 0, message.Length);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
