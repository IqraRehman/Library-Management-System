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
    public partial class librarianlogin : Form
    {
        public librarianlogin()
        {
            InitializeComponent();
        }
        public static string cnic = " ";
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && (!string.IsNullOrEmpty(textBox2.Text)))
            {
                string connstring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT *FROM LIBRARIAN WHERE LOWER(CNIC) = :USERNAME AND LOWER(PASSWORD) = :PSWRD";
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter(":username", textBox1.Text.ToLower()));
                cmd.Parameters.Add(new OracleParameter(":pswrd", textBox2.Text.ToLower()));
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cnic = textBox1.Text;
                    librariandash fm = new librariandash();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("The CNIC or Password is incorrect. Try Again!");
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                conn.Dispose();

            }
            else
            {
                MessageBox.Show("Please Enter CNIC and Password", "Student Login Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Select();
            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void librarianlogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            uplibpswrd obj = new uplibpswrd();
            obj.Show();
        }
    }
}
