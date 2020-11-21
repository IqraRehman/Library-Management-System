using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;


namespace cpractice
{
    public partial class returnbooks : Form
    {
        public returnbooks()
        {
            InitializeComponent();
        }
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD = mypswrd";
        public string returndate = " ";
        public string actualreturn = " ";
        private void rETURNBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rETURNBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void returnbooks_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.RETURN' table. You can move, or remove it, as needed.
            this.rETURNTableAdapter.Fill(this.dataSet2.RETURN);
            display();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            rETURN_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            rETURN_ACTUAL_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            fINETextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            sTUDENT_IDTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            iSBNTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM RETURN ORDER BY STUDENT_ID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            label2.Text = librarianlogin.cnic;
            iSBNTextBox.Text = " ";
            sTUDENT_IDTextBox.Text = " ";
            fINETextBox.Text = " ";
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

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            //string query = "UPDATE STUDENT SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + gENDERTextBox.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "', PASSWORD = '" + pASSWORDTextBox.Text + "' WHERE STUDENT_ID = '" + sTUDENT_IDTextBox.Text + "'";
            string query = "UPDATE RETURN SET RETURN_DATE = '" + rETURN_DATEDateTimePicker.Text + "', RETURN_ACTUAL_DATE = '" + rETURN_ACTUAL_DATEDateTimePicker.Text + "', STUDENT_ID = '" + sTUDENT_IDTextBox.Text + "', ISBN = '" + iSBNTextBox.Text + "', FINE = '" + fINETextBox.Text + "' where student_id = '" + sTUDENT_IDTextBox.Text + " '";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iSBNTextBox_TextChanged(object sender, EventArgs e)
        {

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
            if(diff > 0)
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

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
          foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                int fine = Convert.ToInt32(row.Cells[2].Value);
                if (fine == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
