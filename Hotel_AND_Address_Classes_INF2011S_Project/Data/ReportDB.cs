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
    internal class ReportDB : DB
    {
        #region  Data members        
        private string table = "Report";
        private string sqlLocal = "SELECT * FROM Report";
        private Collection<Report> Reports;
        #endregion

        #region Property Method: Collection
        public Collection<Report> AllReports
        {
            get
            {
                return Reports;
            }
        }
        #endregion

        #region Constructor
        public ReportDB() : base()
        {
            Reports = new Collection<Report>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods
        private int FindRow(Report Report, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                    if (Report.ReportID.Equals(dsMain.Tables[table].Rows[rowIndex]["ReportID"]))
                    {
                        returnValue = rowIndex;
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
            DataRow myRow = null;
            Report Report;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    Report = new Report((Room)myRow["Room"], (Hotel)myRow["Hotel"], (Guest)myRow["Guest"], 
                                        Convert.ToString(myRow["ReportID"]), 
                                        Convert.ToDateTime(myRow["CheckInDate"]), 
                                        Convert.ToDateTime(myRow["CheckOutDate"]));
                    Reports.Add(Report);
                }
            }
        }

        private void FillRow(DataRow aRow, Report Report, DB.DBOperation state)
        {
            if (state == DBOperation.Add)
            {
                aRow["ReportID"] = Report.ReportID;
            }
            aRow["Room"] = Report.Room;
            aRow["Hotel"] = Report.Hotel;
            aRow["Guest"] = Report.Guest;
            aRow["CheckInDate"] = Report.CheckInDate;
            aRow["CheckOutDate"] = Report.CheckOutDate;
            aRow["DateGenerated"] = Report.DateGenerated;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(Report Report, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, Report, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(Report, dataTable)];
                    FillRow(aRow, Report, operation);
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(Report Report)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@ReportID", SqlDbType.VarChar, 50, "ReportID");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Room", SqlDbType.Int, 15, "Room");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Hotel", SqlDbType.Int, 15, "Hotel");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@Guest", SqlDbType.Int, 15, "Guest");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 8, "CheckInDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 8, "CheckOutDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DateGenerated", SqlDbType.DateTime, 8, "DateGenerated");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(Report Report)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO Report (ReportID, Room, Hotel, Guest, CheckInDate, CheckOutDate, DateGenerated) " +
                                                  "VALUES (@ReportID, @Room, @Hotel, @Guest, @CheckInDate, @CheckOutDate, @DateGenerated)", cnMain);
            Build_INSERT_Parameters(Report);
        }

        private void Build_UPDATE_Parameters(Report Report)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Room", SqlDbType.Int, 15, "Room");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Hotel", SqlDbType.Int, 15, "Hotel");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Guest", SqlDbType.Int, 15, "Guest");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckInDate", SqlDbType.DateTime, 8, "CheckInDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CheckOutDate", SqlDbType.DateTime, 8, "CheckOutDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DateGenerated", SqlDbType.DateTime, 8, "DateGenerated");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_ReportID", SqlDbType.VarChar, 50, "ReportID");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(Report Report)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE Report SET Room =@Room, Hotel =@Hotel, Guest = @Guest, " +
                                                  "CheckInDate = @CheckInDate, CheckOutDate = @CheckOutDate, DateGenerated = @DateGenerated " +
                                                  "WHERE ReportID = @Original_ReportID", cnMain);
            Build_UPDATE_Parameters(Report);
        }

        public bool UpdateDataSource(Report Report)
        {
            bool success = true;
            Create_INSERT_Command(Report);
            Create_UPDATE_Command(Report);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion
    }
}
