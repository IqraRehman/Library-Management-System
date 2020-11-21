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
    public partial class booksearch : Form
    {
        public booksearch()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");

        private void booksearch_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.BOOKS' table. You can move, or remove it, as needed.
            //this.bOOKSTableAdapter.Fill(this.dataSet2.BOOKS);
          
            display();
        }

        private void button1_Click(object sender, EventArgs e)
        {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT ISBN, TITLE, STATUS, CATEGORY,AUTHOR, LANGUAGE, PUB_ID, PUBLISH_DATE From BOOKS WHERE LOWER(TITLE) = '" + textBox1.Text.ToLower() + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                conn.Close();
        }
        public void display()
        {
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT ISBN, TITLE, STATUS, CATEGORY, LANGUAGE, PUB_ID, PUBLISH_DATE FROM BOOKS ORDER BY ISBN";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            display();
        }
    }
}
