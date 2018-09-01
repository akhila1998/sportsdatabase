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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void sportInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user us = new user();
            us.Show();
        }

        private void sportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
        }

        private void playerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form10 f10 = new Form10();
            f10.Show();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void playerInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();

        }

        private void stadiumInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.Show();
        }

        private void tournamentDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
        }

        private void nationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form11 f11 = new Form11();
            f11.Show();
        }

        private void sportToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form12 f12 = new Form12();
            f12.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
