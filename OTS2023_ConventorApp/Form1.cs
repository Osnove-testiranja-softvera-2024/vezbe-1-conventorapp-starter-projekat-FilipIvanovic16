using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTS2023_ConventorApp
{
    public partial class Form1 : Form
    {   
        
        public Form1()
        {
            InitializeComponent();

            

        }
         
        private void radioMass_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Pounds";
            label2.Text = "Kilogram";
        }

        private void radioLength_CheckedChanged(object sender, EventArgs e)
        {
            label1.Text = "Feet";
            label2.Text = "Meters";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioMass.Checked == true)
            {
                MassConverter converter = new MassConverter();
                textBox2.Text = converter.Convert(Convert.ToInt64(textBox1.Text)).ToString();

            }
            else if(radioLength.Checked == true)
            {
                LengthConverter converter = new LengthConverter();
                textBox2.Text = converter.Convert(Convert.ToInt64(textBox1.Text)).ToString();
            }
        }
    }
}
