using System;

namespace Project
{
    partial class Login
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
            this.usernameLoginLable = new System.Windows.Forms.Label();
            this.usernameTextboxLogin = new System.Windows.Forms.TextBox();
            this.passwordLabelLogin = new System.Windows.Forms.Label();
            this.passwordTextboxLogin = new System.Windows.Forms.TextBox();
            this.registerButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.exitButton = new System.Windows.Forms.Button();
            this.roleComboboxLogin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // usernameLoginLable
            // 
            this.usernameLoginLable.AutoSize = true;
            this.usernameLoginLable.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLoginLable.Location = new System.Drawing.Point(171, 77);
            this.usernameLoginLable.Name = "usernameLoginLable";
            this.usernameLoginLable.Size = new System.Drawing.Size(84, 21);
            this.usernameLoginLable.TabIndex = 0;
            this.usernameLoginLable.Text = "Username:";
            // 
            // usernameTextboxLogin
            // 
            this.usernameTextboxLogin.BackColor = System.Drawing.Color.White;
            this.usernameTextboxLogin.Location = new System.Drawing.Point(139, 112);
            this.usernameTextboxLogin.Name = "usernameTextboxLogin";
            this.usernameTextboxLogin.Size = new System.Drawing.Size(163, 29);
            this.usernameTextboxLogin.TabIndex = 1;
            // 
            // passwordLabelLogin
            // 
            this.passwordLabelLogin.AutoSize = true;
            this.passwordLabelLogin.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabelLogin.Location = new System.Drawing.Point(171, 167);
            this.passwordLabelLogin.Name = "passwordLabelLogin";
            this.passwordLabelLogin.Size = new System.Drawing.Size(79, 21);
            this.passwordLabelLogin.TabIndex = 2;
            this.passwordLabelLogin.Text = "Password:";
            // 
            // passwordTextboxLogin
            // 
            this.passwordTextboxLogin.BackColor = System.Drawing.Color.White;
            this.passwordTextboxLogin.Location = new System.Drawing.Point(139, 211);
            this.passwordTextboxLogin.Name = "passwordTextboxLogin";
            this.passwordTextboxLogin.PasswordChar = '*';
            this.passwordTextboxLogin.Size = new System.Drawing.Size(163, 29);
            this.passwordTextboxLogin.TabIndex = 5;
            // 
            // registerButton
            // 
            this.registerButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerButton.Location = new System.Drawing.Point(160, 379);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(90, 36);
            this.registerButton.TabIndex = 7;
            this.registerButton.Text = "Register";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(27, 378);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(90, 37);
            this.loginButton.TabIndex = 9;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(297, 378);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(90, 37);
            this.exitButton.TabIndex = 10;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // roleComboboxLogin
            // 
            this.roleComboboxLogin.BackColor = System.Drawing.Color.White;
            this.roleComboboxLogin.FormattingEnabled = true;
            this.roleComboboxLogin.Items.AddRange(new object[] {
            "Student ",
            "Parent ",
            "Teacher"});
            this.roleComboboxLogin.Location = new System.Drawing.Point(139, 302);
            this.roleComboboxLogin.Name = "roleComboboxLogin";
            this.roleComboboxLogin.Size = new System.Drawing.Size(163, 29);
            this.roleComboboxLogin.TabIndex = 11;
            this.roleComboboxLogin.SelectedIndexChanged += new System.EventHandler(this.roleComboboxLogin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Position";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(135, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Please enter login details:";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(454, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.roleComboboxLogin);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordTextboxLogin);
            this.Controls.Add(this.passwordLabelLogin);
            this.Controls.Add(this.usernameTextboxLogin);
            this.Controls.Add(this.usernameLoginLable);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void roleComboboxLogin_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #endregion

        private System.Windows.Forms.Label usernameLoginLable;
        private System.Windows.Forms.TextBox usernameTextboxLogin;
        private System.Windows.Forms.Label passwordLabelLogin;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox roleComboboxLogin;
        private System.Windows.Forms.TextBox passwordTextboxLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

