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
    public partial class user : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\visual studio 2015\Projects\sportsdatabase\sportsdatabase\sportsdatabase.mdf;Integrated Security=True");

        public user()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("cricketinfo", con);
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

private void button2_Click(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("kabbadiinfo", con);
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

private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            
          
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void user_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try { 
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select s.sname as SPORT,s.origin as ORIGIN_OF_SPORT,s.no_of_players as MAX_PLAYERS  from sports s ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
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
