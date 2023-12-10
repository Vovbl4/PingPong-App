namespace MyDesktopApp
{
    partial class AuthForm
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
            this.AuthButton = new System.Windows.Forms.Button();
            this.UserPasswordField = new System.Windows.Forms.TextBox();
            this.UserLoginField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LinkToReg = new System.Windows.Forms.LinkLabel();
            this.LinkToRedact = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // AuthButton
            // 
            this.AuthButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(201)))), ((int)(((byte)(123)))));
            this.AuthButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AuthButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AuthButton.ForeColor = System.Drawing.Color.Black;
            this.AuthButton.Location = new System.Drawing.Point(89, 206);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(104, 33);
            this.AuthButton.TabIndex = 11;
            this.AuthButton.Text = "Login";
            this.AuthButton.UseVisualStyleBackColor = false;
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // UserPasswordField
            // 
            this.UserPasswordField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.UserPasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserPasswordField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserPasswordField.ForeColor = System.Drawing.Color.Gray;
            this.UserPasswordField.Location = new System.Drawing.Point(66, 149);
            this.UserPasswordField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserPasswordField.Name = "UserPasswordField";
            this.UserPasswordField.Size = new System.Drawing.Size(150, 24);
            this.UserPasswordField.TabIndex = 10;
            this.UserPasswordField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserPasswordField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // UserLoginField
            // 
            this.UserLoginField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(89)))), ((int)(((byte)(34)))));
            this.UserLoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserLoginField.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserLoginField.ForeColor = System.Drawing.Color.Gray;
            this.UserLoginField.Location = new System.Drawing.Point(66, 104);
            this.UserLoginField.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UserLoginField.Name = "UserLoginField";
            this.UserLoginField.Size = new System.Drawing.Size(150, 24);
            this.UserLoginField.TabIndex = 8;
            this.UserLoginField.Enter += new System.EventHandler(this.TextBox_Enter);
            this.UserLoginField.Leave += new System.EventHandler(this.TextBox_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(98, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Login";
            // 
            // LinkToReg
            // 
            this.LinkToReg.AutoSize = true;
            this.LinkToReg.LinkColor = System.Drawing.Color.Black;
            this.LinkToReg.Location = new System.Drawing.Point(119, 253);
            this.LinkToReg.Name = "LinkToReg";
            this.LinkToReg.Size = new System.Drawing.Size(46, 13);
            this.LinkToReg.TabIndex = 12;
            this.LinkToReg.TabStop = true;
            this.LinkToReg.Text = "Register";
            this.LinkToReg.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkToReg.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToReg_LinkClicked);
            // 
            // LinkToRedact
            // 
            this.LinkToRedact.AutoSize = true;
            this.LinkToRedact.LinkColor = System.Drawing.Color.Black;
            this.LinkToRedact.Location = new System.Drawing.Point(119, 275);
            this.LinkToRedact.Name = "LinkToRedact";
            this.LinkToRedact.Size = new System.Drawing.Size(42, 13);
            this.LinkToRedact.TabIndex = 13;
            this.LinkToRedact.TabStop = true;
            this.LinkToRedact.Text = "Redact";
            this.LinkToRedact.VisitedLinkColor = System.Drawing.Color.Black;
            this.LinkToRedact.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkToRedact_LinkClicked);
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(148)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(284, 311);
            this.Controls.Add(this.LinkToRedact);
            this.Controls.Add(this.LinkToReg);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.UserPasswordField);
            this.Controls.Add(this.UserLoginField);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AuthButton;
        private System.Windows.Forms.TextBox UserPasswordField;
        private System.Windows.Forms.TextBox UserLoginField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel LinkToReg;
        private System.Windows.Forms.LinkLabel LinkToRedact;
    }
}