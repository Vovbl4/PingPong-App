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
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();

            UserLoginField.Text = "Type login";
            UserPasswordField.Text = "Type password";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Type login")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.White;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Type password")
            {
                UserPasswordField.Text = "";
                UserPasswordField.UseSystemPasswordChar = true;
                UserPasswordField.ForeColor = Color.White;
            }

        }

        public void TextBox_Leave(object sender, EventArgs eventArgs)
        {
            if (((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "")
            {
                UserLoginField.Text = "Type login";
                UserLoginField.ForeColor = Color.Gray;
            }

            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Type password";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Gray;
            }

        }

        private void AuthButton_Click(object sender, EventArgs e)
        {
            if (UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Type password")
            {
                MessageBox.Show("No login was set");
                return;
            }

            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Type password")
            {
                MessageBox.Show("No password was set");
                return;
            }

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("SELECT COUNT(id) FROM users WHERE login = @login AND password = @password", db.GetConnection());
            cmd.Parameters.AddWithValue("login", UserLoginField.Text);
            cmd.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));

            db.OpenConnection();

            int countUser = Convert.ToInt32(cmd.ExecuteScalar());
            if (countUser > 0)
            {
                this.Hide();
                PingPong pingPong = new PingPong();
                pingPong.ShowDialog();
                this.Close();
            }

            else
                MessageBox.Show("User not found");

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

        private void AuthForm_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }

        private void LinkToReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Close();
        }

        private void LinkToRedact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Redact redact = new Redact();
            redact.ShowDialog();
            this.Close();
        }
    }
}
