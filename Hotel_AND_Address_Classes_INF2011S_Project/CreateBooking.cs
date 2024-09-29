using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhumlaKamnandiSystem.Presentation
{
    public partial class Create_Booking: Form
    {

        #region Members
        private Collection<Hotel> hotels;
        private HotelController hotelController;
        private Hotel hotel;
        private int guestCounter = 0;
        private int bookingCounter = 0;
        private Guest guest;
        private GuestController guestController;
        private Booking booking;
        private BookingController bookingController;
        public bool createBookingFormClosed = false;
        private DateTime checkIn, checkOut;


        #endregion

        public Create_Booking()
        {
            InitializeComponent();
            guestController = new GuestController();
            bookingController = new BookingController();
            hotelController = new HotelController();
            hotelbtn.BackColor = Color.Red;

            this.Load += Create_Booking_Load1;
            this.Activated += Create_Booking_Activated;
            this.FormClosed += Create_Booking_FormClosed;
        }

        private void Create_Booking_FormClosed(object sender, FormClosedEventArgs e)
        {
            createBookingFormClosed = true;
        }

        private void Create_Booking_Activated(object sender, EventArgs e)
        {
        }

        private void Create_Booking_Load1(object sender, EventArgs e)
        {
        }

        private void RoomType_Enter(object sender, EventArgs e)
        {
            RoomType.Text = "Hotels Available";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Booking_Load(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMembershipID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCellphoneNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void PopulateObject()
        {

            guest = new Guest();
            guest.Name = txtName.Text;
            guest.Surname = txtSurname.Text;
            if (txtEmail.Text.Contains("@"))
            {
                guest.Email = txtEmail.Text;
            }
            else { MessageBox.Show("Please put in a correct email Address"); }
            if (txtCellphoneNo.Text.Length == 10)
            {
                guest.CellPhoneNumber = Convert.ToInt32(txtCellphoneNo.Text);
                

            }
            else { MessageBox.Show("Invalid Phone number"); }
            if  (txtEmail.Text.Contains("@") && txtCellphoneNo.Text.Length == 10)
            {
                if (checkOut.CompareTo(checkIn) >= 0)
                {
                    setUpListView1();
                    hotelbtn.BackColor = Color.Green;
                }
                else
                {
                    MessageBox.Show("Your checkOut date is before check in date");
                }
            }
            
        }

        private void setUpListView1()
        {
            ListViewItem hotelDetails;
            hotels = null;
            hotels = hotelController.AllHotels;
            listView1.Clear();
            listView1.View = View.Details;
            listView1.FullRowSelect = true;

            listView1.Columns.Insert(0, "Name", 120, HorizontalAlignment.Center);
            listView1.Columns.Insert(0, "Address", 120, HorizontalAlignment.Center);
            listView1.Columns.Insert(0, "City", 120, HorizontalAlignment.Center);

            foreach (Hotel hotel in hotels)
            {
                hotelDetails = new ListViewItem();
                hotelDetails.Text = hotel.Name;
                hotelDetails.SubItems.Add(hotel.Address.ToString());
                hotelDetails.SubItems.Add(hotel.City.ToString());
                listView1.Items.Add(hotelDetails);
            }
            listView1.Refresh();
            listView1.GridLines = true;
            listView1.Show();
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            hotel = hotelController.Find(listView1.SelectedItems[1].Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Dates_Enter(object sender, EventArgs e)
        {

        }

        private void CheckOutDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = (DateTimePicker)sender;
            picker.MinDate = checkIn.AddDays(1);
            checkOut = CheckOutDateTimePicker.Value;
            
        }

        private void hotelbtn_Click(object sender, EventArgs e)
        {
            if (hotelbtn.BackColor == Color.Green)
            {
                PopulateObject();
            }
            else
            {
                MessageBox.Show("Please check if all the fields are filled.");
            }
            
        }

        private void CheckIndateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTimePicker picker = (DateTimePicker)sender;
            picker.MinDate = DateTime.Today;
            checkIn = CheckIndateTimePicker1.Value;
            
        }
    }
}
