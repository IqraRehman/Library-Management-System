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
using System.IO;

namespace LIB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //connection string
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //signup button coding
        private void button2_Click(object sender, EventArgs e)
        {
            //convert image into binary file
            byte[] imagebt = null;
            FileStream fstream = new FileStream(textBox1.Text, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imagebt = br.ReadBytes((int)fstream.Length);

            OracleConnection conn = new OracleConnection(constring);
            conn.Open();

            OracleCommand cmd = new OracleCommand();
            int get = checkmail();
            //if checkemail return another value other than 1 run if statement
            if (get != 1)
            {
                //using insert query
                string sqlquery = "INSERT INTO STUDENT(name,gender,dob,address,phone_no,email,password,roll_no,class,photo_id) VALUES('" + nAMETextBox.Text + "' ,'" + comboBox2.Text + "','" + dOBDateTimePicker.Text + "','" + aDDRESSTextBox.Text + "', '" + pHONE_NOTextBox.Text + "','" + eMAILTextBox.Text + "','" + pASSWORDTextBox.Text + "','" + RollNo.Text + "','" + classtextbox.Text + "',:image)";
                cmd = new OracleCommand(sqlquery, conn);
                cmd.Parameters.Add(new OracleParameter(":image", imagebt));
                //cmd.executenotquery() return value 0 if it doesnot change any row.
                int rows = cmd.ExecuteNonQuery();

                if (rows == 0)
                {
                    MessageBox.Show("Error");
                }
                else
                {

                    nAMETextBox.Text = " ";
                    comboBox2.Text = " ";
                    aDDRESSTextBox.Text = " ";
                    pHONE_NOTextBox.Text = " ";
                    pASSWORDTextBox.Text = " ";
                    eMAILTextBox.Text = " ";
                    RollNo.Text = " ";
                    classtextbox.Text = " ";
                    pictureBox2.Image = null;
                    MessageBox.Show("User has been registered");
                }
            }
            else
            {
                MessageBox.Show("This email already has an account!");
            }
        }
        //this button used to get image in pictuebox
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)*.jpg||PNG Files(*.png)*.png||All Files(*.*)|*.*";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                string picLoc = dlg.FileName.ToString();
                textBox1.Text = picLoc;
                pictureBox2.ImageLocation = picLoc;
            }
        }
        //this function used to check email if user already registered using this email it gives errror.
        int checkmail()
        {
            int check = -1;
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.CommandText = "SELECT *FROM STUDENT WHERE LOWER(EMAIL) = :EMAIL";
            cmd.Connection = conn;
            cmd.Parameters.Add(new OracleParameter(":email", eMAILTextBox.Text.ToLower()));
            cmd.CommandType = CommandType.Text;
            OracleDataReader dr = cmd.ExecuteReader();
            //read data
            if (dr.Read())
            {
                //read email 
                string useremail = dr["email"].ToString();
                //check email user enter or already registered email matches
                if (useremail == eMAILTextBox.Text)
                {
                    check = 1;
                 
                    
                }
                else
                {
                    check = 0;
                }
            }
            return check;
        }
        //going back to login form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
        //close the form
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
