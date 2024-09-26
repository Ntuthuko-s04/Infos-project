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
    internal class HotelController
    {
        #region Data Members
        HotelDB HotelDB;
        Collection<Hotel> Hotels;
        #endregion

        #region Properties
        public Collection<Hotel> AllHotels
        {
            get
            {
                return Hotels;
            }
        }
        #endregion

        #region Constructor
        public HotelController()
        {
            //***instantiate the HotelDB object to communicate with the database
            HotelDB = new HotelDB();
            Hotels = HotelDB.AllHotels;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Hotel Hotel, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            HotelDB.DataSetChange(Hotel, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    Hotels.Add(Hotel); //*** Add the Hotel to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(Hotel);
                    Hotels[index] = Hotel;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(Hotel);
                    Hotels[index] = null;
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Hotel Hotel)
        {
            //***call the HotelDB method that will commit the changes to the database
            return HotelDB.UpdateDataSource(Hotel);
        }
        #endregion

        #region Search Method

        private int FindIndex(Hotel Hotel)
        {
            int counter = 0;
            bool found = false;
            found = (Hotel.HotelId == Hotels[counter].HotelId);

            while (!found)
            {
                counter++;
                found = (Hotel.HotelId == Hotels[counter].HotelId);
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
        public Hotel Find(string HotelId)
        {
            int index = 0;
            Boolean found = (Hotels[index].HotelId.Equals(HotelId)); //checks if it is the first Hotel. The found variable will be searching for an Hotel
            int count = Hotels.Count();
            while (!(found) && (index < Hotels.Count - 1)) //if you have not found the Hotel AND you have not reached the end of the collection – write
            {
                index++;
                found = (Hotels[index].HotelId.Equals(HotelId));
            }
            return Hotels[index]; // we have found the Hotel
        }
        #endregion

    }
}
