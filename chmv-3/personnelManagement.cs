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

namespace chmv_3
{
    public partial class personnelManagement : Form
    {
        private static Pricelist goaway;
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gener\Documents\GitHub\Cmv_3\chmv-3\Pricelist.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;

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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "rigths.Rights". При необходимости она может быть перемещена или удалена.
            this.rightsTableAdapter.Fill(this.rigths.Rights);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "users._Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.users._Users);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "pricelistDataSet.Users". При необходимости она может быть перемещена или удалена.
            cmd.Connection = cn;
            LoadDGW();
        }
        private void LoadDGW()
        {
            cn.Open();
            cmd.CommandText = "Select * from Users";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[2].ToString());
                }
            }
            dr.Close();
            cn.Close();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn.Open();
            cmd.CommandText = "select Username from Users where Username like @Name";
            listBox1.Items.Clear();
            cmd.Parameters.AddWithValue("@Name", "%" + textBox1.Text + "%");
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
            cmd.Parameters.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cn.Open();
            string name=string.Empty;
            cmd.CommandText = "update Users set Rights='" + comboBox1.Text + "' where Username=@Name";
            cmd.Parameters.AddWithValue("@Name", listBox1.SelectedItem.ToString());
            cmd.ExecuteNonQuery();

            cn.Close();
            cmd.Parameters.Clear();
            MessageBox.Show("Права пользователя '"+ listBox1.SelectedItem.ToString() + "' изменены на '" + comboBox1.Text + "'");
            dataGridView1.Rows.Clear();
            LoadDGW();

        }
    }
}
