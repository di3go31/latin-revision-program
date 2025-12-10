namespace Project
{
    partial class addQuestion
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
            this.saveQuestionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.marksTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.levelComboBox = new System.Windows.Forms.ComboBox();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveQuestionButton
            // 
            this.saveQuestionButton.Location = new System.Drawing.Point(419, 584);
            this.saveQuestionButton.Name = "saveQuestionButton";
            this.saveQuestionButton.Size = new System.Drawing.Size(176, 29);
            this.saveQuestionButton.TabIndex = 0;
            this.saveQuestionButton.Text = "Save question";
            this.saveQuestionButton.UseVisualStyleBackColor = true;
            this.saveQuestionButton.Click += new System.EventHandler(this.saveQuestionButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 42);
            this.label1.TabIndex = 1;
            this.label1.Text = "How hard is the question?\r\n(Estimated grade)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 205);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Type the question to \r\nbe inserted here:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 42);
            this.label3.TabIndex = 3;
            this.label3.Text = "What is the answer \r\nto the question?";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 42);
            this.label4.TabIndex = 4;
            this.label4.Text = "How many marks \r\nis it worth?";
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(179, 153);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(197, 29);
            this.gradeTextBox.TabIndex = 5;
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(179, 250);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(197, 29);
            this.questionTextBox.TabIndex = 6;
            this.questionTextBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // answerTextBox
            // 
            this.answerTextBox.Location = new System.Drawing.Point(179, 334);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(197, 29);
            this.answerTextBox.TabIndex = 7;
            // 
            // marksTextBox
            // 
            this.marksTextBox.Location = new System.Drawing.Point(179, 423);
            this.marksTextBox.Name = "marksTextBox";
            this.marksTextBox.Size = new System.Drawing.Size(197, 29);
            this.marksTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 21);
            this.label5.TabIndex = 9;
            this.label5.Text = "Which topic?";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(552, 21);
            this.label6.TabIndex = 11;
            this.label6.Text = "Please enter the following details regarding the question you wish to be added";
            // 
            // topicComboBox
            // 
            this.topicComboBox.FormattingEnabled = true;
            this.topicComboBox.Items.AddRange(new object[] {
            "Chapter 1 (cases, tenses, complex relative clauses, jussive subjunctive)",
            "Chapter 2 (principal parts, indirect statement, ablative absolute, time)",
            "Chapter 3 (predicative dative, gerunds, and gerundives)",
            "Chapter 4 (unseen translation passages, English to Latin)",
            "Chapter 5 (unseen prose: Livy, scansion)",
            "Chapter 6 (Readings)"});
            this.topicComboBox.Location = new System.Drawing.Point(179, 63);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(197, 29);
            this.topicComboBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(41, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(187, 21);
            this.label7.TabIndex = 13;
            this.label7.Text = "Is it GCSE, AS, or A-Level?";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 565);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Subject";
            // 
            // levelComboBox
            // 
            this.levelComboBox.FormattingEnabled = true;
            this.levelComboBox.Items.AddRange(new object[] {
            "GCSE",
            "AS Level",
            "A-Level"});
            this.levelComboBox.Location = new System.Drawing.Point(179, 518);
            this.levelComboBox.Name = "levelComboBox";
            this.levelComboBox.Size = new System.Drawing.Size(197, 29);
            this.levelComboBox.TabIndex = 17;
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Items.AddRange(new object[] {
            "Latin",
            "Greek",
            "Ancient History",
            "Classical Civilization"});
            this.subjectComboBox.Location = new System.Drawing.Point(179, 584);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(197, 29);
            this.subjectComboBox.TabIndex = 18;
            // 
            // addQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(621, 653);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(this.levelComboBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.topicComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.marksTextBox);
            this.Controls.Add(this.answerTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveQuestionButton);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "addQuestion";
            this.Text = "Add questions";
            this.Load += new System.EventHandler(this.addQuestion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveQuestionButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.TextBox marksTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox levelComboBox;
        private System.Windows.Forms.ComboBox subjectComboBox;
    }
}