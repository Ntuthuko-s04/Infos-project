using PhumlaKamnandiSystem.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiSystem.Business
{
    public class InvoiceController
    {
        private BookingController bookingController;
        private RoomController roomController;
        private HotelController hotelController;
        private GuestController guestController;

        public InvoiceController()
        {
            bookingController = new BookingController();
            roomController = new RoomController();
            hotelController = new HotelController();
            guestController = new GuestController();
        }

        //use the find index method

    }
