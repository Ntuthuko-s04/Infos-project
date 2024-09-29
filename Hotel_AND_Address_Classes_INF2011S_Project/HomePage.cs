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
using PhumlaKamnandiSystem.Business;

namespace PhumlaKamnandiSystem.Presentation
{
    public partial class HomePage : Form
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
        public bool homePageClosed = false;
        #endregion

        #region Constructor
        public HomePage()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            guestController = new GuestController();
            bookingController = new BookingController();
            hotelController = new HotelController();

        }
        #endregion

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Creatingbtn_Click(object sender, EventArgs e)
        {
            PopulateObject();
            booking = new Booking();
            if (guestController.Find(guest.Email) == null)
            {
                guest.GuestId = (++guestCounter);
            }
            booking.BookingReference = (++bookingCounter);
            booking.GetStatus = Booking.Status.NotPaid;
            


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
            if (txtPhoneNo.Text.Length == 10)
            {
                guest.CellPhoneNumber = Convert.ToInt32(txtPhoneNo.Text);

            }else { MessageBox.Show("Invalid Phone number"); }
            setUpListView1();
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
        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            hotel = hotelController.Find(listView1.SelectedItems[0].Text);
            //PopulateObject();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void HomePage_Load_1(object sender, EventArgs e)
        {

        }
    }
}