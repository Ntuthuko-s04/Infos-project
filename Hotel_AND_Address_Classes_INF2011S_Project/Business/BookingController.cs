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
    internal class BookingController
    {
        #region Data Members
        BookingDB BookingDB;
        Collection<Booking> Bookings;
        #endregion

        #region Properties
        public Collection<Booking> AllBookings
        {
            get
            {
                return Bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingController()
        {
            //***instantiate the BookingDB object to communicate with the database
            BookingDB = new BookingDB();
            Bookings = BookingDB.AllBookings;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Booking Booking, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            BookingDB.DataSetChange(Booking, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    Bookings.Add(Booking); //*** Add the Booking to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(Booking);
                    Bookings[index] = Booking;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(Booking);
                    Bookings[index] = null;
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Booking Booking)
        {
            //***call the BookingDB method that will commit the changes to the database
            return BookingDB.UpdateDataSource(Booking);
        }
        #endregion

        #region Search Method

        private int FindIndex(Booking Booking)
        {
            int counter = 0;
            bool found = false;
            found = (Booking.BookingReference == Bookings[counter].BookingReference);

            while (!found)
            {
                counter++;
                found = (Booking.BookingReference == Bookings[counter].BookingReference);
            }

            if (found)
            {
                return counter;
            }
            else
            {
                return -1;
            }
        }
        public Booking Find(string BookingId)
        {
            int index = 0;
            Boolean found = (Bookings[index].BookingReference.Equals(BookingId)); //checks if it is the first Booking. The found variable will be searching for an Booking
            int count = Bookings.Count();
            while (!(found) && (index < Bookings.Count - 1)) //if you have not found the Booking AND you have not reached the end of the collection – write
            {
                index++;
                found = (Bookings[index].BookingReference.Equals(BookingId));
            }
            return Bookings[index]; // we have found the Booking
        }
        #endregion

    }
}
