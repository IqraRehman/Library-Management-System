using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Types;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace cpractice
{
    public partial class publrecord : Form
    {
        public publrecord()
        {
            InitializeComponent();
        }

        private void pUBLISHERBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pUBLISHERBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet2);

        }
        string constring = "DATA SOURCE = localhost:1521 / xe; USER ID = C##LIBRARY; PASSWORD =mypswrd";
        
        private void publrecord_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.PUBLISHER' table. You can move, or remove it, as needed.
            this.pUBLISHERTableAdapter.Fill(this.dataSet2.PUBLISHER);
            display();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            label3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            pUBLISHER_NAMETextBox.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            pUBLISHER_ADDTextBox.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            pUBLISHER_NOTextBox.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            pUBLISHER_EMAILTextBox.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }
        private void display()
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT *FROM PUBLISHER ORDER BY PUBLISHER_ID";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
            pUBLISHER_NAMETextBox.Text = " ";
            pUBLISHER_EMAILTextBox.Text = " ";
            pUBLISHER_ADDTextBox.Text = " ";
            pUBLISHER_NOTextBox.Text = " ";
            label3.Text = " ";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO PUBLISHER(PUBLISHER_NAME, PUBLISHER_ADD,PUBLISHER_NO,PUBLISHER_EMAIL) VALUES('" + pUBLISHER_NAMETextBox.Text + "','" + pUBLISHER_ADDTextBox.Text + "','" + pUBLISHER_NOTextBox.Text + "','" + pUBLISHER_EMAILTextBox.Text + "' )";
            int rows = cmd.ExecuteNonQuery();
            if (rows == 0)
            {
                MessageBox.Show("Error");
            }
            else
            {
                pUBLISHER_EMAILTextBox.Text = " ";
                pUBLISHER_NAMETextBox.Text = " ";
                pUBLISHER_NOTextBox.Text = " ";
                pUBLISHER_ADDTextBox.Text = " ";
                label3.Text = " ";
                display();
                MessageBox.Show("Publisher Record has been Added");
            }
        }
      /*  long getoracleseq()
        {
            long seqval;
            OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/xe;PASSWORD=mypswrd;USER ID=C##LIBRARY");
            conn.Open();
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT PUB_SEQ.NEXTVAL FROM DUAL";
            cmd.CommandType = CommandType.Text;
            seqval = Convert.ToInt64(cmd.ExecuteScalar().ToString());
            return seqval;

        }*/

        private void button2_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string query = "UPDATE PUBLISHER SET publisher_name = '" + pUBLISHER_NAMETextBox.Text + "', publisher_add = '" + pUBLISHER_ADDTextBox.Text + "', publisher_no = '" + pUBLISHER_NOTextBox.Text + "', publisher_email = '" + pUBLISHER_EMAILTextBox.Text + "' WHERE publisher_id = '" + label3.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data Updated Successfully!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OracleConnection conn = new OracleConnection(constring);
            conn.Open();
            string query = "delete from publisher where PUBLISHER_ID = '" + label3.Text + "'";
            OracleDataAdapter SDA = new OracleDataAdapter(query, conn);
            SDA.SelectCommand.ExecuteNonQuery();
            conn.Close();
            display();
            MessageBox.Show("Data DELETED Successfully!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
             OracleConnection conn = new OracleConnection(constring);
             conn.Open();
             OracleCommand cmd = conn.CreateCommand();
             cmd.CommandType = CommandType.Text;
             cmd.CommandText = "SELECT *FROM PUBLISHER WHERE PUBLISHER_ID = '" + textBox1.Text + "'";
             cmd.ExecuteNonQuery();
             DataTable dt = new DataTable();
             OracleDataAdapter da = new OracleDataAdapter(cmd);
             da.Fill(dt);
             dataGridView1.DataSource = dt;
             conn.Close();
             pUBLISHER_NAMETextBox.Text = " ";
             pUBLISHER_EMAILTextBox.Text = " ";
             pUBLISHER_ADDTextBox.Text = " ";
             pUBLISHER_NOTextBox.Text = " ";

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pUBLISHER_NOTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            display();
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
