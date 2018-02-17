using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFrom
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dohodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Material dh = new Material();
            dh.Show();
            
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
