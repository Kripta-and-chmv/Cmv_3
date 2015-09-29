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
    public partial class Pricelist : Form
    {
        public Pricelist()
        {
            InitializeComponent();
        }
        bool check_search()
        {
            String str = new String("123456789".ToCharArray());
            bool temp = true;
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < to.Text.Length; j++)
                {
                    
                }
            }
            int price_to = Convert.ToInt32(to.Text), price_from = Convert.ToInt32(from.Text);
            if (price_to < price_from || price_to < 0 || price_from < 0)
                return false;
            return false;
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!check_search())
                MessageBox.Show("Цена задана некорректно");
        }

        private void enter_Click(object sender, EventArgs e)
        {
            {
                registration goaway = new registration();
                this.Hide();
                goaway.Show();
            }
        }

        private void управлениеПерсоналомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personnelManagement goaway = new personnelManagement();
            this.Hide();
            goaway.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, System.EventArgs e)
        {
            
            if (checkBox1.Checked)
            {
                dataGridView1.ReadOnly = false;
            }
            else
            {
                dataGridView1.ReadOnly = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
