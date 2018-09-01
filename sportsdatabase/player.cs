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
        SqlConnection con = new SqlConnection(sportsdatabase.Properties.Settings.Default.sportsdatabaseConnectionString);
        public Form2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("addplayer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@pno", SqlDbType.VarChar).Value = textBox1.Text.Trim();
            cmd.Parameters.AddWithValue("@snum", SqlDbType.VarChar).Value = textBox2.Text.Trim();
            cmd.Parameters.AddWithValue("@pname", SqlDbType.VarChar).Value = textBox3.Text.Trim();
            cmd.Parameters.AddWithValue("@ranking", SqlDbType.VarChar).Value = textBox4.Text.Trim();
            cmd.ExecuteNonQuery();
            MessageBox.Show("Player added");
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("displayplayer", con);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
