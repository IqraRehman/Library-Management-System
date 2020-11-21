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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string email = " ";
        /* private void button1_Click(object sender, EventArgs e)
         {
             try
             {
                 string connstring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##PRACTICE; PASSWORD = practice";
                 OracleConnection conn = new OracleConnection(connstring);
                 conn.Open();

                 OracleParameter parm = new OracleParameter();
                 parm.OracleDbType = OracleDbType.Decimal;
                 parm.Value = textBox1.Text;

                 OracleCommand cmd = new OracleCommand();
                 cmd.CommandText = "SELECT USER_NAME FROM STUDENT WHERE PASSWORD = user123";
                 cmd.Connection = conn;
                 cmd.Parameters.Add(parm);
                 cmd.CommandType = CommandType.Text;
                 OracleDataReader dr = cmd.ExecuteReader();
                 dr.Read();
                 label3.Text = dr.GetString(0);

                 conn.Dispose();

             }
             catch (Exception)
             {
                 label3.Text = "Error";
             }
         }*/

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            
            if(!string.IsNullOrEmpty(textBox1.Text)&&(!string.IsNullOrEmpty(textBox2.Text)))
            {
                string connstring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();

                /*  OracleParameter parm = new OracleParameter();
                  parm.OracleDbType = OracleDbType.Decimal;
                  parm.Value = textBox1.Text;

                  OracleCommand cmd = new OracleCommand();

                  cmd.CommandText = "SELECT NAME FROM STUDENT WHERE STUDENT_ID = :2 ";
                  cmd.Connection = conn;
                  cmd.Parameters.Add(parm);
                  cmd.CommandType = CommandType.Text;

                  OracleDataReader dr = cmd.ExecuteReader();
                  dr.Read();

                  label3.Text = dr.GetString(0);*/
                
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT *FROM STUDENT WHERE LOWER(EMAIL) = :USERNAME AND LOWER(PASSWORD) = :PSWRD";
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter(":username", textBox1.Text.ToLower()));
                cmd.Parameters.Add(new OracleParameter(":pswrd", textBox2.Text.ToLower()));
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                //dr.Read();
                if (dr.Read())
                {
                    email = textBox1.Text.ToLower();
                    Form3 fm = new Form3();
                    fm.Show();
                }
                else
                {
                    MessageBox.Show("The Email or Password is incorrect. Try Again!");
                    textBox1.Focus();
                    textBox1.SelectAll();
                }
                conn.Dispose();

            }
            else
            {
                MessageBox.Show("Please Enter Email and Password" ,"Student Login Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.Select();
            }
         
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 fm = new Form2();
            fm.Show();
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                textBox2.UseSystemPasswordChar = false;
            }
            else
            {
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            stuuppswrd obj = new stuuppswrd();
            obj.Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}