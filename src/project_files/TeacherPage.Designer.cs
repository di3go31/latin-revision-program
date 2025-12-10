namespace Project
{
    partial class teacherLoggedin
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
            this.viewProgressButton = new System.Windows.Forms.Button();
            this.commentStudentButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nonelabel = new System.Windows.Forms.Label();
            this.addQuestionsButton = new System.Windows.Forms.Button();
            this.viewMessagesButton = new System.Windows.Forms.Button();
            this.MarkWorkButton = new System.Windows.Forms.Button();
            this.communicateParentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // viewProgressButton
            // 
            this.viewProgressButton.Location = new System.Drawing.Point(92, 192);
            this.viewProgressButton.Name = "viewProgressButton";
            this.viewProgressButton.Size = new System.Drawing.Size(195, 36);
            this.viewProgressButton.TabIndex = 1;
            this.viewProgressButton.Text = "View students\' progress";
            this.viewProgressButton.UseVisualStyleBackColor = true;
            this.viewProgressButton.Click += new System.EventHandler(this.viewProgressButton_Click);
            // 
            // commentStudentButton
            // 
            this.commentStudentButton.Location = new System.Drawing.Point(92, 253);
            this.commentStudentButton.Name = "commentStudentButton";
            this.commentStudentButton.Size = new System.Drawing.Size(195, 36);
            this.commentStudentButton.TabIndex = 2;
            this.commentStudentButton.Text = "Comment on student\'s progress";
            this.commentStudentButton.UseVisualStyleBackColor = true;
            this.commentStudentButton.Click += new System.EventHandler(this.commentStudentButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome,";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "What would you like to do?";
            // 
            // nonelabel
            // 
            this.nonelabel.AutoSize = true;
            this.nonelabel.Location = new System.Drawing.Point(197, 39);
            this.nonelabel.Name = "nonelabel";
            this.nonelabel.Size = new System.Drawing.Size(67, 21);
            this.nonelabel.TabIndex = 6;
            this.nonelabel.Text = "<none>";
            // 
            // addQuestionsButton
            // 
            this.addQuestionsButton.Location = new System.Drawing.Point(92, 134);
            this.addQuestionsButton.Name = "addQuestionsButton";
            this.addQuestionsButton.Size = new System.Drawing.Size(195, 36);
            this.addQuestionsButton.TabIndex = 0;
            this.addQuestionsButton.Text = "Add questions";
            this.addQuestionsButton.UseVisualStyleBackColor = true;
            this.addQuestionsButton.Click += new System.EventHandler(this.addQuestionsButton_Click);
            // 
            // viewMessagesButton
            // 
            this.viewMessagesButton.Location = new System.Drawing.Point(92, 386);
            this.viewMessagesButton.Name = "viewMessagesButton";
            this.viewMessagesButton.Size = new System.Drawing.Size(195, 36);
            this.viewMessagesButton.TabIndex = 7;
            this.viewMessagesButton.Text = "View messages";
            this.viewMessagesButton.UseVisualStyleBackColor = true;
            this.viewMessagesButton.Click += new System.EventHandler(this.viewMessagesButton_Click);
            // 
            // MarkWorkButton
            // 
            this.MarkWorkButton.Location = new System.Drawing.Point(92, 442);
            this.MarkWorkButton.Name = "MarkWorkButton";
            this.MarkWorkButton.Size = new System.Drawing.Size(195, 37);
            this.MarkWorkButton.TabIndex = 8;
            this.MarkWorkButton.Text = "Mark students\' work";
            this.MarkWorkButton.UseVisualStyleBackColor = true;
            this.MarkWorkButton.Click += new System.EventHandler(this.MarkWorkButton_Click);
            // 
            // communicateParentButton
            // 
            this.communicateParentButton.Location = new System.Drawing.Point(92, 312);
            this.communicateParentButton.Name = "communicateParentButton";
            this.communicateParentButton.Size = new System.Drawing.Size(195, 52);
            this.communicateParentButton.TabIndex = 3;
            this.communicateParentButton.Text = "Communicate with parent";
            this.communicateParentButton.UseVisualStyleBackColor = true;
            this.communicateParentButton.Click += new System.EventHandler(this.communicateParentButton_Click);
            // 
            // teacherLoggedin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(365, 523);
            this.Controls.Add(this.MarkWorkButton);
            this.Controls.Add(this.viewMessagesButton);
            this.Controls.Add(this.nonelabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.communicateParentButton);
            this.Controls.Add(this.commentStudentButton);
            this.Controls.Add(this.viewProgressButton);
            this.Controls.Add(this.addQuestionsButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "teacherLoggedin";
            this.Text = "Teacher page";
            this.Load += new System.EventHandler(this.teacherLoggedin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addQuestionsButton;
        private System.Windows.Forms.Button viewProgressButton;
        private System.Windows.Forms.Button commentStudentButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nonelabel;
        private System.Windows.Forms.Button viewMessagesButton;
        private System.Windows.Forms.Button MarkWorkButton;
        private System.Windows.Forms.Button communicateParentButton;
    }
}