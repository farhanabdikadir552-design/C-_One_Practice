using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_score_average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            double score1, score2, score3, average;

            try
            {

                if (double.TryParse(txtscore1.Text, out score1))
                {
                    if (double.TryParse(txtscore2.Text, out score2))
                    {
                        if (double.TryParse(txtscore3.Text, out score3))
                        {


                            average = (score1 + score2 + score3) / 3;


                            lblaverageresulte.Text = average.ToString("");
                        }
                        else
                        {

                            MessageBox.Show("Please enter a valid Test Score 1");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid Test Score 2");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid Test Score 3");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(" Error " + ex.Message);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtscore1.Clear();
            txtscore2.Clear();
            txtscore3.Clear();
            lblaverageresulte.Text = "";
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
