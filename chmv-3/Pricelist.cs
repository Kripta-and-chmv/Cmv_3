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
            fillComboBoxes(productCategoryCombo);
            fillComboBoxes(chooseCategory);
            fillTable();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ыеквароилдьжю
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
                this.Size = new System.Drawing.Size(900, 475);
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
            if ((categoryNameText.Text == "Название категории") || (categoryNameText.Text == string.Empty))
            {
                MessageBox.Show("Введите название категории");
                return;
            }

           
            //проверка на наличие категории
            bool chek = checkCategories(categoryNameText.Text);
            if (chek)
            {
                MessageBox.Show("Данная категория уже существует");
                return;
            }

            productCategoryCombo.Items.Add(categoryNameText.Text);

            //добавление категории в бд
            StreamWriter write_text;
            FileInfo file = new FileInfo("category.txt");
            write_text = file.AppendText();
            write_text.WriteLine(categoryNameText.Text);
            write_text.Close();
            categoryNameText.Text = "Название категории";

           

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void addProductButton_Click(object sender, EventArgs e)
        {
            
            if ((productCategoryCombo.Text==string.Empty)||(productCategoryCombo.Text=="Категория"))
            {
                MessageBox.Show("Введите категорию");
                return;
            }
            if ((productNameText.Text == string.Empty) || (productNameText.Text == "Название товара"))
            {
                MessageBox.Show("Введите название товара");
                return;
            }
            if ((productCostText.Text == string.Empty) || (productCostText.Text == "Цена товара"))
            {
                MessageBox.Show("Введите цену товара");
                return;
            }
            //проверка на существование категории
            bool chek = checkCategories(productCategoryCombo.Text);
            if (!chek)
            {
                MessageBox.Show("Данной категории не существует");
                return;
            }
            //проверка на наличие товара в таблице
            chek = checkItems();
            if (chek)
            {
                MessageBox.Show("Товар с таким названием в категории '"+productCategoryCombo.Text+"' уже существует");
                return;
            }
            //проверка корректности цены
            chek = checkCost(productCostText.Text);
            if (!chek)
            {
                MessageBox.Show("Цена задана некорректно");
                return;
            }
            //добавление товара
            string[] row=new string[3];
            row[0] = productCategoryCombo.Text; row[1] = productNameText.Text; row[2] =productCostText.Text;
            productTable.Rows.Add(row);
            //добавление товара в бд
            StreamWriter write_text;
            FileInfo file = new FileInfo("items.txt");
            write_text = file.AppendText();
            write_text.WriteLine(productCategoryCombo.Text + " " + productNameText.Text + " " + productCostText.Text);
            write_text.Close();
            productNameText.Text = "Название товара";
            productCostText.Text = "Цена товара";
            productCategoryCombo.Text = "Категория";

        }

        private void chooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void fillComboBoxes(ComboBox where)
        {
            string[] lineOfContents = File.ReadAllLines("category.txt");
            where.Items.AddRange(lineOfContents);
        }
        private void fillTable()
        {
            string[] lineOfItems = File.ReadAllLines("items.txt");
            foreach (string line in lineOfItems)
            {
                string[] parametres = line.Split(' ');
                productTable.Rows.Add(parametres);
            }
        }

        private bool checkCategories(string where)
        {
            string[] lineOfContents = File.ReadAllLines("category.txt");
            foreach (string line in lineOfContents)
            {
                if (line == where)
                    return true;
            }
            return false;
        }

        private bool checkItems()
        {
            string[] allLines = File.ReadAllLines("items.txt");
            foreach (string line in allLines)
            {
                string [] row = line.Split(' ');
                if ((row[0] == productCategoryCombo.Text) || (row[1] == productNameText.Text))
                    return true;
            }
            return false;
        }

        private bool checkCost(string where)
        {
            string[] symbols = where.Split();
            foreach (string symbol in symbols)
            {
                if ((symbol[0] < '0') || (symbol[0] > '9'))
                    return false;
            }
            return true;
        }
    }
}
