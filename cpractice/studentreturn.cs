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
    public partial class studentreturn : Form
    {
        public studentreturn()
        {
            InitializeComponent();
        }
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
        private void studentreturn_Load(object sender, EventArgs e)
        {
            display();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
        public void display()
        {
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *From return where student_id = '" + profilestudent.studentno + "'order by isbn";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            backcolor();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void backcolor()
        {

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int fine = Convert.ToInt32(row.Cells[2].Value);
                if (fine == 0)
                {
                    row.DefaultCellStyle.BackColor = Color.Lime;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                    row.DefaultCellStyle.ForeColor = Color.Black;
                }
            }
        }
    }
}
