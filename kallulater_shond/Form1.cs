using System;
using System.Windows.Forms;

namespace kallulater_shond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";

            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);

            var answer = num1 + num2;

            text = Convert.ToString(answer);

            textBox3.Text = text;

            label4.Text = "+";
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
                string text = "";

                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);

                var answer = num1 - num2;

                text = Convert.ToString(answer);

                textBox3.Text = text;

                label4.Text = "-";
                label4.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
                string text = "";
                double answer;
                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);

                answer = num1 / num2;

                text = Convert.ToString(answer);

                textBox3.Text = text;

                label4.Text = "/";
                label4.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
             string text = "";

            var num1 = Convert.ToDouble(textBox1.Text);
            var num2 = Convert.ToDouble(textBox2.Text);
            var answer = num1 * num2;
            text = Convert.ToString(answer);
            textBox3.Text = text;

            label4.Text = "*";
            label4.Visible = true;
        }
    }
}
