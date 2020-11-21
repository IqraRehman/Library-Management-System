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
    public partial class studrecord : Form
    {
        public studrecord()
        {
            InitializeComponent();
        }

        private void pUBLISHERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pUBLISHERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }

        private void studrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.dataSet2.STUDENT);
            // TODO: This line of code loads data into the 'dataSet2.PUBLISHER' table. You can move, or remove it, as needed.
           // this.pUBLISHERTableAdapter.Fill(this.dataSet2.PUBLISHER);
            display();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void display()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM STUDENT ORDER BY STUDENT_ID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            label3.Text = " ";
            nAMETextBox.Text = " ";
            gENDERTextBox.Text = " ";
            aDDRESSTextBox.Text = " ";
            pHONE_NOTextBox.Text = " ";
            eMAILTextBox.Text = " ";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            gENDERTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dOBDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            aDDRESSTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pHONE_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            eMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            //pASSWORDTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void sTUDENT_IDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            //string query = "UPDATE STUDENT SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + gENDERTextBox.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "', PASSWORD = '" + pASSWORDTextBox.Text + "' WHERE STUDENT_ID = '" + sTUDENT_IDTextBox.Text + "'";
            string query = "UPDATE STUDENT SET name = '" + nAMETextBox.Text + "', gender = '" + gENDERTextBox.Text + "', dob = '" + dOBDateTimePicker.Text + "', address = '" + aDDRESSTextBox.Text + "', phone_no = '" + pHONE_NOTextBox.Text + "', email = '" + eMAILTextBox.Text + "' where student_id = '" + label3.Text + " '";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "delete from student where student_id = '"+ label3.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data DELETED Successfully!");
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

        private void button4_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM STUDENT WHERE STUDENT_ID= '" + textBox1.Text+ "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void sTUDENT_IDTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            label3.Text = " ";
            nAMETextBox.Text = " ";
            gENDERTextBox.Text = " ";
            aDDRESSTextBox.Text = " ";
            pHONE_NOTextBox.Text = " ";
            eMAILTextBox.Text = " ";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
