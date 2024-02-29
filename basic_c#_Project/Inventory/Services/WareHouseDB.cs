using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using System.Windows.Input;

namespace Inventory
{
    internal class WareHouseDB : IWareHouseDB
    {
        private string connectionString = "Data Source=.;Initial Catalog=DB_INVENTORY;Integrated_security=true;";
        public bool Delete(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DATE_TIME)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Delete From TBL_DCHR where DCHR_INVID=@DCHR_INVID and DCHR_PRID=@DCHR_PRID and DCHR_RCID=@DCHR_RCID and DCHR_DATE_TIME=@DCHR_DATE_TIME";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DCHR_INVID", DCHR_INVID);
                command.Parameters.AddWithValue("@DCHR_PRID", DCHR_PRID);
                command.Parameters.AddWithValue("@DCHR_RCID", DCHR_RCID);
                command.Parameters.AddWithValue("@DCHR_DATE_TIME", DCHR_DATE_TIME);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();

            }
        }
        public bool Insert(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DCHRNUM, string DCHR_DATE_TIME)
        {
            int num = Int16.Parse(DCHR_DCHRNUM);
            SqlConnection connection = new SqlConnection(connectionString);
            try {
                string query = "Insert Into TBL_DCHR (DCHR_INVID,DCHR_PRID,DCHR_RCID,DCHR_DCHRNUM,DCHR_DATE_TIME) values (@DCHR_INVID,@DCHR_PRID,@DCHR_RCID,@DCHR_DCHRNUM,@DCHR_DATE_TIME)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DCHR_INVID", DCHR_INVID);
                command.Parameters.AddWithValue("@DCHR_PRID", DCHR_PRID);
                command.Parameters.AddWithValue("@DCHR_RCID", DCHR_RCID);
                command.Parameters.AddWithValue("@DCHR_DCHRNUM", num);
                command.Parameters.AddWithValue("@DCHR_DATE_TIME", DCHR_DATE_TIME);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch(Exception ex) {
                return false;
                throw new Exception(ex.Message);  
            }
            finally { 
                connection.Close();
            }
            
        }

        public DataTable Search(string parameter)
        {
            string query = "Select * From TBL_DCHR Where DCHR_INVID like @parameter";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            adapter.SelectCommand.Parameters.AddWithValue("@parameter", "%"+parameter+"%");
            DataTable data = new DataTable();

            adapter.Fill(data);
            return data;
        }

        public DataTable SelectAll()
        {
            string query = "Select * From TBL_DCHR";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable data = new DataTable();

            adapter.Fill(data);
            return data;
        }

        public DataTable SelectRow(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DATE_TIME)
        {
            string query = "Select * From TBL_DCHR where DCHR_INVID=@DCHR_INVID and DCHR_PRID=@DCHR_PRID and DCHR_RCID=@DCHR_RCID and DCHR_DATE_TIME=@DCHR_DATE_TIME";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DCHR_INVID", DCHR_INVID);
            command.Parameters.AddWithValue("@DCHR_PRID", DCHR_PRID);
            command.Parameters.AddWithValue("@DCHR_RCID", DCHR_RCID);
            command.Parameters.AddWithValue("@DCHR_DATE_TIME", DCHR_DATE_TIME);
            connection.Open();
            command.ExecuteNonQuery();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable data = new DataTable();
            adapter.Fill(data);
            return data;
        }

        public bool Update(string DCHR_INVID, string DCHR_PRID, string DCHR_RCID, string DCHR_DCHRNUM, string DCHR_DATE_TIME)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                string query = "Update TBL_DCHR Set DCHR_INVID=@DCHR_INVID,DCHR_PRID=@DCHR_PRID,DCHR_RCID=@DCHR_RCID,DCHR_DCHRNUM=@DCHR_DCHRNUM,DCHR_DATE_TIME=@DCHR_DATE_TIME " +
                               "Where DCHR_INVID=@DCHR_INVID and DCHR_PRID=@DCHR_PRID and DCHR_RCID=@DCHR_RCID and DCHR_DATE_TIME=@DCHR_DATE_TIME";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@DCHR_INVID", DCHR_INVID);
                command.Parameters.AddWithValue("@DCHR_PRID", DCHR_PRID);
                command.Parameters.AddWithValue("@DCHR_RCID", DCHR_RCID);
                command.Parameters.AddWithValue("@DCHR_DCHRNUM", DCHR_DCHRNUM);
                command.Parameters.AddWithValue("@DCHR_DATE_TIME", DCHR_DATE_TIME);
                connection.Open();
                command.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
