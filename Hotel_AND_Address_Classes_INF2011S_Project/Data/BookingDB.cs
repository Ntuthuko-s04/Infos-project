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
    internal class BookingDB: DB
    {
        #region  Data members        
        private string table = "Booking";
        private string sqlLocal = "SELECT * FROM Booking";
        private Collection<Booking> Bookings;

        #endregion

        #region Property Method: Collection
        public Collection<Booking> AllBookings
        {
            get
            {
                return Bookings;
            }
        }
        #endregion

        #region Constructor
        public BookingDB() : base()
        {
            Bookings = new Collection<Booking>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods

        private int FindRow(Booking Booking, string table)
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
                    if (Booking.BookingReference.Equals(Convert.ToInt16(dsMain.Tables[table].Rows[rowIndex]["BookingReference"])))
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
            //Declare references to a myRow object and an Booking object
            DataRow myRow = null;
            Booking Booking;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Booking object
                    Booking = new Booking();
                    //Obtain each Booking attribute from the specific field in the row in the table
                    Booking.BookingReference = Convert.ToInt16(myRow["BookingReference"]);
                    Booking.GetStatus = (Booking.Status)(myRow["Status"]);
                    Booking.RoomId = Convert.ToInt16(myRow["RoomId"]);
                    Booking.GuestId = Convert.ToInt16(myRow["GuestId"]);
                    Bookings.Add(Booking);
                }
            }
        }
        private void FillRow(DataRow aRow, Booking Booking, DB.DBOperation state)
        {

            if (state == DBOperation.Add)
            {
                aRow["BookingReference"] = Booking.BookingReference;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Status"] = Booking.Status.NotAvailable;
            aRow["RoomId"] = Booking.RoomId;
            aRow["GuestId"] = Booking.GuestId;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Booking Booking, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, Booking, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(Booking, dataTable)];
                    FillRow(aRow, Booking, operation);
                    break;
            }

        }

        private void Build_UPDATE_Parameters(Booking Booking)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Status", SqlDbType.VarChar, 100, "Status");
            daMain.InsertCommand.Parameters.Add(param);


            param = new SqlParameter("@RoomId", SqlDbType.Int, 15, "RoomId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestId", SqlDbType.Int, 15, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_BookingReference", SqlDbType.Int, 15, "BookingReference");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Booking Booking)
        {

            daMain.UpdateCommand = new SqlCommand("UPDATE Booking SET Status =@Status, RoomId =@RoomId, GuestId = @GuestId " + "WHERE BookingReference = @Original_BookingReference", cnMain);
            Build_UPDATE_Parameters(Booking);
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Booking Booking)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@BookingReference", SqlDbType.Int, 15, "BookingReference");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Status", SqlDbType.VarChar, 100, "Status");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@GuestId", SqlDbType.Int, 15, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@RoomId", SqlDbType.Int, 15, "RoomId");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Booking Booking)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT Booking SET Status =@Status, Phone =@Phone, SurStatus =@SurStatus, GuestId = @GuestId " + "WHERE BookingReference = @Original_BookingReference", cnMain);
            Build_INSERT_Parameters(Booking);
        }

    public bool UpdateDataSource(Booking Booking)
    {
        bool success = true;
        Create_INSERT_Command(Booking);
        Create_UPDATE_Command(Booking);
        success = UpdateDataSource(sqlLocal, table);
        return success;
    }

    #endregion
}
}
