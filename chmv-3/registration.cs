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
    public partial class registration : Form
    {
        SqlConnection cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gener\Documents\GitHub\Cmv_3\chmv-3\Pricelist.mdf;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;


        public registration()
        {
            InitializeComponent();
        }
        void From_registrtion_to_enter()
        {
            repit_password_label.Visible = false;
            repet_passwor_textbox.Visible = false;
            email_textbox.Visible = false;
            email_label.Visible = false;
            enter_button.Location = new Point(51, 123);
            IsRegistrate.Text = "Еще не зарегистированы?";
            Registrat.Text = "Регистрация";
            enter_button.Text = "Вход";


        }
        void From_enter_to_registrat()
        {
            repit_password_label.Visible = true;
            repet_passwor_textbox.Visible = true;
            email_textbox.Visible = true;
            email_label.Visible = true;
            enter_button.Location = new Point(46, 236);

            IsRegistrate.Text = "Уже зарегистрированы?";
            Registrat.Text = "Войти";
            enter_button.Text = "Регистрация";

        }
        bool mode_rigstration = false; // false - режим входа,true - режим регистрации
        private void Registrat_Click(object sender, EventArgs e)
        {
            if (!mode_rigstration)
            {
                mode_rigstration = true;
                From_registrtion_to_enter();
            }
            else
            {
                mode_rigstration = false;
                From_enter_to_registrat();
            }

        }

        private void registration_Load(object sender, EventArgs e)
        {
            cmd.Connection = cn;
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private bool checkTextBox(string type)
        {
            if (Login_textbox.Text == string.Empty)
            {
                MessageBox.Show("Введите имя пользователя!");
                return false;
            }
            if (password_textbox.Text == string.Empty)
            {
                MessageBox.Show("Введите пароль!");
                return false;
            }
            if (type == "Регистрация")
            {
                if (email_textbox.Text == string.Empty)
                {
                    MessageBox.Show("Введите почту!");
                    return false;
                }
                if (password_textbox.Text != repet_passwor_textbox.Text)
                {
                    MessageBox.Show("Пароли не совпадают!");
                    return false;
                }
            }
            return true;
        }
        private int checkNameMail()
        {
            int flag = 0;

            cn.Open();

            cmd.CommandText = "Select * from Users";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    if (dr[0].ToString() == Login_textbox.Text)
                    {
                        flag += 1;
                        break;
                    }
                }
            }
            dr.Close();

            cmd.CommandText = "Select * from Emails";
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {

                while (dr.Read())
                {
                    if (dr[0].ToString() == email_textbox.Text)
                    {
                        flag += 2;
                        break;
                    }
                }
            }
            dr.Close();
            cn.Close();

            return flag;
        }
        private void enter_button_Click(object sender, EventArgs e)
        {
            string rights = "User";
            bool flagTxtBox = checkTextBox(enter_button.Text);
            if (!flagTxtBox)
                return;
            if (enter_button.Text == "Регистрация")
            {

                int flag = checkNameMail();
                cn.Open();


                if (flag == 0)
                {
                    cmd.CommandText = "insert into Users (Username, Password, Emails, Rights) values('" + Login_textbox.Text + "','" + password_textbox.Text + "','" + email_textbox.Text + "','"+rights + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    cmd.CommandText = "insert into Emails (Emails) values('" + email_textbox.Text + "')";
                    cmd.ExecuteNonQuery();
                    cmd.Clone();
                    MessageBox.Show("Регистрация успешно завершена!");

                   
                    cn.Close();

                    Pricelist goaway = new Pricelist();
                    goaway.Welcome(Login_textbox.Text);
                    goaway.Rights("User");
                    goaway.Show();

                    this.Close();
                }

                if (flag == 3)
                {
                    MessageBox.Show("Введённая почта и имя пользователя уже существуют");
                }
                if (flag == 1)
                {
                    MessageBox.Show("Введённое имя пользователя уже существует");
                }
                if (flag == 2)
                {
                    MessageBox.Show("Введённая почта уже существует");
                }



            }
            else
            {
                
                int flag = checkNameMail();
                if (flag == 1)
                {
                    cn.Open();

                    cmd.CommandText = "Select * from Users";
                    dr = cmd.ExecuteReader();
                    if (dr.HasRows)
                    {

                        while (dr.Read())
                        {
                            if (dr[0].ToString() == Login_textbox.Text)
                            {
                                if (dr[1].ToString()!=password_textbox.Text)
                                {
                                    MessageBox.Show("Неверный пароль!");
                                    dr.Close();
                                    cn.Close();
                                    return;
                                }
                                rights = dr[2].ToString();
                                break;
                            }
                        }
                    }
                    dr.Close();
                    cn.Close();
                    Pricelist goaway = new Pricelist();
                    goaway.Welcome(Login_textbox.Text);
                    goaway.Rights(rights);
                    goaway.Show();
                    this.Close();
                }
                if(flag==0)
                {
                    MessageBox.Show("Данного пользователя не существует!");
                    return;
                }
            }
            cn.Close();
            return;
        }

    }


}


