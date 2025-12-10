namespace Project
{
    partial class StudentPage
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
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.welcomelabel = new System.Windows.Forms.Label();
            this.answerQuestionsButton = new System.Windows.Forms.Button();
            this.viewOtherScoresButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.viewMessagesButton = new System.Windows.Forms.Button();
            this.chooseSubjectComboBox = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sendFeedbackButton = new System.Windows.Forms.Button();
            this.viewPreviousScoresButton = new System.Windows.Forms.Button();
            this.teacherEnquiryButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Location = new System.Drawing.Point(147, 115);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(100, 21);
            this.studentIDLabel.TabIndex = 0;
            this.studentIDLabel.Text = "<StudentID>";
            // 
            // welcomelabel
            // 
            this.welcomelabel.AutoSize = true;
            this.welcomelabel.Location = new System.Drawing.Point(153, 64);
            this.welcomelabel.Name = "welcomelabel";
            this.welcomelabel.Size = new System.Drawing.Size(67, 21);
            this.welcomelabel.TabIndex = 1;
            this.welcomelabel.Text = "<none>";
            this.welcomelabel.Click += new System.EventHandler(this.label8_Click);
            // 
            // answerQuestionsButton
            // 
            this.answerQuestionsButton.Location = new System.Drawing.Point(60, 189);
            this.answerQuestionsButton.Name = "answerQuestionsButton";
            this.answerQuestionsButton.Size = new System.Drawing.Size(187, 30);
            this.answerQuestionsButton.TabIndex = 2;
            this.answerQuestionsButton.Text = "Answer questions";
            this.answerQuestionsButton.UseVisualStyleBackColor = true;
            this.answerQuestionsButton.Click += new System.EventHandler(this.answerQuestionsButton_Click);
            // 
            // viewOtherScoresButton
            // 
            this.viewOtherScoresButton.Location = new System.Drawing.Point(275, 189);
            this.viewOtherScoresButton.Name = "viewOtherScoresButton";
            this.viewOtherScoresButton.Size = new System.Drawing.Size(187, 30);
            this.viewOtherScoresButton.TabIndex = 4;
            this.viewOtherScoresButton.Text = "View other students\' scores";
            this.viewOtherScoresButton.UseVisualStyleBackColor = true;
            this.viewOtherScoresButton.Click += new System.EventHandler(this.viewOtherScoresButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 7;
            this.label2.Text = "StudentID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(64, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "Welcome,";
            // 
            // viewMessagesButton
            // 
            this.viewMessagesButton.Location = new System.Drawing.Point(275, 241);
            this.viewMessagesButton.Name = "viewMessagesButton";
            this.viewMessagesButton.Size = new System.Drawing.Size(187, 30);
            this.viewMessagesButton.TabIndex = 9;
            this.viewMessagesButton.Text = "View messages";
            this.viewMessagesButton.UseVisualStyleBackColor = true;
            this.viewMessagesButton.Click += new System.EventHandler(this.viewMessagesButton_Click);
            // 
            // chooseSubjectComboBox
            // 
            this.chooseSubjectComboBox.FormattingEnabled = true;
            this.chooseSubjectComboBox.Items.AddRange(new object[] {
            "Latin",
            "Greek",
            "Ancient History",
            "Classical Civilization"});
            this.chooseSubjectComboBox.Location = new System.Drawing.Point(16, 76);
            this.chooseSubjectComboBox.Name = "chooseSubjectComboBox";
            this.chooseSubjectComboBox.Size = new System.Drawing.Size(165, 29);
            this.chooseSubjectComboBox.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(175, 21);
            this.label9.TabIndex = 12;
            this.label9.Text = "Please choose a subject:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.chooseSubjectComboBox);
            this.groupBox1.Location = new System.Drawing.Point(275, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(187, 125);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // sendFeedbackButton
            // 
            this.sendFeedbackButton.Location = new System.Drawing.Point(60, 241);
            this.sendFeedbackButton.Name = "sendFeedbackButton";
            this.sendFeedbackButton.Size = new System.Drawing.Size(187, 30);
            this.sendFeedbackButton.TabIndex = 5;
            this.sendFeedbackButton.Text = "Review the application";
            this.sendFeedbackButton.UseVisualStyleBackColor = true;
            this.sendFeedbackButton.Click += new System.EventHandler(this.sendFeedbackButton_Click);
            // 
            // viewPreviousScoresButton
            // 
            this.viewPreviousScoresButton.Location = new System.Drawing.Point(60, 289);
            this.viewPreviousScoresButton.Name = "viewPreviousScoresButton";
            this.viewPreviousScoresButton.Size = new System.Drawing.Size(187, 30);
            this.viewPreviousScoresButton.TabIndex = 3;
            this.viewPreviousScoresButton.Text = "View previous scores";
            this.viewPreviousScoresButton.UseVisualStyleBackColor = true;
            this.viewPreviousScoresButton.Click += new System.EventHandler(this.viewPreviousScoresButton_Click);
            // 
            // teacherEnquiryButton
            // 
            this.teacherEnquiryButton.Location = new System.Drawing.Point(275, 289);
            this.teacherEnquiryButton.Name = "teacherEnquiryButton";
            this.teacherEnquiryButton.Size = new System.Drawing.Size(187, 30);
            this.teacherEnquiryButton.TabIndex = 6;
            this.teacherEnquiryButton.Text = "Ask question to teacher";
            this.teacherEnquiryButton.UseVisualStyleBackColor = true;
            this.teacherEnquiryButton.Click += new System.EventHandler(this.teacherEnquiryButton_Click);
            // 
            // StudentPage
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(538, 369);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.viewMessagesButton);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.teacherEnquiryButton);
            this.Controls.Add(this.sendFeedbackButton);
            this.Controls.Add(this.viewOtherScoresButton);
            this.Controls.Add(this.viewPreviousScoresButton);
            this.Controls.Add(this.answerQuestionsButton);
            this.Controls.Add(this.welcomelabel);
            this.Controls.Add(this.studentIDLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentPage";
            this.Text = "Student Page";
            this.Load += new System.EventHandler(this.StudentPage_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label noneLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.Label welcomelabel;
        private System.Windows.Forms.Button answerQuestionsButton;
        private System.Windows.Forms.Button viewOtherScoresButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button viewMessagesButton;
        private System.Windows.Forms.ComboBox chooseSubjectComboBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button sendFeedbackButton;
        private System.Windows.Forms.Button viewPreviousScoresButton;
        private System.Windows.Forms.Button teacherEnquiryButton;
    }
}