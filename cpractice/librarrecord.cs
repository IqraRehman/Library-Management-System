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

namespace cpractice
{
    public partial class librarrecord : Form
    {
        public librarrecord()
        {
            InitializeComponent();
        }

        private void lIBRARIANBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lIBRARIANBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void librarrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.LIBRARIAN' table. You can move, or remove it, as needed.
            this.lIBRARIANTableAdapter.Fill(this.dataSet2.LIBRARIAN);
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void display()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *From LIBRARIAN where CNIC = '" + librarianlogin.cnic + "'";
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

        private void button1_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "UPDATE LIBRARIAN SET CNIC = '" + cNICTextBox.Text + "', NAME = '" + nAMETextBox.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', LIB_NO = '" + lIB_NOTextBox.Text + "', LIB_EMAIL = '" + lIB_EMAILTextBox.Text + "' WHERE CNIC = '" + librarianlogin.cnic + "'";
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
           // pASSWORDTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            lIB_EMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

      /*  private void button3_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "delete from student where cnic = '" + cNICTextBox.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data DELETED Successfully!");
        }*/
    }
}
