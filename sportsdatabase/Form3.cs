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
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Lenovo\Documents\visual studio 2015\Projects\sportsdatabase\sportsdatabase\sportsdatabase.mdf;Integrated Security=True");

        public Form3()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("addnation", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@cname", SqlDbType.VarChar).Value = textBox1.Text.Trim();
                cmd.Parameters.AddWithValue("@pname", SqlDbType.VarChar).Value = textBox2.Text.Trim();
                cmd.ExecuteNonQuery();

                MessageBox.Show("Nation added");

                con.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            disp_nation();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
       
        public void disp_nation()
        {
            try { 
            con.Open();
            SqlCommand cmd = new SqlCommand("displaynation", con);
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

private void button3_Click_1(object sender, EventArgs e)
        {
            disp_nation();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {

            String i;
            i = dataGridView1.SelectedCells[0].Value.ToString();
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "update nation set pname'" + textBox2.Text + "',cname='" + textBox1.Text + "' where pname=" + i + "";
                cmd.ExecuteNonQuery();
                
                MessageBox.Show("record modified successfully");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
