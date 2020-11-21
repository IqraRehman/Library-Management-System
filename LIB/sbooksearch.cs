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
    public partial class sbooksearch : Form
    {
        public sbooksearch()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
        private void sbooksearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.BOOKS' table. You can move, or remove it, as needed.
            this.bOOKSTableAdapter.Fill(this.dataSet1.BOOKS);
            // TODO: This line of code loads data into the 'dataSet1.PUBLISHER' table. You can move, or remove it, as needed.
            this.pUBLISHERTableAdapter.Fill(this.dataSet1.PUBLISHER);
            display();
        }
        //this function same as student profile display function
        public void display()
        {
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISBN, TITLE, CATEGORY, LANGUAGE,rack_no, PUB_ID, PUBLISH_DATE,status FROM BOOKS ORDER BY ISBN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        //search books based on title,category,author
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISBN, TITLE, STATUS, CATEGORY,AUTHOR,rack_no, LANGUAGE, PUB_ID, PUBLISH_DATE From BOOKS WHERE LOWER(TITLE) = '" + comboBox3.Text.ToLower() + "' OR LOWER(AUTHOR) = '"+ comboBox2.Text.ToLower() + "' OR LOWER(CATEGORY) = '" + comboBox1.Text.ToLower() + "'" ;
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            comboBox3.Text = " ";
            comboBox2.Text = " ";
            comboBox1.Text = " ";
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.bOOKSTableAdapter.FillBy(this.dataSet1.BOOKS);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        //coding for view button
        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 obj = new Form3();
            obj.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
