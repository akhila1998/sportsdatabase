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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\visual studio 2015\Projects\sportsdatabase\sportsdatabase\sportsdatabase.mdf;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_sport();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("addsports", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@snum", textBox1.Text);
                cmd.Parameters.AddWithValue("@sname", textBox2.Text);
                cmd.Parameters.AddWithValue("@origin", textBox3.Text);
                cmd.Parameters.AddWithValue("@no_of_players", textBox4.Text);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Sport added");

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

        private void button4_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update sports set origin='" + textBox3.Text + "',no_of_players='" + textBox4.Text + "' where snum="+i+"";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record modified successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from sports where snum=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
              
                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["snum"].ToString();
                    textBox2.Text = dr["sname"].ToString();
                    textBox3.Text = dr["origin"].ToString();
                    textBox4.Text = dr["no_of_players"].ToString();

                }
                con.Close();
                disp_sport();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void disp_sport()
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("displaysports", con);
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

private void button5_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from sports where snum="+i+"";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i;
            i = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            try
            {
               
                

               
                    textBox1.Text = " ";
                    textBox2.Text = " ";
                    textBox3.Text = " ";
                    textBox4.Text = " ";

               
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            disp_sport();
        }
    }
}

