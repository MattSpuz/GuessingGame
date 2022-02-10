using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrossPayCalculator
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the program
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears the form for the next calculations
            hoursTextBox.Text = string.Empty;
            wageTextBox.Text = string.Empty;
            outputLabel.Text = string.Empty;

            //set focus back to the hourstextbox
            hoursTextBox.Focus();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                //named constants
                const double BASE_HOUR = 40.0;
                const double OT_MULTIPLIER = 1.5;

                //local variables
                double hoursWorked = 0;
                double payRate = 0;
                double basePay = 0;
                double overTimeHours = 0;
                double overTimePay = 0;
                double grossPay = 0;

                //get input from the user, assign to variables
                hoursWorked = double.Parse(hoursTextBox.Text);
                payRate = double.Parse(wageTextBox.Text);

                //Determine the gross pay
                if (hoursWorked > BASE_HOUR)
                {
                    //calculate base pay without OT
                    basePay = payRate * BASE_HOUR;

                    //calculate overtime hours
                    overTimeHours = hoursWorked - BASE_HOUR;

                    //calculate overtime pay
                    overTimePay = overTimeHours * payRate * OT_MULTIPLIER;

                    //calculate the gross pay
                    grossPay = basePay + overTimePay;
                }
                else
                {
                    grossPay = hoursWorked * payRate;
                }
                //display gross pay
                outputLabel.Text = grossPay.ToString("C");
            }
            catch(Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }



    }
}
