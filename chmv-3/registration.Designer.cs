﻿namespace chmv_3
{
    partial class registration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(registration));
            this.Login_textbox = new System.Windows.Forms.TextBox();
            this.password_textbox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.enter_button = new System.Windows.Forms.Button();
            this.IsRegistrate = new System.Windows.Forms.Label();
            this.Registrat = new System.Windows.Forms.Button();
            this.repit_password_label = new System.Windows.Forms.Label();
            this.repet_passwor_textbox = new System.Windows.Forms.TextBox();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.email_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Login_textbox
            // 
            this.Login_textbox.Location = new System.Drawing.Point(12, 42);
            this.Login_textbox.Name = "Login_textbox";
            this.Login_textbox.Size = new System.Drawing.Size(151, 20);
            this.Login_textbox.TabIndex = 0;
            // 
            // password_textbox
            // 
            this.password_textbox.Location = new System.Drawing.Point(12, 91);
            this.password_textbox.Name = "password_textbox";
            this.password_textbox.Size = new System.Drawing.Size(151, 20);
            this.password_textbox.TabIndex = 1;
            this.password_textbox.TextChanged += new System.EventHandler(this.password_textbox_TextChanged);
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Login_label.Location = new System.Drawing.Point(12, 19);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(59, 20);
            this.Login_label.TabIndex = 4;
            this.Login_label.Text = "Логин:";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_label.Location = new System.Drawing.Point(12, 68);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(67, 20);
            this.password_label.TabIndex = 5;
            this.password_label.Text = "Пароль";
            // 
            // enter_button
            // 
            this.enter_button.Location = new System.Drawing.Point(40, 236);
            this.enter_button.Name = "enter_button";
            this.enter_button.Size = new System.Drawing.Size(84, 23);
            this.enter_button.TabIndex = 6;
            this.enter_button.Text = "Регистрация";
            this.enter_button.UseVisualStyleBackColor = true;
            this.enter_button.Click += new System.EventHandler(this.enter_button_Click);
            // 
            // IsRegistrate
            // 
            this.IsRegistrate.AutoSize = true;
            this.IsRegistrate.Location = new System.Drawing.Point(236, 41);
            this.IsRegistrate.Name = "IsRegistrate";
            this.IsRegistrate.Size = new System.Drawing.Size(143, 13);
            this.IsRegistrate.TabIndex = 7;
            this.IsRegistrate.Text = "Еще не зарегистированы?";
            // 
            // Registrat
            // 
            this.Registrat.Location = new System.Drawing.Point(239, 68);
            this.Registrat.Name = "Registrat";
            this.Registrat.Size = new System.Drawing.Size(86, 23);
            this.Registrat.TabIndex = 8;
            this.Registrat.Text = "Регистрация";
            this.Registrat.UseVisualStyleBackColor = true;
            this.Registrat.Click += new System.EventHandler(this.Registrat_Click);
            // 
            // repit_password_label
            // 
            this.repit_password_label.AutoSize = true;
            this.repit_password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repit_password_label.Location = new System.Drawing.Point(12, 123);
            this.repit_password_label.Name = "repit_password_label";
            this.repit_password_label.Size = new System.Drawing.Size(152, 20);
            this.repit_password_label.TabIndex = 9;
            this.repit_password_label.Text = "Повторите пароль";
            // 
            // repet_passwor_textbox
            // 
            this.repet_passwor_textbox.Location = new System.Drawing.Point(13, 146);
            this.repet_passwor_textbox.Name = "repet_passwor_textbox";
            this.repet_passwor_textbox.Size = new System.Drawing.Size(151, 20);
            this.repet_passwor_textbox.TabIndex = 10;
            // 
            // email_textbox
            // 
            this.email_textbox.Location = new System.Drawing.Point(12, 201);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(147, 20);
            this.email_textbox.TabIndex = 11;
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.email_label.Location = new System.Drawing.Point(8, 178);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(160, 20);
            this.email_label.TabIndex = 12;
            this.email_label.Text = "Электронная почта";
            // 
            // registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(391, 283);
            this.Controls.Add(this.email_label);
            this.Controls.Add(this.email_textbox);
            this.Controls.Add(this.repet_passwor_textbox);
            this.Controls.Add(this.repit_password_label);
            this.Controls.Add(this.Registrat);
            this.Controls.Add(this.IsRegistrate);
            this.Controls.Add(this.enter_button);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.password_textbox);
            this.Controls.Add(this.Login_textbox);
            this.Name = "registration";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "registration";
            this.Load += new System.EventHandler(this.registration_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_textbox;
        private System.Windows.Forms.TextBox password_textbox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button enter_button;
        private System.Windows.Forms.Label IsRegistrate;
        private System.Windows.Forms.Button Registrat;
        private System.Windows.Forms.Label repit_password_label;
        private System.Windows.Forms.TextBox repet_passwor_textbox;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Label email_label;
    }
}