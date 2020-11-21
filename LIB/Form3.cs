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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        //show student profile form
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            studentprofile obj = new studentprofile();
            obj.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        //show book search form
        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            sbooksearch obj = new sbooksearch();
            obj.ShowDialog(); 
        }
        //show issue record form
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            sissuerecord obj = new sissuerecord();
            obj.ShowDialog();
        }
        //show return record form
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            sreturnrecord obj = new sreturnrecord();
            obj.ShowDialog();
        }
        //going back to login form
        private void button4_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.ShowDialog();
        }
    }
}
