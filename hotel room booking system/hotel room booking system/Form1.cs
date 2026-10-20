using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotel_room_booking_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btncalculate_Click(object sender, EventArgs e)
        {
            // 1. Check whether the guest name has been entered
            string guestName = txtGuestName.Text.Trim();

            if (guestName == "")
            {
                MessageBox.Show("Please enter guest name.");
                txtGuestName.Focus();
                return;
            }

            // 2. Use TryParse to validate numeric inputs
            int age, nights, guests;

            if (!int.TryParse(txtGuestAge.Text, out age) ||
                !int.TryParse(txtNights.Text, out nights) ||
                !int.TryParse(txtGuests.Text, out guests))
            {
                MessageBox.Show("Please enter valid numbers.");
                return;
            }

            // 3. Validate input limits
            if (age < 18 || age > 90)
            {
                MessageBox.Show("Guest age must be between 18 and 90.");
                return;
            }

            if (nights < 1 || nights > 30)
            {
                MessageBox.Show("Nights must be between 1 and 30.");
                return;
            }

            if (guests < 1 || guests > 6)
            {
                MessageBox.Show("Guests must be between 1 and 6.");
                return;
            }

            // 4. Determine room rate and capacity
            double rate = 0;
            int maxGuests = 0;
            string roomType = "";

            switch (true)
            {
                case true when rdoStandard.Checked:
                    rate = 50;
                    maxGuests = 2;
                    roomType = "Standard";
                    break;

                case true when rdoNormal.Checked:
                    rate = 80;
                    maxGuests = 4;
                    roomType = "Normal";
                    break;

                case true when rdoHight.Checked:
                    rate = 130;
                    maxGuests = 6;
                    roomType = "Hight";
                    break;

                default:
                    MessageBox.Show("Please select a room type.");
                    return;
            }

            // 5. Check room capacity
            if (guests > maxGuests)
            {
                MessageBox.Show(
                    roomType + " room allows maximum " +
                    maxGuests + " guests.");
                return;
            }

            // 6. Calculate room cost
            double roomCost = rate * nights * guests;

            // Calculate the discount based on the number of nights
            double nightDiscount = 0;

            if (nights >= 10)
                nightDiscount = 0.12;
            else if (nights >= 5)
                nightDiscount = 0.05;

            // Calculate the senior citizen discount
            double seniorDiscount = age >= 60 ? 0.05 : 0;

            // Combine the discounts
            double totalDiscount = nightDiscount + seniorDiscount;

            double discountAmount = roomCost * totalDiscount;
            double discountedRoomCost = roomCost - discountAmount;

            // Calculate breakfast cost: $10 per guest per night
            double breakfastCost = 0;

            if (chkBreakfast.Checked)
                breakfastCost = 10 * guests * nights;

            // Calculate the 5% service charge for more than 4 guests
            double serviceCharge = 0;

            if (guests > 4)
                serviceCharge = discountedRoomCost * 0.05;

            // Calculate the total booking cost
            double total = discountedRoomCost
                           + breakfastCost
                           + serviceCharge;

            // 7. Display the booking details
            lstBookingDetails.Items.Clear();

            lstBookingDetails.Items.Add("HOTEL BOOKING DETAILS");
            lstBookingDetails.Items.Add("--------------------------");
            lstBookingDetails.Items.Add("Guest Name: " + guestName);
            lstBookingDetails.Items.Add("Guest Age: " + age);
            lstBookingDetails.Items.Add("Room Type: " + roomType);
            lstBookingDetails.Items.Add("Rate Per Night: $" + rate);
            lstBookingDetails.Items.Add("Number of Nights: " + nights);
            lstBookingDetails.Items.Add("Number of Guests: " + guests);
            lstBookingDetails.Items.Add("Room Cost: $" + roomCost.ToString("F2"));
            lstBookingDetails.Items.Add("Discount: $" + discountAmount.ToString("F2"));
            lstBookingDetails.Items.Add("Breakfast: $" + breakfastCost.ToString("F2"));
            lstBookingDetails.Items.Add("Service Charge: $" + serviceCharge.ToString("F2"));
            lstBookingDetails.Items.Add("TOTAL: $" + total.ToString("F2"));
            // Approve the booking
            bool approved = true;

            if (approved)
                MessageBox.Show("Booking Approved!");
            else
                MessageBox.Show("Booking Rejected!");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Clear all input fields
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            // Reset room type selections
            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            // Uncheck the breakfast option
            chkBreakfast.Checked = false;

            // Clear the booking details
            lstBookingDetails.Items.Clear();

            // Return the cursor to the guest name field
            txtGuestName.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application window
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtGuestName.Clear();
            txtGuestAge.Clear();
            txtNights.Clear();
            txtGuests.Clear();

            rdoStandard.Checked = false;
            rdoNormal.Checked = false;
            rdoHight.Checked = false;

            chkBreakfast.Checked = false;
            lstBookingDetails.Items.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

