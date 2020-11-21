using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace cpractice
{
    public partial class librarianregitser : Form
    {
        public librarianregitser()
        {
            InitializeComponent();
        }
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            librarianlogin obj = new librarianlogin();
            obj.Show();
            this.Hide();
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
            cmd.CommandText = "INSERT INTO LIBRARIAN(CNIC, NAME, LIB_EMAIL, ADDRESS, LIB_NO, PASSWORD) VALUES('" + textBox1.Text + "' ,'" + textBox4.Text + "','" + textBox5.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox6.Text + "')";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox4.Text = " ";
                textBox5.Text = " ";
                textBox6.Text = " ";
                MessageBox.Show("User has been registered");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void librarianregitser_Load(object sender, EventArgs e)
        {

        }
    }
}
