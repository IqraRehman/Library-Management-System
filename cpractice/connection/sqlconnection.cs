using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace cpractice.connection
{
    class sqlconnection
    {
        public static string stringconnection = "DATA SOURCE=localhost:1521/xe;PASSWORD=practice;PERSIST SECURITY INFO=True;USER ID=C##PRACTICE";
        public static DataTable executeSQL(string sql)
        {
            OracleConnection conn = new OracleConnection();
            OracleDataAdapter adapter = default(OracleDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                conn.ConnectionString = stringconnection;
                conn.Open();

                adapter = new OracleDataAdapter(sql, conn);
                adapter.Fill(dt);
                conn.Close();

                conn = null;
                return dt;

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occured");
                dt = null;
            }
            return dt;
        }
    }
}
