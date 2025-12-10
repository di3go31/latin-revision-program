namespace Project
{
    partial class ParentLoggedin
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
            this.nonelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.communicateTeacherButton = new System.Windows.Forms.Button();
            this.viewProgressButton = new System.Windows.Forms.Button();
            this.viewMessagesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome,";
            // 
            // nonelabel
            // 
            this.nonelabel.AutoSize = true;
            this.nonelabel.Location = new System.Drawing.Point(156, 70);
            this.nonelabel.Name = "nonelabel";
            this.nonelabel.Size = new System.Drawing.Size(73, 23);
            this.nonelabel.TabIndex = 1;
            this.nonelabel.Text = "<none>";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Options:";
            // 
            // communicateTeacherButton
            // 
            this.communicateTeacherButton.Location = new System.Drawing.Point(60, 148);
            this.communicateTeacherButton.Name = "communicateTeacherButton";
            this.communicateTeacherButton.Size = new System.Drawing.Size(169, 34);
            this.communicateTeacherButton.TabIndex = 3;
            this.communicateTeacherButton.Text = "Communicate with teacher";
            this.communicateTeacherButton.UseVisualStyleBackColor = true;
            this.communicateTeacherButton.Click += new System.EventHandler(this.communicateTeacherButton_Click);
            // 
            // viewProgressButton
            // 
            this.viewProgressButton.Location = new System.Drawing.Point(60, 260);
            this.viewProgressButton.Name = "viewProgressButton";
            this.viewProgressButton.Size = new System.Drawing.Size(169, 60);
            this.viewProgressButton.TabIndex = 4;
            this.viewProgressButton.Text = "View son\'s or daughter\'s progress";
            this.viewProgressButton.UseVisualStyleBackColor = true;
            this.viewProgressButton.Click += new System.EventHandler(this.viewProgressButton_Click);
            // 
            // viewMessagesButton
            // 
            this.viewMessagesButton.Location = new System.Drawing.Point(60, 204);
            this.viewMessagesButton.Name = "viewMessagesButton";
            this.viewMessagesButton.Size = new System.Drawing.Size(169, 34);
            this.viewMessagesButton.TabIndex = 5;
            this.viewMessagesButton.Text = "View messages";
            this.viewMessagesButton.UseVisualStyleBackColor = true;
            this.viewMessagesButton.Click += new System.EventHandler(this.viewMessagesButton_Click);
            // 
            // ParentLoggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(329, 396);
            this.Controls.Add(this.viewMessagesButton);
            this.Controls.Add(this.viewProgressButton);
            this.Controls.Add(this.communicateTeacherButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nonelabel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Name = "ParentLoggedin";
            this.Text = "Parent page";
            this.Load += new System.EventHandler(this.ParentLoggedin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nonelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button communicateTeacherButton;
        private System.Windows.Forms.Button viewProgressButton;
        private System.Windows.Forms.Button viewMessagesButton;
    }
}