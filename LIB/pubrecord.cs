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

namespace LIB
{
    public partial class pubrecord : Form
    {
        public pubrecord()
        {
            InitializeComponent();
        }

        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        private void pubrecord_Load(object sender, EventArgs e)
        {
            display();

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pUBLISHER_NAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pUBLISHER_ADDTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pUBLISHER_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pUBLISHER_EMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM PUBLISHER ORDER BY PUBLISHER_ID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            pUBLISHER_NAMETextBox.Text = " ";
            pUBLISHER_EMAILTextBox.Text = " ";
            pUBLISHER_ADDTextBox.Text = " ";
            pUBLISHER_NOTextBox.Text = " ";
            label3.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO PUBLISHER(PUBLISHER_NAME, PUBLISHER_ADD,PUBLISHER_NO,PUBLISHER_EMAIL) VALUES('" + pUBLISHER_NAMETextBox.Text + "','" + pUBLISHER_ADDTextBox.Text + "','" + pUBLISHER_NOTextBox.Text + "','" + pUBLISHER_EMAILTextBox.Text + "' )";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                pUBLISHER_EMAILTextBox.Text = " ";
                pUBLISHER_NAMETextBox.Text = " ";
                pUBLISHER_NOTextBox.Text = " ";
                pUBLISHER_ADDTextBox.Text = " ";
                label3.Text = " ";
                display();
                MessageBox.Show("Publisher Record has been Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string query = "UPDATE PUBLISHER SET publisher_name = '" + pUBLISHER_NAMETextBox.Text + "', publisher_add = '" + pUBLISHER_ADDTextBox.Text + "', publisher_no = '" + pUBLISHER_NOTextBox.Text + "', publisher_email = '" + pUBLISHER_EMAILTextBox.Text + "' WHERE publisher_id = '" + label3.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string query = "delete from publisher where PUBLISHER_ID = '" + label3.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data DELETED Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            libdash obj = new libdash();
            obj.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM PUBLISHER WHERE PUBLISHER_ID = '" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            pUBLISHER_NAMETextBox.Text = " ";
            pUBLISHER_EMAILTextBox.Text = " ";
            pUBLISHER_ADDTextBox.Text = " ";
            pUBLISHER_NOTextBox.Text = " ";
        }
    }
}
