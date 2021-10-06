using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GAME_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Warrior")
            {
                textBox5.Text = "100"; // 200
                textBox6.Text = "100"; // 50
                textBox9.Text = "20"; // 70
                textBox11.Text = "20"; // 45
                textBox8.Text = "20"; // -80
                textBox10.Text = "20"; // -30
                textBox13.Text = "20"; // 20
                textBox13.Text = "20"; // 20
                textBox1.Text = "20"; // 20
                textBox2.Text = "20"; // 20
                textBox3.Text = "20"; // 20
                textBox4.Text = "20"; // 20
                textBox7.Text = "20"; // 20
            }

            if (comboBox1.Text == "Mage")
            {
                textBox5.Text = "100"; // 50
                textBox6.Text = "100"; // 150
                textBox9.Text = "20"; // 20
                textBox11.Text = "20"; // 20
                textBox8.Text = "20"; // 70
                textBox10.Text = "20"; // 70
                textBox13.Text = "20"; // 20
                textBox13.Text = "20"; // 20
                textBox1.Text = "20"; // 20
                textBox2.Text = "20"; // 20
                textBox3.Text = "20"; // 20
                textBox4.Text = "20"; // 20
                textBox7.Text = "20"; // 20
            }

            if (comboBox1.Text == "Archer")
            {
                textBox5.Text = "100"; // 25
                textBox6.Text = "100"; // 125
                textBox9.Text = "20"; // -5
                textBox11.Text = "20"; // 25
                textBox8.Text = "20"; // 70
                textBox10.Text = "20"; // 45
                textBox13.Text = "20"; // 70
                textBox13.Text = "20"; // 40
                textBox1.Text = "20"; // 20
                textBox2.Text = "20"; // 20
                textBox3.Text = "20"; // 20
                textBox4.Text = "20"; // 20
                textBox7.Text = "20"; // 20
            }

            if (comboBox1.Text == "Warrior")
            {
                pictureBox3.Visible = false;
                pictureBox2.Visible = false;
                pictureBox1.Visible = true;
            }

            if (comboBox1.Text == "Mage")
            {
                pictureBox1.Visible = false;
                pictureBox3.Visible = false;
                pictureBox2.Visible = true;
            }

            if (comboBox1.Text == "Archer")
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                pictureBox1.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text = (int.Parse(textBox2.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) - 0).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) - 0).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) - 0).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) - 0).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) - 0).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) - 3).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) - 2).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) - 5).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) + 5).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) + 0).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) + 0).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) + 5).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) + 0).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) + 0).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) + 0).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) + 0).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) - 5).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) - 0).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) - 0).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) - 5).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) - 0).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) - 0).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) - 0).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) - 0).ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text = (int.Parse(textBox2.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) + 0).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) + 0).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) + 0).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) + 0).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) + 0).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) + 3).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) + 2).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) + 5).ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) + 0).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) + 5).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) + 10).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) + 0).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) + 5).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) + 0).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) + 0).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) + 0).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox3.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) - 0).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) - 5).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) - 10).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) - 0).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) - 5).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) - 0).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) - 0).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) - 0).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) + 10).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) + 0).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) + 0).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) + 0).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) + 0).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) + 5).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) + 0).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) + 0).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = (int.Parse(textBox4.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
            textBox5.Text = (int.Parse(textBox5.Text) - 10).ToString();
            textBox6.Text = (int.Parse(textBox6.Text) - 0).ToString();
            textBox8.Text = (int.Parse(textBox8.Text) - 0).ToString();
            textBox9.Text = (int.Parse(textBox9.Text) - 0).ToString();
            textBox10.Text = (int.Parse(textBox10.Text) - 0).ToString();
            textBox11.Text = (int.Parse(textBox11.Text) - 5).ToString();
            textBox12.Text = (int.Parse(textBox12.Text) - 0).ToString();
            textBox13.Text = (int.Parse(textBox13.Text) - 0).ToString();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
