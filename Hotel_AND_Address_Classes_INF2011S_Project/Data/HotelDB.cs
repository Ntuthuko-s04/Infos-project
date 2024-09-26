using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PhumlaKamnandiSystem.Business;

namespace PhumlaKamnandiSystem.Data
{
    internal class HotelDB : DB
    {
        #region  Data members        
        private string table = "Hotel";
        private string sqlLocal = "SELECT * FROM Hotel";
        private Collection<Hotel> Hotels;

        #endregion

        #region Property Method: Collection
        public Collection<Hotel> AllHotels
        {
            get
            {
                return Hotels;
            }
        }
        #endregion

        #region Constructor
        public HotelDB() : base()
        {
            Hotels = new Collection<Hotel>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods

        private int FindRow(Hotel Hotel, string table)
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
                    if (Hotel.HotelId.Equals(Convert.ToInt16(dsMain.Tables[table].Rows[rowIndex]["HotelId"])))
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
            //Declare references to a myRow object and an Hotel object
            DataRow myRow = null;
            Hotel Hotel;

            //READ from the table  
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    //Instantiate a new Hotel object
                    Hotel = new Hotel();
                    //Obtain each Hotel attribute from the specific field in the row in the table
                    Hotel.HotelId = Convert.ToInt16(myRow["HotelId"]);
                    Hotel.Name = Convert.ToString(myRow["Name"]).TrimEnd();
                    Hotel.Address = (Address)myRow["Address"];
                    Hotel.City = Convert.ToString(myRow["City"]).TrimEnd();
                    Hotel.Capacity = Convert.ToInt16(myRow["Capacity"]);

                    Hotels.Add(Hotel);
                }
            }
        }
        private void FillRow(DataRow aRow, Hotel Hotel, DB.DBOperation state)
        {

            if (state == DBOperation.Add)
            {
                aRow["HotelId"] = Hotel.HotelId;  //NOTE square brackets to indicate index of collections of fields in row.
            }
            aRow["Name"] = Hotel.Name;
            aRow["Address"] = Hotel.Address;
            aRow["City"] = Hotel.City;
            aRow["Capacity"] = Hotel.Capacity;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Hotel Hotel, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, Hotel, operation);
                    //Add to the dataset
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(Hotel, dataTable)];
                    FillRow(aRow, Hotel, operation);
                    break;
            }

        }

        private void Build_UPDATE_Parameters(Hotel Hotel)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Name", SqlDbType.VarChar, 100, "Name");
            param.SourceVersion = DataRowVersion.Current;
            daMain.UpdateCommand.Parameters.Add(param);


            param = new SqlParameter("@Name", SqlDbType.VarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.VarChar, 100, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@City", SqlDbType.VarChar, 100, "City");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Capacity", SqlDbType.Int, 15, "Capacity");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_HotelId", SqlDbType.Int, 15, "HotelId");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Hotel Hotel)
        {

            daMain.UpdateCommand = new SqlCommand("UPDATE Hotel SET Name =@Name, Phone =@Phone, Address =@Address, Capacity = @Capacity " + "WHERE HotelId = @Original_HotelId", cnMain);
            Build_UPDATE_Parameters(Hotel);
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Hotel Hotel)
        {
            //Create Parameters to communicate with SQL INSERT...add the input parameter and set its properties.
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@HotelId", SqlDbType.Int, 15, "HotelId");
            daMain.InsertCommand.Parameters.Add(param);//Add the parameter to the Parameters collection.

            param = new SqlParameter("@Name", SqlDbType.VarChar, 100, "Name");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Address", SqlDbType.VarChar, 100, "Address");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Capacity", SqlDbType.Int, 15, "Capacity");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@City", SqlDbType.VarChar, 100, "City");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Hotel Hotel)
        {
            //Create the command that must be used to insert values into the Books table..
            daMain.InsertCommand = new SqlCommand("INSERT Hotel SET Name =@Name, Address =@Address, City =@City, Capacity = @Capacity " + "WHERE HotelId = @Original_HotelId", cnMain);
            Build_INSERT_Parameters(Hotel);
        }
        

    public bool UpdateDataSource(Hotel Hotel)
    {
        bool success = true;
        Create_INSERT_Command(Hotel);
        Create_UPDATE_Command(Hotel);
        success = UpdateDataSource(sqlLocal, table);
        return success;
    }

    #endregion

}
}
