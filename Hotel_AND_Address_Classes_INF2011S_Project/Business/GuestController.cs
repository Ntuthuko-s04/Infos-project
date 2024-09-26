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
    internal class GuestController
    {
        #region Data Members
        GuestDB GuestDB;
        Collection<Guest> Guests;
        #endregion

        #region Properties
        public Collection<Guest> AllGuests
        {
            get
            {
                return Guests;
            }
        }
        #endregion

        #region Constructor
        public GuestController()
        {
            //***instantiate the GuestDB object to communicate with the database
            GuestDB = new GuestDB();
            Guests = GuestDB.AllGuests;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Guest guest, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            GuestDB.DataSetChange(guest, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    Guests.Add(guest); //*** Add the Guest to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(guest);
                    Guests[index] = guest;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(guest);
                    Guests[index] = null;
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Guest Guest)
        {
            //***call the GuestDB method that will commit the changes to the database
            return GuestDB.UpdateDataSource(Guest);
        }
        #endregion

        #region Search Method

        private int FindIndex(Guest guest)
        {
            int counter = 0;
            bool found = false;
            found = (guest.GuestId == Guests[counter].GuestId);

            while (!found)
            {
                counter++;
                found = (guest.GuestId == Guests[counter].GuestId);
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
        public Guest Find(string GuestId)
        {
            int index = 0;
            Boolean found = (Guests[index].GuestId.Equals(GuestId)); //checks if it is the first Guest. The found variable will be searching for an Guest
            int count = Guests.Count();
            while (!(found) && (index < Guests.Count - 1)) //if you have not found the Guest AND you have not reached the end of the collection – write
            {
                index++;
                found = (Guests[index].GuestId.Equals(GuestId));
            }
            return Guests[index]; // we have found the Guest
        }
        #endregion

    }
}
