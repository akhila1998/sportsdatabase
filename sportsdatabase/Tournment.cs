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
    public partial class Tournment : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\visual studio 2015\Projects\sportsdatabase\sportsdatabase\sportsdatabase.mdf;Integrated Security=True");

        public Tournment()
        {
            InitializeComponent();
        }

        private void Tournment_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("addtournament", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = textBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@sname", SqlDbType.VarChar).Value = textBox2.Text.Trim();
            cmd.Parameters.AddWithValue("@date1", SqlDbType.VarChar).Value = dateTimePicker1.Text.Trim();
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Tournment added");
            con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
}

private void button1_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("displaytournament", con);
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
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("displaytournament", con);
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
    }
}
