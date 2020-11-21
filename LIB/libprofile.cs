using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace LIB
{
    public partial class librarianprofile : Form
    {
        public librarianprofile()
        {
            InitializeComponent();
        }

        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD = mypswrd";
        public string returndate = " ";
        public string actualreturn = " ";
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rETURN_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            rETURN_ACTUAL_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            iSBNTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            sTUDENT_IDTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void libprofile_Load(object sender, EventArgs e)
        {
            display();
        }
        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM RETURN ORDER BY Roll_no";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            label2.Text = Form1.cnic;
            iSBNTextBox.Text = " ";
            sTUDENT_IDTextBox.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            updateStatus();
            cmd.CommandText = "INSERT INTO RETURN VALUES('" + rETURN_DATEDateTimePicker.Text + "','" + rETURN_ACTUAL_DATEDateTimePicker.Text + "','" + calculate_fine() + "','" + sTUDENT_IDTextBox.Text + "','" + iSBNTextBox.Text + "')";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                sTUDENT_IDTextBox.Text = " ";
                iSBNTextBox.Text = " ";
                display();
                MessageBox.Show("Book has been Returned");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            //string query = "UPDATE STUDENT SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + gENDERTextBox.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "', PASSWORD = '" + pASSWORDTextBox.Text + "' WHERE STUDENT_ID = '" + sTUDENT_IDTextBox.Text + "'";
            string query = "UPDATE RETURN SET RETURN_DATE = '" + rETURN_DATEDateTimePicker.Text + "', RETURN_ACTUAL_DATE = '" + rETURN_ACTUAL_DATEDateTimePicker.Text + "', roll_no = '" + sTUDENT_IDTextBox.Text + "', ISBN = '" + iSBNTextBox.Text + "', Fine = '" + calculate_fine() + "' where roll_no = '" + sTUDENT_IDTextBox.Text + " '";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }
        public int calculate_fine()
        {
            int diff;
            int Fine = 0;
            CultureInfo culture = new CultureInfo("en-US");
            returndate = rETURN_DATEDateTimePicker.Text;
            actualreturn = rETURN_ACTUAL_DATEDateTimePicker.Text;
            DateTime date = DateTime.ParseExact(returndate, "dd-MMMM-yyyy", culture);
            int day = date.Day;
            DateTime date1 = DateTime.ParseExact(actualreturn, "dd-MMMM-yyyy", culture);
            int day1 = date1.Day;
            Fine = 0;
            diff = day - day1;
            if (diff > 0)
            {
                for (int i = 1; i <= diff; i++)
                {
                    Fine += 50;

                }
            }
            else
            {
                Fine = 0;
            }
            return Fine;
        }
        void updateStatus()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string st = "not issued";
            //string query = "UPDATE STUDENT SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + gENDERTextBox.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "', PASSWORD = '" + pASSWORDTextBox.Text + "' WHERE STUDENT_ID = '" + sTUDENT_IDTextBox.Text + "'";
            string query = "UPDATE BOOKS SET STATUS = '" + st + "' where isbn = '" + iSBNTextBox.Text + " '";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            libdash obj = new libdash();
            obj.ShowDialog();
        }
    }
}