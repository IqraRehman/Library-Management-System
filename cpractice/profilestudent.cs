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
using System.Data.Common.CommandTrees.ExpressionBuilder;
using System.Security.Cryptography.X509Certificates;
using System.Data.SqlClient;

namespace cpractice
{
    public partial class profilestudent : Form
    {
        public profilestudent()
        {
            InitializeComponent();
        }
        public static int selectedrow;
        public static string studentno= " ";
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library);

        }

        private void profilestudent_Load(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            // TODO: This line of code loads data into the 'dataSet2.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter1.Fill(this.dataSet2.STUDENT);
            // TODO: This line of code loads data into the 'library.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.library.STUDENT);
            display();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "UPDATE STUDENT SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + textBox1.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "' WHERE STUDENT_ID = '" + label2.Text + "'"; 
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void display()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *From student where LOWER(email) = '" + Form1.email.ToLower() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            nAMETextBox.Text = " ";
            eMAILTextBox.Text = " ";
            pHONE_NOTextBox.Text = " ";
            aDDRESSTextBox.Text = " ";
            textBox1.Text = " ";
            DataGridViewRow row = this.dataGridView1.Rows[selectedrow];
            label2.Text = row.Cells["STUDENT_ID"].Value.ToString();
            studentno = label2.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void nAMETextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void dOBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
           
        }

        private void aDDRESSTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pHONE_NOTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void eMAILTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pASSWORDTextBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dOBDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            aDDRESSTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pHONE_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            eMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //pASSWORDTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
