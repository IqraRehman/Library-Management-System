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
    public partial class libstudent : Form
    {
        public libstudent()
        {
            InitializeComponent();
        }

        public static int selectedrow;
        public static string studentno = " ";
       // OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void display()
        {
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select roll_no, name,email, gender ,dob,phone_no, address,class, photo_id From studentview order by roll_no";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            nAMETextBox.Clear();
            eMAILTextBox.Clear();
            pHONE_NOTextBox.Clear();
            aDDRESSTextBox.Clear();
            textBox1.Clear();
            textBox3.Clear();
            label7.Text = " ";
            pictureBox1.Image = null;
           // DataGridViewRow row = this.dataGridView1.Rows[selectedrow];
        }

        private void libstudent_Load(object sender, EventArgs e)
        {
            display();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Byte[] data = new Byte[0];
            data = (Byte[])(dataGridView1.SelectedRows[0].Cells[8].Value);
            MemoryStream mem = new MemoryStream(data);

            label7.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            nAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            dOBDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            eMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pHONE_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            aDDRESSTextBox.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            pictureBox1.Image = Image.FromStream(mem);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "UPDATE studentview SET NAME = '" + nAMETextBox.Text + "', GENDER = '" + textBox1.Text + "', DOB = '" + dOBDateTimePicker.Text + "', ADDRESS = '" + aDDRESSTextBox.Text + "', PHONE_NO = '" + pHONE_NOTextBox.Text + "', EMAIL = '" + eMAILTextBox.Text + "', class = '" + textBox3.Text + "' WHERE roll_no = '" + label7.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            libdash obj = new libdash();
            obj.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label7.Text = " ";
            nAMETextBox.Clear();
            pHONE_NOTextBox.Clear();
            eMAILTextBox.Clear();
            textBox1.Clear();
            aDDRESSTextBox.Clear();
            textBox3.Clear();
            pictureBox1.Image = null; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            try
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT *FROM studentview WHERE roll_no= '" + textBox4.Text + "'or LOWER(name) = '" + textBox5.Text.ToLower() + "'or Lower(class) = '" + textBox6.Text.ToLower() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "delete from studentview where roll_no = '" + label7.Text + "'" ;
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data DELETED Successfully!");
        }
    }
}
