using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2
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

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double resistor1 = double.Parse(textBox1.Text);
            double resistor2 = double.Parse(textBox2.Text);
            double resistor3 = double.Parse(textBox3.Text);
            double resistor4 = double.Parse(textBox4.Text);

            double TotalResistance = resistor1 + resistor2 + resistor3 + resistor4;
            MessageBox.Show("Total resistance =" + TotalResistance.ToString("0.00") + "ohms");

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double PResistor1 = double.Parse(textBox5.Text);
            double PResistor2 = double.Parse(textBox6.Text);
            double PResistor3 = double.Parse(textBox7.Text);
            double PRsistor4 = double.Parse(textBox8.Text);


        }
    }
}
