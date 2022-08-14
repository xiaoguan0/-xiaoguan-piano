namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public class Media
        {
            // wavÒôÆµ²¥·Åº¯Êý
            private string Data;
            public Media(string Medianame)
            {
                Data = Medianame;
                System.Media.SoundPlayer sndPlayer = new System.Media.SoundPlayer(Application.StartupPath + Medianame);
                sndPlayer.Play(); 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Media("1.wav");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Media("2.wav");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Media("3.wav");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Media("4.wav");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Media("5.wav");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Media("6.wav");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new Media("7.wav");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("¾´ÇëÆÚ´ý");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            about signForm = new about();
            object value = signForm.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.D1)
            {
                new Media("1.wav");
            }
            if (keyData == Keys.D2)
            {
                new Media("2.wav");
            }
            if (keyData == Keys.D3)
            {
                new Media("3.wav");
            }
            if (keyData == Keys.D4)
            {
                new Media("4.wav");
            }
            if (keyData == Keys.D5)
            {
                new Media("5.wav");
            }
            if (keyData == Keys.D6)
            {
                new Media("6.wav");
            }
            if (keyData == Keys.D7)
            {
                new Media("7.wav");
            }
            return base.ProcessDialogKey(keyData);
        }
    }
}