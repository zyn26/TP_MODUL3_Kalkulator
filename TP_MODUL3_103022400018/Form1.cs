namespace TP_MODUL3_103022400018
{
    public partial class Form1 : Form
    {
        int total = 0;
        bool angkaBaru = true;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "1";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "2";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "3";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "5";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "6";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "7";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "8";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "9";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                total += int.Parse(label1.Text);
                label1.Text = total.ToString();
                angkaBaru = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (angkaBaru == true)
            {
                label1.Text = "";
                angkaBaru = false;
            }
            label1.Text += "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (label1.Text != "" && angkaBaru == false)
            {
                total += int.Parse(label1.Text);
                label1.Text = total.ToString();
                total = 0; 
                angkaBaru = true;
            }
        }
    }
}
