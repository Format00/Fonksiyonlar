using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fonksiyonlar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                double a;
                double b;
                double c;
                double d;
                double f = 1;

                double formul;
                double sonuc;

                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = Convert.ToDouble(textBox4.Text);

                formul = (f / a) + (f / b) + (f / c) + (f / d);
                sonuc = f / formul;

                label6.Text = sonuc.ToString();
            }
            if (checkBox1.Checked == false)
            {
                double a;
                double b;
                double c;
                double d;

                double formul;
                double sonuc;

                a = Convert.ToDouble(textBox1.Text);
                b = Convert.ToDouble(textBox2.Text);
                c = Convert.ToDouble(textBox3.Text);
                d = Convert.ToDouble(textBox4.Text);

                formul = a + b + c + d;
                sonuc = formul;
                label6.Text = sonuc.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            

            double a = 1;
            double b;
            double c = Convert.ToDouble(textBox7.Text);
            double x;
            if(comboBox3.Text == "NanoOHM")
            {
                b = 0.00000001;
                x = (b * c) / a;
                label8.Text = x.ToString();
            }

            if (comboBox3.Text == "MikroOHM")
            {
                b = 0.00001;
                x = (b * c) / a;
                label8.Text = x.ToString();
            }

            if (comboBox3.Text == "MiliOHM")
            {
                b = 0.01;
                x = (b * c) / a;
                label8.Text = x.ToString();
            }

            if (comboBox3.Text == "OHM")
            {
                b = 1;
                x = (b * c) / a;
                label8.Text = x.ToString();
            }

            if (comboBox3.Text == "KiloOHM")
            {
                b = 1000;
                x = (b * c) / a;
                label8.Text = x.ToString();
            }

            if (comboBox3.Text == "MegaOHM")
            {
                b = 1000000;
                x = (b * c) / a;
                label8.Text = x.ToString();
            }

            if (comboBox3.Text == "GigaOHM")
            {
                b = 1000000000;
                x = (b * c) / a;
                label8.Text = x.ToString();
                textBox1.Text = x.ToString();

                for (int i = 0; i >= 4; i++)
                {
                    if (i == 1)
                    {
                        textBox1.Text = x.ToString();
                    }
                    if (i == 2)
                    {
                        textBox2.Text = x.ToString();
                    }
                    if (i == 3)
                    {
                        textBox3.Text = x.ToString();
                    }
                    if (i == 4)
                    {
                        textBox4.Text = x.ToString();
                    }
                }
            }
            
        }
    }
}

//NanoOHM
//MikroOHM
//MiliOHM
//OHM
//KiloOHM
//MegaOHM
//GigaOHM