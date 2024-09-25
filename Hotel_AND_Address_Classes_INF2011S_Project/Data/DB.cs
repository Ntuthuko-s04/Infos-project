using System;
using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhumlaKamnandiSystem.Properties;//***needs to be added to be able to use the Settings property

namespace PhumlaKamnandiSystem.Data{
    public class DB{
        #region members
        //***Once the database is created you can find the correct connection string by using the Settings.Default object to select the correct connection string
        private string strConn = Settings.Default.PhumlaKamnandiDatabaseConnectionString;
        protected SqlConnection cnMain;
        protected DataSet dsMain;
        protected SqlDataAdapter daMain;
    }

    #endregion

        #region  Constructors
     public DB(){
     try{
         //Open a connection & create a new dataset object
         cnMain = new SqlConnection(strConn);
         dsMain = new DataSet();
     }
     catch (SystemException e){
         System.Windows.Forms.MessageBox.Show(e.Message, "Error");
         return;
        }
    }
    #endregion

    
        #region Update the data source 
        protected bool UpdateDataSource(string sqlLocal, string table)
        {
            bool success;
            try {
                //open the connection
                cnMain.Open();
                //***update the database table via the data adapter
                daMain.Update(dsMain, table);
                //---close the connection
                cnMain.Close();
                //refresh the dataset
                FillDataSet(sqlLocal, table);
                success = true;
            }
            catch (Exception errObj){
                MessageBox.Show(errObj.Message + "  " + errObj.StackTrace);
                success = false;
            }
            return success;
        }
        #endregion
}
