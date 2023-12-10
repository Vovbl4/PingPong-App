using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDesktopApp
{
    public partial class Redact : Form
    {
        public Redact()
        {
            InitializeComponent();

            UserLoginField.Text = "admin";
            UserLoginField.ReadOnly = true;
            UserPasswordField.Text = "Type new password";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Type new password")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
                UserPasswordField.ForeColor = Color.White;
            }
        }

        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Type new password";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Gray;
            }
        }

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LinkToAuth_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Close();
        }

        private void LinkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void AuthButton_Click(object sender, EventArgs e) //RedactButton
        {
            if (UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() != "admin")
            {
                MessageBox.Show("Redact available only for 'admin' user");
                return;
            }

            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Type new password")
            {
                MessageBox.Show("No password was set");
                return;
            }

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("UPDATE users SET password = @password WHERE login = @login", db.GetConnection());
            cmd.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
            cmd.Parameters.AddWithValue("@login", UserLoginField.Text);

            db.OpenConnection();

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Successfuly Redacted");
                else
                    MessageBox.Show("Unsuccessfuly Redacted");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            db.CloseConnection();
        }

        private string Hash(string input)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(input);
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(tmp);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
