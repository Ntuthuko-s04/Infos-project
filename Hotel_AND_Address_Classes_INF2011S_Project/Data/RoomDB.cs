using PhumlaKamnandiSystem.Business;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static PhumlaKamnandiSystem.Data.DB;

namespace PhumlaKamnandiSystem.Data
{
    internal class RoomDB: DB
    {
        #region  Data members        
        private string table = "Room";
        private string sqlLocal = "SELECT * FROM Room";
        private Collection<Room> Rooms;

        #endregion

        #region Property Method: Collection
        public Collection<Room> AllRooms
        {
            get
            {
                return Rooms;
            }
        }
        #endregion

        #region Constructor
        public RoomDB() : base()
        {
            Rooms = new Collection<Room>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods

        private int FindRow(Room Room, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                //Ignore rows marked as deleted in dataset
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (Room.RoomId.Equals(Convert.ToInt16(dsMain.Tables[table].Rows[rowIndex]["RoomId"])))
                    {
                        rowIndex = returnValue;
                    }
                }
                rowIndex++;
            }
            return returnValue;
        }
        public DataSet GetDataSet()
        {
            return dsMain;
        }
        private void Add2Collection(string table)
        {
            //Declare references to a myRow object and an Room object
            DataRow myRow = null;
            Room Room;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Room object
                    Room = new Room();
                    //Obtain each Room attribute from the specific field in the row in the table
                    Room.RoomId = Convert.ToInt16(myRow["RoomId"]);
                    Room.RoomNumber = Convert.ToInt16(myRow["RoomNumber"]);
                    Room.getStatus = (Room.Status)(myRow["Status"]);
                    Room.HotelId = Convert.ToInt16(myRow["HotelId"]);

                    Rooms.Add(Room);
                }
            }
        }
        private void FillRow(DataRow aRow, Room Room, DB.DBOperation state)
        {

            if (state == DBOperation.Add)
            {
                aRow["RoomId"] = Room.RoomId;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["RoomNumber"] = Room.RoomNumber;
            aRow["Status"] = Room.getStatus;
            aRow["HotelId"] = Room.HotelId;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Room Room, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, Room, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(Room, dataTable)];
                    FillRow(aRow, Room, operation);
                    break;
            }

        }

        private void Build_UPDATE_Parameters(Room Room)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomNumber", SqlDbType.VarChar, 100, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.VarChar, 100, "Status");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelId", SqlDbType.Int, 15, "HotelId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_RoomId", SqlDbType.Int, 15, "RoomId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Room Room)
        {

            daMain.UpdateCommand = new SqlCommand("UPDATE Room SET RoomNumber =@RoomNumber, Status = @Status, HotelId = @HotelId " + "WHERE RoomId = @Original_RoomId", cnMain);
            Build_UPDATE_Parameters(Room);
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Room Room)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@RoomId", SqlDbType.Int, 15, "RoomId");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@RoomNumber", SqlDbType.Int, 4, "RoomNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@HotelId", SqlDbType.Int, 15, "HotelId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Status", SqlDbType.VarChar, 100, "Status");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Room Room)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT Room SET RoomNumber =@RoomNumber, Status =@Status, HotelId = @HotelId " + "WHERE RoomId = @Original_RoomId", cnMain);
            Build_INSERT_Parameters(Room);
        }

    public bool UpdateDataSource(Room Room)
    {
        bool success = true;
        Create_INSERT_Command(Room);
        Create_UPDATE_Command(Room);
        success = UpdateDataSource(sqlLocal, table);
        return success;
    }

    #endregion
    }
}
