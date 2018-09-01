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
    public partial class Form2 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\visual studio 2015\Projects\sportsdatabase\sportsdatabase\sportsdatabase.mdf;Integrated Security=True");
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("addplayer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pno", SqlDbType.Int).Value = textBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@sname", SqlDbType.VarChar).Value = textBox2.Text.Trim();
            cmd.Parameters.AddWithValue("@pname", SqlDbType.VarChar).Value = textBox3.Text.Trim();
            cmd.Parameters.AddWithValue("@ranking", SqlDbType.Int).Value = textBox4.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Player added");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_player();
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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
                cmd.CommandText = "delete from player where pno=" + i + "";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record deleted successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
                cmd.CommandText = "update player set sname='" + textBox2.Text + "',pname='" + textBox3.Text + "',ranking='" + textBox4.Text + "' where pno=" + i + "";
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("record updated successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
        public void disp_player()
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("displayplayer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
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
                cmd.CommandText = "select * from player where pno=" + i + "";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                foreach (DataRow dr in dt.Rows)
                {
                    textBox1.Text = dr["pno"].ToString();
                    textBox2.Text = dr["sname"].ToString();
                    textBox3.Text = dr["pname"].ToString();
                    textBox4.Text = dr["ranking"].ToString();

                }
                con.Close();
                disp_player();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            disp_player();
        }
    }
}
