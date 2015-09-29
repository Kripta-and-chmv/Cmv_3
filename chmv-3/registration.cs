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
    public partial class registration : Form
    {
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
            enter_button.Location = new Point(51,123);
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
            if(!mode_rigstration)
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

        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enter_button_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
