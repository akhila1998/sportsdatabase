using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sportsdatabase
{
    public partial class mainform : Form
    {
        public mainform()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form7 f7 = new Form7();
            f7.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form4 f4 = new Form4();
            f4.Show();
        }

        private void mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
