using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kallulater_shond
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { }
        public void button1_Click(object sender, EventArgs e)
        {      //Обработка ошибок :3 А то есть тут злыдни, которые всё ломают     
            try
            {
                //---------- Дуйствие по сложению чисел ----------
                textBox3.Text = (Convert.ToDouble(textBox1.Text) + Convert.ToDouble(textBox2.Text)).ToString(); 
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Обработка ошибок :3 А то есть тут злыдни, которые всё ломают 
            try
            {
                //---------- Дуйствие по вычитанию чисел ----------
                textBox3.Text = (Convert.ToDouble(textBox1.Text) - Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void button3_Click(object sender, EventArgs e)
        {
            //Обработка ошибок :3 А то есть тут злыдни, которые всё ломают 
            try
            {
                //---------- Дуйствие по делению чисел ----------
                textBox3.Text = (Convert.ToDouble(textBox1.Text) / Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хварит ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Обработка ошибок :3 А то есть тут злыдни, которые всё ломают 
            try
            {
                //---------- Дуйствие по умножению чисел ----------
                textBox3.Text = (Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        { }

        private void button5_Click(object sender, EventArgs e)
        {
            //Обработка ошибок :3 А то есть тут злыдни, которые всё ломают 
            try
            {
                //---------- Нахождение степени числа ----------
                // Этот кусок кода не оптимизирован, трубуется доработка. 
                string text = "";

                var num1 = Convert.ToDouble(textBox1.Text);
                var num2 = Convert.ToDouble(textBox2.Text);

                double answer = Math.Pow(num1, num2);
                text = Convert.ToString(answer);

                textBox3.Text = text;

                label4.Text = "^";
                label4.Visible = true;

            }
            catch
            {
                MessageBox.Show("Эй, ГУМАНИТАРИЙ хватет ламать меня. Бука", "Code 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

