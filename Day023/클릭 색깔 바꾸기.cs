namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Random rand;
        public Form1()
        {
            InitializeComponent();

            Load += Form1_Load;
            MouseClick += RandomColorFunction;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rand = new Random();

        }

        //사용자 정의 메소드
        private void RandomColorFunction(object sender, MouseEventArgs e)
        {
            int red = rand.Next(0,256);
            int green = rand.Next(0,256);
            int blue = rand.Next(0,256);
            this.BackColor = Color.FromArgb(red, green, blue);
        }
    }
}
