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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            UserLoginField.Text = "Type login";
            UserEmailField.Text = "Type email";
            UserPasswordField.Text = "Type password";
            this.Text = "Register Page";
        }

        public void TextBox_Enter(object sender, EventArgs eventArgs)
        {
            if(((TextBox)sender).Name == "UserLoginField" && UserLoginField.Text.Trim() == "Type login")
            {
                UserLoginField.Text = "";
                UserLoginField.ForeColor = Color.White;
            }
            if(((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "Type email")
            {
                UserEmailField.Text = "";
                UserEmailField.ForeColor = Color.White;
            }
            if(((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "Type password")
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
            if (((TextBox)sender).Name == "UserEmailField" && UserEmailField.Text.Trim() == "")
            {
                UserEmailField.Text = "Type email";
                UserEmailField.ForeColor = Color.Gray;
            }
            if (((TextBox)sender).Name == "UserPasswordField" && UserPasswordField.Text.Trim() == "")
            {
                UserPasswordField.Text = "Type password";
                UserPasswordField.UseSystemPasswordChar = false;
                UserPasswordField.ForeColor = Color.Gray;
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(UserLoginField.Text.Trim() == "" || UserLoginField.Text.Trim() == "Type password")
            {
                MessageBox.Show("No login was set");
                return;
            }

            if (UserEmailField.Text.Trim() == "" || UserEmailField.Text.Trim() == "Type email")
            {
                MessageBox.Show("No email was set");
                return;
            }

            if (UserPasswordField.Text.Trim() == "" || UserPasswordField.Text.Trim() == "Type password")
            {
                MessageBox.Show("No password was set");
                return;
            }

            DB db = new DB();
            MySqlCommand cmd = new MySqlCommand("INSERT INTO users (login, password, email) VALUES(@login, @password, @email)", db.GetConnection());
            cmd.Parameters.AddWithValue("login", UserLoginField.Text);
            cmd.Parameters.AddWithValue("password", Hash(UserPasswordField.Text));
            cmd.Parameters.AddWithValue("email", UserEmailField.Text);

            db.OpenConnection();

            try
            {
                if (cmd.ExecuteNonQuery() == 1)
                    MessageBox.Show("Successfuly Registered");
                else
                    MessageBox.Show("Unsuccessfuly Registered");
            }catch (MySqlException ex)
            {
                if(ex.Message.Contains("Duplicate entry")) 
                    MessageBox.Show("User with this login already exists !");
                else 
                    MessageBox.Show(ex.Message);
            }

            db.CloseConnection();
        }

        private string Hash(string input)
        {
            byte[] tmp = Encoding.UTF8.GetBytes(input);
            using(SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(tmp);
                return Convert.ToBase64String(hash);
            }
        }

        private void RegisterForm_Load(object sender, EventArgs e)
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

        private void LinkToRedact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Redact redact = new Redact();
            redact.ShowDialog();
            this.Close();
        }
    }
}
