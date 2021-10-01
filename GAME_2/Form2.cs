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
                textBox5.Text = "200";
                textBox6.Text = "50";
                textBox9.Text = "70";
                textBox11.Text = "45";
                textBox8.Text = "-80";
                textBox10.Text = "-30";
            }

            if (comboBox1.Text == "Mage")
            {
                textBox5.Text = "100";
                textBox6.Text = "100";
                textBox9.Text = "20";
                textBox11.Text = "20";
                textBox8.Text = "20";
                textBox10.Text = "20";
            }

            if (comboBox1.Text == "Archer")
            {
                textBox5.Text = "100";
                textBox6.Text = "100";
                textBox9.Text = "20";
                textBox11.Text = "20";
                textBox8.Text = "20";
                textBox10.Text = "20";
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = (int.Parse(textBox1.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox3.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox3.Text = (int.Parse(textBox3.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox4.Text = (int.Parse(textBox4.Text) + 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) - 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox4.Text = (int.Parse(textBox4.Text) - 1).ToString();
            textBox7.Text = (int.Parse(textBox7.Text) + 1).ToString();
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
    }
}
