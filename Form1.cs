using System;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text)) return;
            
            double x1 = double.Parse(textBox1.Text);
            double x2 = double.Parse(textBox2.Text);

            double y = Math.Sqrt(Math.Pow(x1, 3) + Math.Pow(x2, 5)) / (1000 * Math.Sqrt(x1 + Math.Pow(x2, 5))) + 65;
            textBox3.Text = y.ToString("0.######");
            textBox4.Text = ((x1+x2)/2).ToString("0.######");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox4.Text = string.Empty;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}