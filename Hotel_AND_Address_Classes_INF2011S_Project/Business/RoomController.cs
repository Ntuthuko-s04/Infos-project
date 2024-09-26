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
    internal class RoomController
    {
        #region Data Members
        RoomDB RoomDB;
        Collection<Room> Rooms;
        #endregion

        #region Properties
        public Collection<Room> AllRooms
        {
            get
            {
                return Rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomController()
        {
            //***instantiate the RoomDB object to communicate with the database
            RoomDB = new RoomDB();
            Rooms = RoomDB.AllRooms;
        }
        #endregion

        #region Database Communication.
        public void DataMaintenance(Room Room, DB.DBOperation operation)
        {
            int index = 0;
            //perform a given database operation to the dataset in meory; 
            RoomDB.DataSetChange(Room, operation);

            switch (operation)
            {
                case DB.DBOperation.Add:
                    Rooms.Add(Room); //*** Add the Room to the Collection
                    break;
                case DB.DBOperation.Edit:
                    index = FindIndex(Room);
                    Rooms[index] = Room;
                    break;
                case DB.DBOperation.Delete:
                    index = FindIndex(Room);
                    Rooms[index] = null;
                    break;
            }
        }

        //***Commit the changes to the database
        public bool FinalizeChanges(Room Room)
        {
            //***call the RoomDB method that will commit the changes to the database
            return RoomDB.UpdateDataSource(Room);
        }
        #endregion

        #region Search Method

        private int FindIndex(Room Room)
        {
            int counter = 0;
            bool found = false;
            found = (Room.RoomId == Rooms[counter].RoomId);

            while (!found)
            {
                counter++;
                found = (Room.RoomId == Rooms[counter].RoomId);
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
        public Room Find(string RoomId)
        {
            int index = 0;
            Boolean found = (Rooms[index].RoomId.Equals(RoomId)); //checks if it is the first Room. The found variable will be searching for an Room
            int count = Rooms.Count();
            while (!(found) && (index < Rooms.Count - 1)) //if you have not found the Room AND you have not reached the end of the collection – write
            {
                index++;
                found = (Rooms[index].RoomId.Equals(RoomId));
            }
            return Rooms[index]; // we have found the Room
        }
        #endregion

    }
}

