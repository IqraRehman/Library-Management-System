using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace LIB
{
    public partial class issuebooks : Form
    {
        public issuebooks()
        {
            InitializeComponent();
        }

        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD = mypswrd";
        private void issuebooks_Load(object sender, EventArgs e)
        {
            display();
        }

        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ROLL_NO, ISBN, ISSUE_dATE, RETURN_ACTUAL_dATE FROM BORROW ORDER BY roll_no";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            label2.Text = Form1.cnic;
            iSBNTextBox.Clear();
            sTUDENT_IDTextBox.Clear();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            sTUDENT_IDTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            iSBNTextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            iSSUE_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            rETURN_ACTUAL_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            
            OracleCommand cmd = new OracleCommand();
            int get = checkIsbn();
            if (get == 1)
            {
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
                    sTUDENT_IDTextBox.Clear();
                    iSBNTextBox.Clear();
                    display();
                    MessageBox.Show("Book has been issued");
                }
            }
            else
            {
                MessageBox.Show("Book is not available");
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

        int checkIsbn()
        {
            int check = -1;
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT *FROM BOOKS WHERE ISBN = :ISBN";
            cmd.Connection = conn;
            cmd.Parameters.Add(new OracleParameter(":ISBN", iSBNTextBox.Text));
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                 string isbn = dr["isbn"].ToString();
                if(iSBNTextBox.Text.ToString() == isbn)
                {
                    check = 1;
                    //MessageBox.Show("Book is not available");
                    
                }
                else
                {
                    check = 0;
                }
            }
            return check;

        }
        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string query = "UPDATE BORROW SET ISSUE_DATE = '" + iSSUE_DATEDateTimePicker.Text + "',RETURN_ACTUAL_DATE = '" + rETURN_ACTUAL_DATEDateTimePicker.Text + "' ,roll_no = '" + sTUDENT_IDTextBox.Text + "' ,ISBN = '" + iSBNTextBox.Text + "' WHERE ROLL_NO = '" + sTUDENT_IDTextBox.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Update Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            libdash obj = new libdash();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(constring);
                conn.Open();
                //var query = "Select borrow.roll_no,student.name,borrow.issue_date,borrow.return_actual_date,borrow.isbn,student.class from student inner join borrow on borrow.roll_no = student.roll_no where borrow.roll_no = '" + textBox1.Text + "'or Lower(student.class) = '" + textBox2.Text.ToLower() + "'";
                var query = "select *From issuestudent where roll_no = '" + textBox1.Text +"'or lower(class) = '" + textBox2.Text.ToLower() + "'";
                OracleCommand cmd = new OracleCommand(query, conn);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                textBox1.Clear();
                textBox2.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
