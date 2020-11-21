using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpractice
{
    public partial class librariandash : Form
    {
        public librariandash()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            booksrecord1 obj = new booksrecord1();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            librarrecord obj = new librarrecord();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            studrecord obj = new studrecord();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            publrecord obj = new publrecord();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            libraryissue1 obj = new libraryissue1();
            obj.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            returnbooks obj = new returnbooks();
            obj.Show();
        }

        private void librariandash_Load(object sender, EventArgs e)
        {

        }
    }
}
