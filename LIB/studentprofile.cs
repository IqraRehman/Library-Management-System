using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace LIB
{
    public partial class studentprofile : Form
    {
        public studentprofile()
        {
            InitializeComponent();
        }
        public static int selectedrow;
        public static string studentno = " ";
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
        
        private void studentprofile_Load(object sender, EventArgs e)
        {
            //display data gridview when form load
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.ShowDialog();
        }
        //show data on grid view
        private void display()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select roll_no, name, gender ,dob, email,phone_no, address,class, photo_id From student where LOWER(email) = '" + Form1.email.ToLower() + "'";
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
            textBox2.Text = " ";
            textBox3.Text = " ";
            pictureBox1.Image = null;
            DataGridViewRow row = this.dataGridView1.Rows[selectedrow];
            label4.Text = row.Cells["ROLL_NO"].Value.ToString();
            studentno = label4.Text;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //display data on textbox when double click on gridview
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Byte[] data = new Byte[0];
            data = (Byte[])(dataGridView1.SelectedRows[0].Cells[8].Value);
            MemoryStream mem = new MemoryStream(data);

            textBox2.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            dOBDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            eMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            pHONE_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            aDDRESSTextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromStream(mem);

        }
        //update data
        private void button1_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            //query for update data
            string query = "UPDATE STUDENT SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + textBox1.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "', Roll_no = '" + textBox2.Text + "', class = '" + textBox3.Text + "' WHERE email = '" + Form1.email + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
