namespace Project
{
    partial class teacherCredentials
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
            this.label3 = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.departmentTextBox = new System.Windows.Forms.TextBox();
            this.saveteacherDetailsButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.classCodeTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Department";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(56, 73);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(169, 29);
            this.subjectTextBox.TabIndex = 4;
            // 
            // departmentTextBox
            // 
            this.departmentTextBox.Location = new System.Drawing.Point(56, 171);
            this.departmentTextBox.Name = "departmentTextBox";
            this.departmentTextBox.Size = new System.Drawing.Size(169, 29);
            this.departmentTextBox.TabIndex = 6;
            // 
            // saveteacherDetailsButton
            // 
            this.saveteacherDetailsButton.Location = new System.Drawing.Point(343, 250);
            this.saveteacherDetailsButton.Name = "saveteacherDetailsButton";
            this.saveteacherDetailsButton.Size = new System.Drawing.Size(137, 66);
            this.saveteacherDetailsButton.TabIndex = 8;
            this.saveteacherDetailsButton.Text = "Save credentials";
            this.saveteacherDetailsButton.UseVisualStyleBackColor = true;
            this.saveteacherDetailsButton.Click += new System.EventHandler(this.saveteacherDetailsButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Teacher credentials";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Class Code";
            // 
            // classCodeTextBox
            // 
            this.classCodeTextBox.Location = new System.Drawing.Point(56, 270);
            this.classCodeTextBox.Name = "classCodeTextBox";
            this.classCodeTextBox.Size = new System.Drawing.Size(169, 29);
            this.classCodeTextBox.TabIndex = 7;
            // 
            // teacherCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(492, 345);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveteacherDetailsButton);
            this.Controls.Add(this.classCodeTextBox);
            this.Controls.Add(this.departmentTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "teacherCredentials";
            this.Text = "Please enter details";
            this.Load += new System.EventHandler(this.teacherLoggedin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox departmentTextBox;
        private System.Windows.Forms.Button saveteacherDetailsButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox classCodeTextBox;
    }
}