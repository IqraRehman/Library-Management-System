using Oracle.DataAccess.Client;
using Oracle.VsDevTools;
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
    public partial class studentprofile : Form
    {
        public studentprofile()
        {
            InitializeComponent();
        }
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.library);

        }

        private void studentprofile_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'library.STUDENT' table. You can move, or remove it, as needed.
            //this.sTUDENTTableAdapter.Fill(this.library.STUDENT);

        }

        private void sTUDENTDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

         private void button1_Click_1(object sender, EventArgs e)
        {
            OracleConnection con = new OracleConnection(constring);
            con.Open();
            OracleCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select *From student order by student_id asc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            sTUDENTDataGridView.DataSource = dt;
            con.Close();
        }

        private void sTUDENTDataGridView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
