using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        double[] masyvas = new double[10];
        int counter = 0;
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            double a = Convert.ToDouble(textBox1.Text);
            if (counter < 9)
            {
                int counterbackwards = 9 - counter;
                label2.Text = "Truksta " + counterbackwards + " skaiciu! Papildykite masyva!";

                masyvas[counter] = a;

                for(int i = 0; i <= counter; i++)
                {
                    richTextBox1.AppendText(String.Join(" ",masyvas[i]));
                    richTextBox1.AppendText(" ");

                }
                richTextBox1.AppendText(Environment.NewLine);
                counter++;

            }else if(counter == 9)
            {
                masyvas[counter] = a;
                counter++;
                label2.Text = "Masyve yra " + counter + " skaiciu! Masyvas uzpildytas";

                //richTextBox1.Text = String.Join("Masyvo suma: ", masyvas.Sum()); //, " Masyvo suma: ", masyvas.Sum()

                richTextBox1.AppendText("Masyvo suma: "); 
                richTextBox1.AppendText(String.Join("", masyvas.Sum()));
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
