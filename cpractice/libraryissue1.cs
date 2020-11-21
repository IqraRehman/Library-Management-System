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
    public partial class libraryissue1 : Form
    {
        public libraryissue1()
        {
            InitializeComponent();
        }

        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD = mypswrd";
        private void libraryissue1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.BORROW' table. You can move, or remove it, as needed.
            this.bORROWTableAdapter.Fill(this.dataSet2.BORROW);
            display();
        }

        private void bORROWBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bORROWBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);
            
        }
        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM BORROW ORDER BY STUDENT_ID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            label2.Text = librarianlogin.cnic;
            iSBNTextBox.Text = " ";
            sTUDENT_IDTextBox.Text = " ";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            iSSUE_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            rETURN_ACTUAL_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            sTUDENT_IDTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            iSBNTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO BORROW VALUES('" + iSSUE_DATEDateTimePicker.Text + "','" + rETURN_ACTUAL_DATEDateTimePicker.Text + "','" + sTUDENT_IDTextBox.Text + "','" + iSBNTextBox.Text + "')";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                updateStatus();
                sTUDENT_IDTextBox.Text = " ";
                iSBNTextBox.Text = " ";
                display();
                MessageBox.Show("Book has been issued");
            }
        }
        void updateStatus()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string st = "issued";
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
            string query = "UPDATE BORROW SET ISSUE_DATE = '" + iSSUE_DATEDateTimePicker.Text + "',RETURN_ACTUAL_DATE = '" + rETURN_ACTUAL_DATEDateTimePicker.Text + "' ,STUDENT_ID = '" + sTUDENT_IDTextBox.Text + "' ,ISBN = '" + iSBNTextBox.Text + "' WHERE STUDENT_ID = '" + sTUDENT_IDTextBox.Text +"'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Update Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sTUDENT_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
