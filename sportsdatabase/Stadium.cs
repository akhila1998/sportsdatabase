using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace sportsdatabase
{
    public partial class Stadium : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\visual studio 2015\Projects\sportsdatabase\sportsdatabase\sportsdatabase.mdf;Integrated Security=True");

        public Stadium()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("addstadium1", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@stad_no", SqlDbType.Int).Value = textBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@sname", SqlDbType.Int).Value = textBox2.Text.Trim();
            cmd.Parameters.AddWithValue("@cname", SqlDbType.VarChar).Value = textBox3.Text.Trim();
            cmd.Parameters.AddWithValue("@city", SqlDbType.VarChar).Value = textBox4.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Stadium added");
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("displaystadium", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("displaystadium", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

private void Stadium_Load(object sender, EventArgs e)
        {

        }
    }
}
