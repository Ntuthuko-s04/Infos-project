using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhumlaKamnandiSystem.Business
{

    internal class Room
    {
        private int _roomNumber;
        public enum Status{ 
            vacant,
            occupied
        }
        private int _hotelId;
        private int _roomId;
        public Status status;
       

        public int RoomNumber
        {
            get { return _roomNumber; }
            set { _roomNumber = value; }
        }
        
        public int RoomId
        {
            get { return _roomId; }
            set { _roomId = value; }
        }

        public int HotelId
        {
            get { return _hotelId; }
            set { _hotelId = value; }
        }

        public Status getStatus
        {
            get { return status; }
            set { status = value; }
        }

        public Room() { }
        public Room(int roomId, int roomNum, Status status, int hotelId)
        {
            _roomId = roomId;
            _hotelId=hotelId;
            _roomNumber = roomNum;
            getStatus = status;
        }
    }
}
