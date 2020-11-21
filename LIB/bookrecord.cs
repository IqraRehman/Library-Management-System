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
    public partial class bookrecord : Form
    {
        public bookrecord()
        {
            InitializeComponent();
        }

        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        public static string status = " ";
        
        private void bookrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.dataSet1.BOOKS);
            comboBox1.Items.Add("English Literature");
            comboBox1.Items.Add("Urdu Literature");
            comboBox1.Items.Add("Computer Sci");
            comboBox1.Items.Add("Psychology");
            comboBox1.Items.Add("Philosophy");
            comboBox1.Items.Add("Maths");
            comboBox1.Items.Add("Geography");
            //Lnaguage box
            comboBox2.Items.Add("English");
            comboBox2.Items.Add("Urdu");
            comboBox2.Items.Add("Persian");
            comboBox2.Items.Add("Arabic");
            comboBox2.Items.Add("Punjabi");
            display();
        }

        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM BOOKS ORDER BY ISBN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            iSBNTextBox.Clear();
            tITLETextBox.Clear();
            aUTHORTextBox.Clear();
            pRICETextBox.Clear();
            comboBox2.Text = " ";
            pUB_IDTextBox.Clear();
            comboBox1.Text = " ";
            textBox2.Clear();

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            iSBNTextBox.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            tITLETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            aUTHORTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pRICETextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            comboBox2.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            pUBLISH_DATEDateTimePicker.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            pUB_IDTextBox.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            display();
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO BOOKS(ISBN, TITLE, Category, author,price, language, publish_Date,pub_id, rack_no,lib_id, status ) VALUES('" + iSBNTextBox.Text + "' ,'" + tITLETextBox.Text + "','" + comboBox1.Text + "','" + aUTHORTextBox.Text + "','" + pRICETextBox.Text + "','" + comboBox2.Text + "','" + pUBLISH_DATEDateTimePicker.Text + "','" + pUB_IDTextBox.Text + "','" + textBox2.Text + "','" + Form1.cnic + "','" + "not issued" + "' )";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                iSBNTextBox.Clear();
                tITLETextBox.Clear();
                comboBox1.Text = " ";
                aUTHORTextBox.Clear();
                pUB_IDTextBox.Clear();
                comboBox2.Text = " ";
                pRICETextBox.Text = " ";
                display();
                MessageBox.Show("Book Record has been Added");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string oracleconnection = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
            OracleConnection conn = new OracleConnection(oracleconnection);
            conn.Open();
            string query = "UPDATE BOOKS SET ISBN = '" + iSBNTextBox.Text + "', TITLE = '" + tITLETextBox.Text + "', CATEGORY = '" + comboBox1.Text + "', AUTHOR = '" + aUTHORTextBox.Text + "', PRICE = '" + pRICETextBox.Text + "', LANGUAGE = '" + comboBox2.Text + "', PUBLISH_DATE = '" + pUBLISH_DATEDateTimePicker.Text + "', PUB_ID = '" + pUB_IDTextBox.Text + "', rack_no = '" + textBox2.Text + "' WHERE ISBN = '" + iSBNTextBox.Text + "'";
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
            string query = "delete from books where ISBN = '" + iSBNTextBox.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data DELETED Successfully!");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM BOOKS WHERE LOWER(TITLE) = '" + textBox1.Text.ToLower() + "' OR LOWER(AUTHOR) = '" + comboBox4.Text.ToLower() + "' OR LOWER(CATEGORY) = '" + comboBox3.Text.ToLower() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            textBox1.Clear();
            comboBox4.Text = " ";
            comboBox3.Text = " ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            libdash obj = new libdash();
            obj.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            iSBNTextBox.Clear();
            tITLETextBox.Clear();
            aUTHORTextBox.Clear();
            pRICETextBox.Clear();
            comboBox2.Text = " ";
            pUB_IDTextBox.Clear();
            comboBox1.Text = " ";
            comboBox3.Text = " ";
            comboBox4.Text = " ";

        }
    }
}
