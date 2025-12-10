namespace Project
{
    partial class StudentDetails
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.classcodetextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.parentnametextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Class code";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Subjects studying";
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(297, 349);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(270, 39);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Create account";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // classcodetextBox
            // 
            this.classcodetextBox.Location = new System.Drawing.Point(235, 45);
            this.classcodetextBox.Name = "classcodetextBox";
            this.classcodetextBox.Size = new System.Drawing.Size(180, 29);
            this.classcodetextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(478, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 21);
            this.label5.TabIndex = 10;
            this.label5.Text = "Student details";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(234, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Which level are you studying at?";
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "GCSE",
            "AS Level",
            "A-Level"});
            this.levelComboBox.Location = new System.Drawing.Point(235, 257);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(180, 29);
            this.levelComboBox.TabIndex = 12;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Items.AddRange(new object[] {
            "Latin",
            "Greek",
            "Ancient History",
            "Classical Civilization"});
            this.subjectComboBox.Location = new System.Drawing.Point(235, 161);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(180, 29);
            this.subjectComboBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "Parent name";
            // 
            // parentnametextBox
            // 
            this.parentnametextBox.Location = new System.Drawing.Point(235, 101);
            this.parentnametextBox.Name = "parentnametextBox";
            this.parentnametextBox.Size = new System.Drawing.Size(180, 29);
            this.parentnametextBox.TabIndex = 15;
            // 
            // StudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(653, 442);
            this.Controls.Add(this.parentnametextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classcodetextBox);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentDetails";
            this.Text = "Please enter details";
            this.Load += new System.EventHandler(this.StudentDetails_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button createAccountButton;
        private System.Windows.Forms.TextBox classcodetextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox parentnametextBox;
    }
}