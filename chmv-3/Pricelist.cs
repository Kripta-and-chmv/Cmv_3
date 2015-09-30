using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
                this.Size =  new System.Drawing.Size(900, 475);
            }
            else
            {
                this.Size = new System.Drawing.Size(690, 475);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pricelist_Load(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            StreamWriter write_text;  
            FileInfo file = new FileInfo("category.txt");
            write_text = file.AppendText();
            write_text.WriteLine(textBox1.Text); 
            write_text.Close(); 
            textBox1.Text = "";

            string[] lineOfContents = File.ReadAllLines("category.txt");
            comboBox1.Items.AddRange(lineOfContents);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
