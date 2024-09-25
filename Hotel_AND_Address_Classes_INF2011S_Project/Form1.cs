using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_AND_Address_Classes_INF2011S_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public class Hotel
        {
            public string Name { get; set; }
            public Address HotelAddress { get; set; } // Composition relationship with Address
            public int Rooms { get; set; }
            public List<string> Facilities { get; set; }
            public (decimal minRate, decimal maxRate) RateRange { get; set; }
            public double OccupancyRate { get; set; } // Average occupancy rate as a percentage

            // Constructor
            public Hotel(string name, Address address, int rooms, List<string> facilities, (decimal, decimal) rateRange, double occupancyRate)
            {
                Name = name;
                HotelAddress = address;
                Rooms = rooms;
                Facilities = facilities;
                RateRange = rateRange;
                OccupancyRate = occupancyRate;
            }

            // Override ToString method for a readable string representation
            public override string ToString()
            {
                return $"Hotel: {Name}\n" +
                       $"Address: {HotelAddress}\n" +
                       $"Rooms: {Rooms}\n" +
                       $"Facilities: {string.Join(", ", Facilities)}\n" +
                       $"Rate Range: R{RateRange.minRate} - R{RateRange.maxRate}\n" +
                       $"Occupancy Rate: {OccupancyRate}%";
            }
            private void Form1_Load(object sender, EventArgs e)
            {

            }
        }
    }
}
