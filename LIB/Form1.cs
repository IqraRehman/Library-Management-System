using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//used libraries to connect c# with oracle database
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace LIB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string email = " ";
        public static string cnic = " ";
        //if check state is checked to change its unchecked.
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
        //button3 used for student login 
        private void button3_Click(object sender, EventArgs e)
        {
           //if textbox1(email) and textbox2(password) not empty run if statements.
                if (!string.IsNullOrEmpty(textBox1.Text) && (!string.IsNullOrEmpty(textBox2.Text)))
                {
                //connstring used to connect oracle database to c# give credentials. 
                    string connstring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
                    OracleConnection conn = new OracleConnection(connstring);
                    conn.Open();

                    OracleCommand cmd = new OracleCommand();
                //cmd.commandtext use sql query
                    cmd.CommandText = "SELECT *FROM STUDENT WHERE LOWER(EMAIL) = :USERNAME AND LOWER(PASSWORD) = :PSWRD";
                    cmd.Connection = conn;
                    cmd.Parameters.Add(new OracleParameter(":username", textBox1.Text.ToLower()));
                    cmd.Parameters.Add(new OracleParameter(":pswrd", textBox2.Text.ToLower()));
                    cmd.CommandType = CommandType.Text;
                    OracleDataReader dr = cmd.ExecuteReader();
                    
                    //if data read assign textbox1 value to email. email variable used locally. also login another form(student dashboard) and 
                    //else used if pasword or email not found or not registered user
                    if (dr.Read())
                    {
                        email = textBox1.Text.ToLower();
                        Form3 fm = new Form3();
                        fm.ShowDialog();
                        this.Close();
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
                    MessageBox.Show("Please Enter Email and Password", "Student Login Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    textBox1.Select();
                }
            }
        //this one used to show registration form 
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 obj = new Form2();
            obj.ShowDialog();
        }

       
        //this checkbox work for librarian side chechkbox
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox2.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
            }
        }
        //this button used to login librarian dashboard
        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox4.Text) && (!string.IsNullOrEmpty(textBox3.Text)))
            {
                string connstring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
                OracleConnection conn = new OracleConnection(connstring);
                conn.Open();
                OracleCommand cmd = new OracleCommand();
                cmd.CommandText = "SELECT *FROM LIBRARIAN WHERE LOWER(CNIC) = :USERNAME AND LOWER(PASSWORD) = :PSWRD";
                cmd.Connection = conn;
                cmd.Parameters.Add(new OracleParameter(":username", textBox4.Text.ToLower()));
                cmd.Parameters.Add(new OracleParameter(":pswrd", textBox3.Text.ToLower()));
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    cnic = textBox4.Text;
                    libdash fm = new libdash();
                    fm.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("The CNIC or Password is incorrect. Try Again!");
                    textBox4.Focus();
                    textBox4.SelectAll();
                }
                conn.Dispose();

            }
            else
            {
                MessageBox.Show("Please Enter CNIC and Password", "Student Login Form", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox4.Select();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
