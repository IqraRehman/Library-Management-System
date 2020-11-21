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
namespace cpractice
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string oradb = "DATA SOURCE=localhost:1521/xe;PERSIST SECURITY INFO=True;USER ID=C##PRACTICE";
           
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            booksearch obj = new booksearch();
            obj.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            studentprofile obj = new studentprofile();
            obj.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            profilestudent obj = new profilestudent();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            issuebooks obj = new issuebooks();
            obj.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            studentreturn obj = new studentreturn();
            obj.Show();
        }
    }
}
