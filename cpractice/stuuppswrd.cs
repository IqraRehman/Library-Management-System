using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace cpractice
{
    public partial class stuuppswrd : Form
    {
        public stuuppswrd()
        {
            InitializeComponent();
        }
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string query = "UPDATE STUDENT SET PASSWORD = '" + textBox2.Text + "'WHERE EMAIL = '" + textBox1.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Updated password successfully!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
