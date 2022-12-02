using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kallulater_shond
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Растянуть изображение
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink; // Запрет на изменения размера формы
            MaximizeBox = false;

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.Click += aboutItem_Click;
            menuStrip1.Items.Add(aboutItem);

            void aboutItem_Click(object sender, EventArgs e)
            {
                MessageBox.Show("Разработчик: Sithond\n\nDiscord: Вечно \"Злой VINISHKO ТЯН\"#8161\nVK: vk.com\\sithond", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {}
        public void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_plas(textBox1.Text, textBox2.Text);
            pictureBox1.ImageLocation = Math.plusImg();           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_minus(textBox1.Text, textBox2.Text);
            pictureBox1.ImageLocation = Math.minusImg();
        }
        public void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_division(textBox1.Text, textBox2.Text);
            pictureBox1.ImageLocation = Math.divisionImg();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_multiply(textBox1.Text, textBox2.Text);
            pictureBox1.ImageLocation = Math.multiplyImg();
        } 
        private void button6_Click(object sender, EventArgs e)
        {
            textBox3.Text = Math.math_percent(textBox1.Text, textBox2.Text);
            pictureBox1.ImageLocation = Math.discountImg();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "313")
            {
                button5.Visible= false;
                label4.Visible = true;
                button7.Visible = true;
                button8.Visible = true;
                button9.Visible = true;
            } 
            else
            {
                MessageBox.Show("Вы не администратор","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            BackColor = colorDialog1.Color;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            ForeColor = colorDialog1.Color;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            
            openFileDialog1.Filter = "Icons (*.ico)|*.ico"; // Файл с заданным расширением можно от
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                return; 
            // Получаем выбранный файл
            string filename = openFileDialog1.FileName;
            // Присваимаем new icon
            this.Icon = new Icon(filename);
        }
    }
}