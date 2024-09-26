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
    internal class SeasonalReportDB : DB
    {
        #region  Data members        
        private string table = "SeasonalReport";
        private string sqlLocal = "SELECT * FROM SeasonalReport";
        private Collection<SeasonalReport> SeasonalReports;
        #endregion

        #region Property Method: Collection
        public Collection<SeasonalReport> AllSeasonalReports
        {
            get
            {
                return SeasonalReports;
            }
        }
        #endregion

        #region Constructor
        public SeasonalReportDB() : base()
        {
            SeasonalReports = new Collection<SeasonalReport>();
            FillDataSet(sqlLocal, table);
            Add2Collection(table);
        }
        #endregion

        #region Utility Methods
        private int FindRow(SeasonalReport SeasonalReport, string table)
        {
            int rowIndex = 0;
            DataRow myRow;
            int returnValue = -1;
            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (myRow.RowState != DataRowState.Deleted)
                {
                
                    if (SeasonalReport.Hotel.Equals(dsMain.Tables[table].Rows[rowIndex]["Hotel"]) &&
                        SeasonalReport.StartDate.Equals(Convert.ToDateTime(dsMain.Tables[table].Rows[rowIndex]["StartDate"])))
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
            SeasonalReport SeasonalReport;

            foreach (DataRow myRow_loopVariable in dsMain.Tables[table].Rows)
            {
                myRow = myRow_loopVariable;
                if (!(myRow.RowState == DataRowState.Deleted))
                {
                    SeasonalReport = new SeasonalReport((Hotel)myRow["Hotel"],
                                                        Convert.ToDateTime(myRow["StartDate"]),
                                                        Convert.ToDateTime(myRow["EndDate"]));
                    SeasonalReport.NumberOfGuests = Convert.ToInt32(myRow["NumberOfGuests"]);
                    SeasonalReport.AverageStay = Convert.ToInt32(myRow["AverageStay"]);
                    SeasonalReport.TotalBookings = Convert.ToInt32(myRow["TotalBookings"]);
                    SeasonalReport.TotalRevenue = Convert.ToDecimal(myRow["TotalRevenue"]);
                    SeasonalReport.CancellationRate = Convert.ToDouble(myRow["CancellationRate"]);
                    SeasonalReport.NumberOfCancellations = Convert.ToInt32(myRow["NumberOfCancellations"]);
                    SeasonalReports.Add(SeasonalReport);
                }
            }
        }

        private void FillRow(DataRow aRow, SeasonalReport SeasonalReport, DB.DBOperation state)
        {
            aRow["Hotel"] = SeasonalReport.Hotel;
            aRow["StartDate"] = SeasonalReport.StartDate;
            aRow["EndDate"] = SeasonalReport.EndDate;
            aRow["DateGenerated"] = SeasonalReport.DateGenerated;
            aRow["NumberOfGuests"] = SeasonalReport.NumberOfGuests;
            aRow["AverageStay"] = SeasonalReport.AverageStay;
            aRow["TotalBookings"] = SeasonalReport.TotalBookings;
            aRow["TotalRevenue"] = SeasonalReport.TotalRevenue;
            aRow["CancellationRate"] = SeasonalReport.CancellationRate;
            aRow["NumberOfCancellations"] = SeasonalReport.NumberOfCancellations;
        }
        #endregion

        #region Database Operations CRUD
        public void DataSetChange(SeasonalReport SeasonalReport, DB.DBOperation operation)
        {
            DataRow aRow = null;
            string dataTable = table;

            switch (operation)
            {
                case DB.DBOperation.Add:
                    aRow = dsMain.Tables[dataTable].NewRow();
                    FillRow(aRow, SeasonalReport, operation);
                    dsMain.Tables[dataTable].Rows.Add(aRow);
                    break;
                case DB.DBOperation.Edit:
                    aRow = dsMain.Tables[dataTable].Rows[FindRow(SeasonalReport, dataTable)];
                    FillRow(aRow, SeasonalReport, operation);
                    break;
            }
        }
        #endregion

        #region Build Parameters, Create Commands & Update database
        private void Build_INSERT_Parameters(SeasonalReport SeasonalReport)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Hotel", SqlDbType.Int, 15, "Hotel");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 8, "StartDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 8, "EndDate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@DateGenerated", SqlDbType.DateTime, 8, "DateGenerated");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfGuests", SqlDbType.Int, 15, "NumberOfGuests");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@AverageStay", SqlDbType.Int, 15, "AverageStay");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalBookings", SqlDbType.Int, 15, "TotalBookings");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalRevenue", SqlDbType.Decimal, 18, "TotalRevenue");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@CancellationRate", SqlDbType.Float, 8, "CancellationRate");
            daMain.InsertCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfCancellations", SqlDbType.Int, 15, "NumberOfCancellations");
            daMain.InsertCommand.Parameters.Add(param);
        }

        private void Create_INSERT_Command(SeasonalReport SeasonalReport)
        {
            daMain.InsertCommand = new SqlCommand("INSERT INTO SeasonalReport (Hotel, StartDate, EndDate, DateGenerated, NumberOfGuests, AverageStay, TotalBookings, TotalRevenue, CancellationRate, NumberOfCancellations) " +
                                                  "VALUES (@Hotel, @StartDate, @EndDate, @DateGenerated, @NumberOfGuests, @AverageStay, @TotalBookings, @TotalRevenue, @CancellationRate, @NumberOfCancellations)", cnMain);
            Build_INSERT_Parameters(SeasonalReport);
        }

        private void Build_UPDATE_Parameters(SeasonalReport SeasonalReport)
        {
            SqlParameter param = default(SqlParameter);
            param = new SqlParameter("@Hotel", SqlDbType.Int, 15, "Hotel");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@StartDate", SqlDbType.DateTime, 8, "StartDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@EndDate", SqlDbType.DateTime, 8, "EndDate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@DateGenerated", SqlDbType.DateTime, 8, "DateGenerated");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfGuests", SqlDbType.Int, 15, "NumberOfGuests");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@AverageStay", SqlDbType.Int, 15, "AverageStay");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalBookings", SqlDbType.Int, 15, "TotalBookings");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@TotalRevenue", SqlDbType.Decimal, 18, "TotalRevenue");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@CancellationRate", SqlDbType.Float, 8, "CancellationRate");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@NumberOfCancellations", SqlDbType.Int, 15, "NumberOfCancellations");
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_Hotel", SqlDbType.Int, 15, "Hotel");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);

            param = new SqlParameter("@Original_StartDate", SqlDbType.DateTime, 8, "StartDate");
            param.SourceVersion = DataRowVersion.Original;
            daMain.UpdateCommand.Parameters.Add(param);
        }

        private void Create_UPDATE_Command(SeasonalReport SeasonalReport)
        {
            daMain.UpdateCommand = new SqlCommand("UPDATE SeasonalReport SET EndDate = @EndDate, DateGenerated = @DateGenerated, " +
                                                  "NumberOfGuests = @NumberOfGuests, AverageStay = @AverageStay, TotalBookings = @TotalBookings, " +
                                                  "TotalRevenue = @TotalRevenue, CancellationRate = @CancellationRate, NumberOfCancellations = @NumberOfCancellations " +
                                                  "WHERE Hotel = @Original_Hotel AND StartDate = @Original_StartDate", cnMain);
            Build_UPDATE_Parameters(SeasonalReport);
        }

        public bool UpdateDataSource(SeasonalReport SeasonalReport)
        {
            bool success = true;
            Create_INSERT_Command(SeasonalReport);
            Create_UPDATE_Command(SeasonalReport);
            success = UpdateDataSource(sqlLocal, table);
            return success;
        }
        #endregion
    }
}
