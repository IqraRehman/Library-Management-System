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
    public partial class booksrecord1 : Form
    {
        public booksrecord1()
        {
            InitializeComponent();
        }

        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        public static string  status = " ";
        private void booksrecord1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);
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

        private void bOOKSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bOOKSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

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
            iSBNTextBox.Text = " ";
            tITLETextBox.Text = " ";
            aUTHORTextBox.Text = " ";
            pRICETextBox.Text = " ";
            comboBox2.Text = " ";
            pUB_IDTextBox.Text = " ";
            comboBox1.Text = " ";

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
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO BOOKS VALUES('" + iSBNTextBox.Text + "' ,'" + tITLETextBox.Text + "','" + comboBox1.Text + "','" + aUTHORTextBox.Text + "','" + pRICETextBox.Text + "','" + comboBox2.Text + "','" + pUBLISH_DATEDateTimePicker.Text + "','" + pUB_IDTextBox.Text + "','" + librarianlogin.cnic + "','" + "not issued" + "' )";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                iSBNTextBox.Text = " ";
                tITLETextBox.Text = " ";
                comboBox1.Text = " ";
                aUTHORTextBox.Text = " ";
                pUB_IDTextBox.Text = " ";
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
            string query = "UPDATE BOOKS SET ISBN = '" + iSBNTextBox.Text + "', TITLE = '" + tITLETextBox.Text + "', CATEGORY = '" + comboBox1.Text + "', AUTHOR = '" + aUTHORTextBox.Text + "', PRICE = '" + pRICETextBox.Text + "', LANGUAGE = '" + comboBox2.Text + "', PUBLISH_DATE = '" + pUBLISH_DATEDateTimePicker.Text + "', PUB_ID = '" + pUB_IDTextBox.Text + "'WHERE ISBN = '" + iSBNTextBox.Text + "'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM BOOKS WHERE LOWER(TITLE) = '" + textBox1.Text.ToLower() + "'";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close(); 
            iSBNTextBox.Text = " ";
            tITLETextBox.Text = " ";
            aUTHORTextBox.Text = " ";
            pRICETextBox.Text = " ";
            comboBox2.Text = " ";
            pUB_IDTextBox.Text = " ";
            comboBox1.Text = " ";
          
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            display();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iSBNTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void tITLETextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
