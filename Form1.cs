//Prac6.2

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prac6._2_Project_37279432
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
            double compound;
            double result;
            double compoundtype = 0;
            double A;
            double n;
            double r;
            int count = 0;
            
            

            if (double.TryParse(AmountInvestedInput.Text, out A)) //get initial amount invested.
            {
                if (double.TryParse(numberofPeriodsInput.Text, out n)) //get the amount of years/months invested.
                {
                    if (double.TryParse(InterestRateInput.Text, out r)) // get the value of interest rate.
                    {
                       
                        if (cbyearly.Checked)
                        {
                            compoundtype = 1;
                        }
                        if (cbQuarterly.Checked)
                        {
                            compoundtype = 4;
                        }
                        if (cbMonthly.Checked)
                        {
                            compoundtype = 12;
                        }
                        //the loop calculates and outputs the results.
                        while (count < n)
                        {
                            double i = r / 100;
                            compound = A * (1 + (i / compoundtype));
                            result = Math.Pow(compound, (n * compoundtype));
                            lbOutput.Items.Add("your interest is" + compound.ToString("c"));
                            count = count + 1;
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
            this.Close();
        }
    }
}
