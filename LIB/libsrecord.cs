using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;
using System.Configuration;

namespace LIB
{
    public partial class libsrecord : Form
    {
        public libsrecord()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void display()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select cnic, name, address,lib_no,lib_email From LIBRARIAN where CNIC = '" + Form1.cnic + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            cNICTextBox.Text = " ";
            nAMETextBox.Text = " ";
            lIB_EMAILTextBox.Text = " ";
            aDDRESSTextBox.Text = " ";
            lIB_NOTextBox.Text = " ";

        }

        private void libsrecord_Load(object sender, EventArgs e)
        {
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            libdash obj = new libdash();
            obj.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "UPDATE LIBRARIAN SET CNIC = '" + cNICTextBox.Text + "', NAME = '" + nAMETextBox.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', LIB_NO = '" + lIB_NOTextBox.Text + "', LIB_EMAIL = '" + lIB_EMAILTextBox.Text + "' WHERE CNIC = '" + Form1.cnic + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cNICTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            aDDRESSTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            lIB_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            lIB_EMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
    }
}
