using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace cpractice
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        
        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter.Fill(this.library.STUDENT);
            comboBox1.Items.Add("Male");
            comboBox1.Items.Add("Fmale");
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 obj = new Form1();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO STUDENT(name,gender,dob,address,phone_no,email,password) VALUES('" + nAMETextBox.Text + "' ,'" + comboBox1.Text + "','" + dOBDateTimePicker.Text + "','" + aDDRESSTextBox.Text + "', '" + pHONE_NOTextBox.Text + "','" + eMAILTextBox.Text + "','" + pASSWORDTextBox.Text + "')";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {

            nAMETextBox.Text = " ";
            comboBox1.Text = " ";
            aDDRESSTextBox.Text = " ";
            pHONE_NOTextBox.Text = " ";
            pASSWORDTextBox.Text = " ";
            eMAILTextBox.Text = " ";
                MessageBox.Show("User has been registered");
            }
        }
      /*  int getoracleseq()
        {
            int seqval;
             OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
             conn.Open();
             OracleCommand cmd = new OracleCommand();
             cmd.Connection = conn;
             cmd.CommandText = "SELECT STUD_SEQ.NEXTVAL FROM DUAL";
             cmd.CommandType = CommandType.Text;
             seqval = Int16.Parse(cmd.ExecuteScalar().ToString());
             return seqval;

        }*/

        
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library);

        }

        private void aDDRESSLabel_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void nAMETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
