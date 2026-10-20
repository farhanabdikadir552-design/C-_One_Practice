using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vehicle_rental_managment_sys
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

        
            private void btncalculate_Click(object sender, EventArgs e)
        {
            int age, days, exp;

            if (!int.TryParse(txtage.Text, out age) ||
                !int.TryParse(txtdays.Text, out days) ||
                !int.TryParse(txtexperience.Text, out exp))
            {
                MessageBox.Show("Invalid input!");
                return;
            }

            decimal rate = rdEconomy.Checked ? 35 :
                           rdsuv.Checked ? 60 : 100;

            if (age < 21 || days < 1 || days > 30 || exp < 1)
            {
                MessageBox.Show("Not eligible!");
                return;
            }

            if (rdluxury.Checked && (age < 25 || exp < 3))
            {
                MessageBox.Show("Luxury requires age 25+ and 3 years experience!");
                return;
            }

            decimal basic = rate * days;
            decimal discount = days >= 14 ? basic * 0.10m :
                               days >= 7 ? basic * 0.05m : 0;
            decimal insurance = chkinsurance.Checked ? 15 * days : 0;
            decimal surcharge = age <= 24 ? basic * 0.10m : 0;
            decimal total = basic - discount + insurance + surcharge;

            lstresult.Items.Clear();
            lstresult.Items.Add("Customer: " + txtname.Text);
            lstresult.Items.Add("Basic Cost: $" + basic);
            lstresult.Items.Add("Discount: $" + discount);
            lstresult.Items.Add("Insurance: $" + insurance);
            lstresult.Items.Add("Surcharge: $" + surcharge);
            lstresult.Items.Add("Final Cost: $" + total);
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtage.Clear();
            txtdays.Clear();
            txtexperience.Clear();
            rdEconomy.Checked = false;
            rdsuv.Checked = false;
            rdluxury.Checked = false;
            chkinsurance.Checked = false;
            lstresult.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }
    
