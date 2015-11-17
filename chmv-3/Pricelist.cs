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
using System.Data.SqlClient;


namespace chmv_3
{
    public partial class Pricelist : Form
    {
        static Pricelist kek = new Pricelist();

        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gener\Documents\GitHub\Cmv_3\chmv-3\Pricelist.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

        public void getform(Pricelist kk)
        {
            kek = kk;
        }
        public Pricelist()
        {
            InitializeComponent();

        }
#region Права и приветствие
        public void Rights(string rights)
        {
            if (rights == "User")
            {
                checkBox1.Visible = false;
                menuStrip1.Visible = false;
                this.Width = 690;
            }
            if (rights == "SuperAdministrator")
            {
                checkBox1.Visible = true;
                menuStrip1.Visible = true;
            }
            if (rights == "Administrator")
            {
                checkBox1.Visible = true;
                menuStrip1.Visible = false;
            }
        }

        public void Welcome(string name)
        {
            lblUsername.Text = "Добро пожаловать, " + name + "!";
        }
        #endregion
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
#region Поиск
        private void button1_Click(object sender, EventArgs e)
        {
            if ((from.Text != string.Empty) && (to.Text != string.Empty))
                cmd.CommandText = "select Name from Products where Name like @Name and Category like @Cat and Price >= " + from.Text + " and Price <=" + to.Text;
            if ((from.Text== string.Empty)&&(to.Text== string.Empty))
                cmd.CommandText = "select Name from Products where Name like @Name and Category like @Cat";
            if ((from.Text != string.Empty) && (to.Text == string.Empty))
                cmd.CommandText = "select Name from Products where Name like @Name and Category like @Cat and Price >= " + from.Text;
            if ((from.Text == string.Empty) && (to.Text != string.Empty))
                cmd.CommandText = "select Name from Products where Name like @Name and Category like @Cat and Price <=" + to.Text;
            listBox1.Items.Clear();

            cmd.Parameters.AddWithValue("@Name", "%" + targetName.Text + "%");
            cmd.Parameters.AddWithValue("@Cat", "%" + chooseCategory.Text + "%");
            cn.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    listBox1.Items.Add(dr[0].ToString());
                }
            }
            else
            {
                listBox1.Items.Add("Ничего не найдено!");
            }
            cmd.Parameters.Clear();
            dr.Close();
            cn.Close();
            targetName.Text = string.Empty;
            from.Text = string.Empty;
            to.Text = string.Empty;

        }
        #endregion

        private void enter_Click(object sender, EventArgs e)
        {
            {
                registration goaway = new registration(kek);
                goaway.FormClosed += new FormClosedEventHandler(regClose);
                goaway.Show();

                this.Hide();
            }
        }
        void regClose(object sender, FormClosedEventArgs e)
        {
            // here you can do anything

            // we will close the application
            Application.Exit();
        }
        private void управлениеПерсоналомToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personnelManagement goaway = new personnelManagement(kek);
            goaway.FormClosed += new FormClosedEventHandler(regClose);
            goaway.Show();
            this.Hide();

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
#region Загрузка формы
        private void Pricelist_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "getCategories.Categories". При необходимости она может быть перемещена или удалена.
            this.categoriesTableAdapter.Fill(this.getCategories.Categories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pricelistDataSet.Products". При необходимости она может быть перемещена или удалена.
            this.productsTableAdapter.Fill(this.pricelistDataSet.Products);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "getCategory.Kategories". При необходимости она может быть перемещена или удалена.
            cmd.Connection = cn;
            LoadCategories();
            LoadDGW();

        }
        
        private void LoadDGW()
        {            
            cn.Open();
            cmd.CommandText = "Select * from Products";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
            }
            dr.Close();
            cn.Close();
        }
        #endregion

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
#region Добавление категории
        private void button1_Click_1(object sender, EventArgs e)
        {
            if ((categoryNameText.Text == "Название категории") || (categoryNameText.Text == string.Empty))
            {
                MessageBox.Show("Введите название категории");
                return;
            }
            //проверка на наличие категории
            cn.Open();

            cmd.CommandText = "Select * from Categories";
            dr = cmd.ExecuteReader();
            bool flag = true;
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    if (dr[0].ToString() == categoryNameText.Text)
                    {
                        MessageBox.Show("Такая категория уже существует!");
                        return;
                    }
                }
            }
            dr.Close();
            if (flag)
            {

                cmd.CommandText = "insert into Categories (Category) values(@Cat)";
                cmd.Parameters.AddWithValue("@Cat", categoryNameText.Text);
                cmd.ExecuteNonQuery();
                cmd.Clone();
                MessageBox.Show("Категория успешно добавлена!");
                dr.Close();
                cn.Close();
                cmd.Parameters.Clear();

                LoadCategories();
                categoryNameText.Text = string.Empty;
            }

        }

        private void LoadCategories()
        {
            chooseCategory.Items.Clear();
            productCategoryCombo.Items.Clear();
            cn.Open();
            cmd.CommandText = "Select * from Categories";
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                chooseCategory.Items.Add(dr[0].ToString());
                productCategoryCombo.Items.Add(dr[0].ToString());
            }
            cn.Close();
            dr.Close();

        }
        #endregion
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

#region Добавление товара 

        private void addProductButton_Click(object sender, EventArgs e)
        {

            if ((productCategoryCombo.Text == string.Empty) || (productCategoryCombo.Text == "Категория"))
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

            bool flag = checkCost(productCostText.Text);
            if (!flag)
            {
                MessageBox.Show("Введённая цена некорректна");
                return;
            }


            cn.Open();
            cmd.CommandText = "Select * from Products";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                flag = false;
                while (dr.Read())
                {
                    if ((dr[0].ToString() == productCategoryCombo.Text) && (dr[1].ToString() == productNameText.Text))
                    {
                        MessageBox.Show("Товар '" + productNameText.Text + "' в категории '" + productCategoryCombo.Text + "' уже существует!");
                        flag = true;
                        cn.Close();
                        return;
                    }
                }
                dr.Close();
                if (!flag)
                {
                    cmd.CommandText = "insert into Products (Category, Name, Price) values(@Cat, @Name, @Price)";
                    cmd.Parameters.AddWithValue("@Name", productNameText.Text);
                    cmd.Parameters.AddWithValue("@Cat", productCategoryCombo.Text);
                    cmd.Parameters.AddWithValue("@Price", productCostText.Text);
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    cmd.Parameters.Clear();
                    MessageBox.Show("Товар '" + productNameText.Text + "' успешно добавлен в категорию '" + productCategoryCombo.Text + "'");
                    
                    cn.Close();
                }
            }
            dr.Close();
            dataGridView1.Rows.Add(productCategoryCombo.Text, productNameText.Text, productCostText.Text);
            productNameText.Text = string.Empty;
            productCostText.Text = string.Empty;
            cmd.Parameters.Clear();

        }
        #endregion

        private void chooseCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
