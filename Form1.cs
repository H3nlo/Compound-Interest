using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6_Interest_37279432
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calculatebtn_Click(object sender, EventArgs e)
        {
            //local variables
            double A;
            double n;
            double r;
            int count = 0;

            if(double.TryParse(AmountInvestedInput.Text, out A)) //get initial amount invested.
            {
                if(double.TryParse(YearsInvestedInput.Text, out n)) //get the amount of years invested.
                {
                    if(double.TryParse(InterestRateInput.Text, out r)) // get the value of interest rate.
                    {
                        //the loop calculates and outputs the results.
                        while (count < n)
                        {
                            A = A + ((r/100) * A);

                            count = count + 1;
                        lbOutput.Items.Add("After " + count + " years the amount is: " + A.ToString("c"));
                        }
                    }
                    else
                    {
                        //error message for invalid value for interest rate.
                        MessageBox.Show("Invalid value for Interest rate.");
                    }
                }
                else
                {
                    //error message for invalid years invested.
                    MessageBox.Show("Invalid value for years invested.");
                }
            }
            else
            {
                //error message for invalid amount invested.
                MessageBox.Show("Invalid value for Initail amount invested."); 
            }

        }

        private void Exitbtn_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
    }
}
