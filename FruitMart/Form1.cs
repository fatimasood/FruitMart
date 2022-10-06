using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitMart
{
    
    public partial class Form1 : Form
    {
        int totalpro = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void text1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                numericUpDown1.Enabled = true;
                comboBox1.Enabled = true;

                totalpro += 1;
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
        
            if (checkBox2.Checked == true)
            {
                numericUpDown2.Enabled = true;
                comboBox2.Enabled = true;

                totalpro += 1;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked == true)
            {
                numericUpDown3.Enabled = true;
                comboBox3.Enabled = true;

                totalpro += 1;
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox6.Checked == true)
            {
                numericUpDown4.Enabled = true;
                comboBox4.Enabled = true;

                totalpro += 1;

            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
           
            if (checkBox5.Checked == true)
            {
                numericUpDown5.Enabled = true;
                comboBox5.Enabled = true;

                totalpro += 1;

            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox4.Checked == true)
            {
                numericUpDown6.Enabled = true;
                comboBox6.Enabled = true;

                totalpro += 1;

            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {
           
        }

        private void label17_Click(object sender, EventArgs e)
        {
          
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true || checkBox2.Checked == true || checkBox3.Checked == true || checkBox4.Checked == true || checkBox5.Checked == true || checkBox6.Checked == true)
            {
                DateTime dt = DateTime.Now;
                label10.Text = dt.ToString();

                label15.Text = totalpro.ToString();

                label18.Text = numericUpDown1.Text;
                label25.Text = numericUpDown2.Text;
                label26.Text = numericUpDown3.Text;
                label27.Text = numericUpDown4.Text;
                label28.Text = numericUpDown5.Text;
                label29.Text = numericUpDown6.Text;

                double appl = Convert.ToDouble(label18.Text);
                double ora = Convert.ToDouble(label25.Text);
                double man = Convert.ToDouble(label26.Text);
                double peach = Convert.ToDouble(label27.Text);
                double pine = Convert.ToDouble(label28.Text);
                double straw = Convert.ToDouble(label29.Text);

                double price = appl + ora + man + peach + pine;
                label16.Text = price.ToString();

                if (comboBox1.SelectedText == "200")
                {
                    double p = appl * 200;
                    label19.Text = p.ToString();

                }
                else
                {
                    double p = appl * 150;
                    label19.Text = p.ToString();
                }

                if (comboBox2.SelectedText == "300")
                {
                    double p = ora * 300;
                    label30.Text = p.ToString();

                }
                else
                {
                    double p = ora * 200;
                    label30.Text = p.ToString();
                }

                if (comboBox3.SelectedText == "150")
                {
                    double p = man * 150;
                    label31.Text = p.ToString();

                }
                else
                {
                    double p = man * 120;
                    label31.Text = p.ToString();
                }

                if (comboBox4.SelectedText == "250")
                {
                    double p = peach * 250;
                    label32.Text = p.ToString();

                }
                else
                {
                    double p = peach * 200;
                    label32.Text = p.ToString();
                }

                if (comboBox5.SelectedText == "1000")
                {
                    double p = pine * 200;
                    label33.Text = p.ToString();

                }
                else
                {
                    double p = pine * 150;
                    label33.Text = p.ToString();
                }

                if (comboBox6.SelectedText == "90")
                {
                    double p = straw * 90;
                    label34.Text = p.ToString();

                }
                else
                {
                    double p = straw * 60;
                    label34.Text = p.ToString();
                }

                double apple = Convert.ToDouble(label19.Text);
                double orange = Convert.ToDouble(label30.Text);
                double mango = Convert.ToDouble(label31.Text);
                double peac = Convert.ToDouble(label32.Text);
                double pineApple = Convert.ToDouble(label33.Text);
                double strawberry = Convert.ToDouble(label34.Text);

                if (radioButton1.Checked == true)
                {
                    double totalPayment = apple + orange + mango + peac + pineApple + 20;
                    label16.Text = totalPayment.ToString();

                }
                else
                {
                    MessageBox.Show("Are you sure you didn't need bag.", "CONFIRMATION", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                    double totalPayment = apple + orange + mango + peac + pineApple;
                    label16.Text = totalPayment.ToString();
                }

             
            }
            else
            {
                MessageBox.Show(" Kindly Select any Item.....!!", "WARNING", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label33_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
