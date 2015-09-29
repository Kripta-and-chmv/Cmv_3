using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chmv_3
{
    public partial class personnelManagement : Form
    {
        private Pricelist pricelist;

        public personnelManagement()
        {
            InitializeComponent();
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void personnelManagement_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Прайслист_Click(object sender, EventArgs e)
        {
            Pricelist goaway = new Pricelist();
            this.Hide();
            goaway.Show();
        }
    }
}
