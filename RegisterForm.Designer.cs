namespace MyDesktopApp
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.UserEmailField = new System.Windows.Forms.TextBox();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.LinkToAuth = new System.Windows.Forms.LinkLabel();
            this.LinkToRedact = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(80, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register";
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginField.Location = new System.Drawing.Point(64, 78);
            this.UserLoginField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(150, 24);
            this.UserLoginField.TabIndex = 1;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserEmailField
            // 
            this.UserEmailField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.UserEmailField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserEmailField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserEmailField.ForeColor = System.Drawing.Color.Gray;
            this.UserEmailField.Location = new System.Drawing.Point(64, 120);
            this.UserEmailField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserEmailField.Name = "UserEmailField";
            this.UserEmailField.Size = new System.Drawing.Size(150, 24);
            this.UserEmailField.TabIndex = 3;
            this.UserEmailField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.UserEmailField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserEmailField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(64, 164);
            this.UserPasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(150, 24);
            this.UserPasswordField.TabIndex = 5;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // RegisterButton
            // 
            this.RegisterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(201)))), ((int)(((byte)(123)))));
            this.RegisterButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegisterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterButton.ForeColor = System.Drawing.Color.Black;
            this.RegisterButton.Location = new System.Drawing.Point(98, 205);
            this.RegisterButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(85, 34);
            this.RegisterButton.TabIndex = 6;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = false;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // LinkToAuth
            // 
            this.LinkToAuth.AutoSize = true;
            this.LinkToAuth.LinkColor = System.Drawing.Color.Black;
            this.LinkToAuth.Location = new System.Drawing.Point(123, 241);
            this.LinkToAuth.Name = "LinkToAuth";
            this.LinkToAuth.Size = new System.Drawing.Size(33, 13);
            this.LinkToAuth.TabIndex = 13;
            this.LinkToAuth.TabStop = true;
            this.LinkToAuth.Text = "Login";
            this.LinkToAuth.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkToAuth.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToAuth_LinkClicked);
            // 
            // LinkToRedact
            // 
            this.LinkToRedact.AutoSize = true;
            this.LinkToRedact.LinkColor = System.Drawing.Color.Black;
            this.LinkToRedact.Location = new System.Drawing.Point(123, 263);
            this.LinkToRedact.Name = "LinkToRedact";
            this.LinkToRedact.Size = new System.Drawing.Size(42, 13);
            this.LinkToRedact.TabIndex = 14;
            this.LinkToRedact.TabStop = true;
            this.LinkToRedact.Text = "Redact";
            this.LinkToRedact.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkToRedact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToRedact_LinkClicked);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(148)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(276, 285);
            this.Controls.Add(this.LinkToRedact);
            this.Controls.Add(this.LinkToAuth);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserEmailField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.TextBox UserEmailField;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.LinkLabel LinkToAuth;
        private System.Windows.Forms.LinkLabel LinkToRedact;
    }
}