using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Range_Checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btncheck_Click(object sender, EventArgs e)
        {
            try
            {
                int number = int.Parse(txtrange.Text);
                if (number >= 1 && number <= 10)
                {
                    lblrangedecision.Text = "The number is within the range ";
                }
                else
                {
                    lblrangedecision.Text = "The number is outside the range ";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtrange.Clear();
            lblrangedecision.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
