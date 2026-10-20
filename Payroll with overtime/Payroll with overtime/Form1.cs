using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Payroll_with_overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            try
            {

                double hours, rate, grosspay;


                if (double.TryParse(txthourswork.Text, out hours) &&
                    double.TryParse(txthourlypayrate.Text, out rate))
                {

                    if (hours <= 30)
                    {
                        grosspay = hours * rate;
                    }

                    else
                    {
                        grosspay = (30 * rate) + ((hours - 30) * rate * 1.5);
                    }


                    lblgrosspay.Text = grosspay.ToString("");
                }
                else
                {
                    MessageBox.Show("Please enter valid Hours Worked and Hourly Pay Rate");
                }
            }
            catch
            {
                MessageBox.Show("An error occurred");
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txthourswork.Clear();
            txthourlypayrate.Clear();

            lblgrosspay.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
