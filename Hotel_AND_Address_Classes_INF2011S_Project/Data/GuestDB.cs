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
    internal class GuestDB: DB
    {
        #region  Data members        
        private string table = "Guest";
        private string sqlLocal = "SELECT * FROM Guest";
        private Collection<Guest> Guests;

        #endregion

        #region Property Method: Collection
        public Collection<Guest> AllGuests
        {
            get
            {
                return Guests;
            }
        }
        #endregion

        #region Constructor
        public GuestDB() : base()
        {
            Guests = new Collection<Guest>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods

        private int FindRow(Guest Guest, string table)
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
                    if (Guest.GuestId.Equals(Convert.ToInt16(dsMain.Tables[table].Rows[rowIndex]["GuestId"])))
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
            //Declare references to a myRow object and an Guest object
            DataRow myRow = null;
            Guest Guest;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Guest object
                    Guest = new Guest();
                    //Obtain each Guest attribute from the specific field in the row in the table
                    Guest.GuestId = Convert.ToInt16(myRow["GuestId"]);
                    Guest.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    Guest.Surname = Convert.ToString(myRow["Surname"]).TrimEnd();
                    Guest.Email = Convert.ToString(myRow["Email"]).TrimEnd();
                    Guest.MemberShipId = Convert.ToInt16(myRow["MemberShipId"]);

                    Guests.Add(Guest);
                }
            }
        }
        private void FillRow(DataRow aRow, Guest Guest, DB.DBOperation state)
        {

            if (state == DBOperation.Add)
            {
                aRow["GuestId"] = Guest.GuestId;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = Guest.Name;
            aRow["Surname"] = Guest.Surname;
            aRow["Email"] = Guest.Email;
            aRow["MemberShipId"] = Guest.MemberShipId;
            aRow["CellPhoneNumber"] = Guest.CellPhoneNumber;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Guest Guest, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, Guest, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(Guest, dataTable)];
                    FillRow(aRow, Guest, operation);
                    break;
            }

        }

        private void Build_UPDATE_Parameters(Guest Guest)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Name", SqlDbType.VarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            param = new SqlParameter("@Name", SqlDbType.VarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.VarChar, 100, "Surname");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.VarChar, 100, "Email");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@MemberShipId", SqlDbType.Int, 15, "MemberShipId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CellPhoneNumber", SqlDbType.Int, 10, "CellPhoneNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_GuestId", SqlDbType.Int, 15, "GuestId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Guest Guest)
        {

            daMain.UpdateCommand = new SqlCommand("UPDATE Guest SET Name =@Name, Phone =@Phone, Surname =@Surname, MemberShipId = @MemberShipId " + "WHERE GuestId = @Original_GuestId", cnMain);
            Build_UPDATE_Parameters(Guest);
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Guest Guest)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@GuestId", SqlDbType.Int, 15, "GuestId");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Name", SqlDbType.VarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Surname", SqlDbType.VarChar, 100, "Surname");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@MemberShipId", SqlDbType.Int, 15, "MemberShipId");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CellPhoneNumber", SqlDbType.Int, 10, "CellPhoneNumber");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Email", SqlDbType.Int, 15, "Email");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Guest Guest)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT Guest SET Name =@Name, CellPhoneNumber =@CellPhoneNumber, Surname =@Surname, MemberShipId = @MemberShipId " + "WHERE GuestId = @Original_GuestId", cnMain);
            Build_INSERT_Parameters(Guest);
        }

    public bool UpdateDataSource(Guest Guest)
    {
        bool success = true;
        Create_INSERT_Command(Guest);
        Create_UPDATE_Command(Guest);
        success = UpdateDataSource(sqlLocal, table);
        return success;
    }

    #endregion
}
}
