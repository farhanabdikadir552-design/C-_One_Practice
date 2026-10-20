using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace airline_ticket_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {


      
            // 1. Read and validate input
            string passengerName = txtPassengerName.Text.Trim();

            int age;
            int numberOfTickets;
            decimal baggageWeight;

            bool bookingApproved = false;

            if (passengerName == "")
            {
                MessageBox.Show("Please enter passenger name.");
                return;
            }

            if (!int.TryParse(txtPassengerAge.Text, out age))
            {
                MessageBox.Show("Please enter a valid age.");
                return;
            }

            if (!int.TryParse(txtBaggageWeight.Text, out numberOfTickets))
            {
                MessageBox.Show("Please enter a valid number of tickets.");
                return;
            }

            if (!decimal.TryParse(txtBaggageWeight.Text, out baggageWeight))
            {
                MessageBox.Show("Please enter a valid baggage weight.");
                return;
            }

            // 2. Check booking rules
            if (age < 1 || age > 100)
            {
                MessageBox.Show("Passenger age must be between 1 and 100.");
                return;
            }

            if (numberOfTickets < 1 || numberOfTickets > 5)
            {
                MessageBox.Show("Number of tickets must be between 1 and 5.");
                return;
            }

            if (baggageWeight < 0 || baggageWeight > 50)
            {
                MessageBox.Show(
                    "Baggage weight must be between 0 and 50 kg per passenger.");
                return;
            }

            if (age < 12 && rdoFirstClass.Checked)
            {
                MessageBox.Show(
                    "Booking rejected: Passengers below 12 cannot book First Class.");
                return;
            }

            // All validation rules passed
            bookingApproved = true;

            // 3. Get ticket price based on travel class
            decimal ticketPrice = 0;

            if (rdoFirstClass.Checked)
            {
                ticketPrice = 500;
            }
            else if (rdoNormalClass.Checked)
            {
                ticketPrice = 200;
            }
            else if (rdoBusinessClass.Checked)
            {
                ticketPrice = 350;
            }
            else
            {
                MessageBox.Show("Please select a travel class.");
                bookingApproved = false;
                return;
            }

            // 4. Calculate basic ticket cost
            decimal basicTicketCost = ticketPrice * numberOfTickets;

            // 5. Calculate discounts
            decimal discountRate = 0;

            // Discount for number of tickets
            if (numberOfTickets >= 3 && numberOfTickets <= 4)
            {
                discountRate += 0.05m;
            }
            else if (numberOfTickets == 5)
            {
                discountRate += 0.10m;
            }

            // Child discount
            if (age < 12)
            {
                discountRate += 0.20m;
            }

            // Senior discount
            if (age >= 60)
            {
                discountRate += 0.15m;
            }

            decimal discountAmount = basicTicketCost * discountRate;

            decimal discountedCost = basicTicketCost - discountAmount;

            // 6. Add travel insurance
            decimal insuranceCost = 0;

            if (chkTravelInsurance.Checked)
            {
                insuranceCost = 25 * numberOfTickets;
            }

            // Baggage up to 20 kg per passenger is free.
            // The assignment does not specify a fee for extra baggage.

            decimal finalCost = discountedCost + insuranceCost;

            // 7. Display booking details
            string bookingDetails =
                "AIRLINE BOOKING DETAILS\n\n" +
                "Passenger Name: " + passengerName + "\n" +
                "Passenger Age: " + age + "\n" +
                "Number of Tickets: " + numberOfTickets + "\n" +
                "Baggage Weight: " + baggageWeight + " kg\n" +
                "Travel Class: " +
                (rdoFirstClass.Checked ? "First Class" :
                rdoNormalClass.Checked ? "Normal Class" : "Business Class") +
                "\n\n" +
                "Basic Ticket Cost: $" + basicTicketCost.ToString("0.00") + "\n" +
                "Discount: $" + discountAmount.ToString("0.00") + "\n" +
                "Insurance Cost: $" + insuranceCost.ToString("0.00") + "\n" +
                "Final Cost: $" + finalCost.ToString("0.00") + "\n\n" +
                "Booking Approved: " + bookingApproved;

            MessageBox.Show(bookingDetails, "Booking Details");
        }


        private void btnclear_Click(object sender, EventArgs e)
        {
          
            txtPassengerName.Clear();
            txtPassengerAge.Clear();
            txtBaggageWeight.Clear();
            txtbaggage.Clear();

            rdoFirstClass.Checked = false;
            rdoNormalClass.Checked = false;
            rdoBusinessClass.Checked = false;

            chkTravelInsurance.Checked = false;

            AirlineBookingDetails.Items.Clear();
        }
        
        
        private void btnexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    }

