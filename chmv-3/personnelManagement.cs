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
        private static Pricelist goaway;

        public personnelManagement(Pricelist kk)
        {
            InitializeComponent();
            goaway = kk;
        }

      

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void personnelManagement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "users._Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.users._Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pricelistDataSet.Users". При необходимости она может быть перемещена или удалена.


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Прайслист_Click(object sender, EventArgs e)
        {
          //  Pricelist goaway = new Pricelist();
           // goaway.Rights("SuperAdministrator");
         
            goaway.Show();
            this.Hide();
        }
    }
}
