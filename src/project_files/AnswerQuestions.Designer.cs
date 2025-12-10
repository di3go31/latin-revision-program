namespace Project
{
    partial class answerQuestions
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
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.topicLable = new System.Windows.Forms.Label();
            this.chooseTopicGroupBox = new System.Windows.Forms.GroupBox();
            this.seeClueButton = new System.Windows.Forms.Button();
            this.LevelComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.doneButton = new System.Windows.Forms.Button();
            this.TopicComboBox = new System.Windows.Forms.ComboBox();
            this.answerQuestionGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.goBackButton = new System.Windows.Forms.Button();
            this.chooseTopicGroupBox.SuspendLayout();
            this.answerQuestionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(41, 86);
            this.questionTextBox.Multiline = true;
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(504, 161);
            this.questionTextBox.TabIndex = 0;
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(37, 35);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(92, 21);
            this.questionLabel.TabIndex = 2;
            this.questionLabel.Text = "<question>";
            // 
            // topicLable
            // 
            this.topicLable.AutoSize = true;
            this.topicLable.Location = new System.Drawing.Point(10, 35);
            this.topicLable.Name = "topicLable";
            this.topicLable.Size = new System.Drawing.Size(183, 42);
            this.topicLable.TabIndex = 6;
            this.topicLable.Text = "Which topic are you \r\nstruggling the most with:";
            this.topicLable.Click += new System.EventHandler(this.topicLable_Click);
            // 
            // chooseTopicGroupBox
            // 
            this.chooseTopicGroupBox.Controls.Add(this.seeClueButton);
            this.chooseTopicGroupBox.Controls.Add(this.LevelComboBox);
            this.chooseTopicGroupBox.Controls.Add(this.label2);
            this.chooseTopicGroupBox.Controls.Add(this.doneButton);
            this.chooseTopicGroupBox.Controls.Add(this.TopicComboBox);
            this.chooseTopicGroupBox.Controls.Add(this.topicLable);
            this.chooseTopicGroupBox.Location = new System.Drawing.Point(46, 30);
            this.chooseTopicGroupBox.Name = "chooseTopicGroupBox";
            this.chooseTopicGroupBox.Size = new System.Drawing.Size(567, 178);
            this.chooseTopicGroupBox.TabIndex = 7;
            this.chooseTopicGroupBox.TabStop = false;
            this.chooseTopicGroupBox.Text = "Choose topic";
            // 
            // seeClueButton
            // 
            this.seeClueButton.Location = new System.Drawing.Point(433, 144);
            this.seeClueButton.Name = "seeClueButton";
            this.seeClueButton.Size = new System.Drawing.Size(112, 28);
            this.seeClueButton.TabIndex = 10;
            this.seeClueButton.Text = "See clue";
            this.seeClueButton.UseVisualStyleBackColor = true;
            this.seeClueButton.Click += new System.EventHandler(this.seeClueButton_Click);
            // 
            // LevelComboBox
            // 
            this.LevelComboBox.FormattingEnabled = true;
            this.LevelComboBox.Items.AddRange(new object[] {
            "GCSE",
            "AS Level",
            "A Level"});
            this.LevelComboBox.Location = new System.Drawing.Point(259, 97);
            this.LevelComboBox.Name = "LevelComboBox";
            this.LevelComboBox.Size = new System.Drawing.Size(286, 29);
            this.LevelComboBox.TabIndex = 9;
            this.LevelComboBox.SelectedIndexChanged += new System.EventHandler(this.LevelComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 21);
            this.label2.TabIndex = 8;
            this.label2.Text = "Which level are you studying at?";
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(259, 144);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(112, 28);
            this.doneButton.TabIndex = 9;
            this.doneButton.Text = "Start questions";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // TopicComboBox
            // 
            this.TopicComboBox.FormattingEnabled = true;
            this.TopicComboBox.Items.AddRange(new object[] {
            "Chapter 1 (cases, tenses, complex relative clauses, jussive subjunctive)",
            "Chapter 2 (principal parts, indirect statement, ablative absolute, time)",
            "Chapter 3 (predicative dative, gerunds, and gerundives)",
            "Chapter 4 (unseen translation passages, English to Latin)",
            "Chapter 5 (unseen prose: Livy, scansion)",
            "Chapter 6 (Readings)"});
            this.TopicComboBox.Location = new System.Drawing.Point(259, 35);
            this.TopicComboBox.Name = "TopicComboBox";
            this.TopicComboBox.Size = new System.Drawing.Size(286, 29);
            this.TopicComboBox.TabIndex = 7;
            // 
            // answerQuestionGroupBox
            // 
            this.answerQuestionGroupBox.Controls.Add(this.questionTextBox);
            this.answerQuestionGroupBox.Controls.Add(this.questionLabel);
            this.answerQuestionGroupBox.Location = new System.Drawing.Point(46, 224);
            this.answerQuestionGroupBox.Name = "answerQuestionGroupBox";
            this.answerQuestionGroupBox.Size = new System.Drawing.Size(567, 270);
            this.answerQuestionGroupBox.TabIndex = 8;
            this.answerQuestionGroupBox.TabStop = false;
            this.answerQuestionGroupBox.Text = "Answer questions";
            this.answerQuestionGroupBox.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(305, 500);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(117, 31);
            this.SubmitButton.TabIndex = 10;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // goBackButton
            // 
            this.goBackButton.Location = new System.Drawing.Point(452, 499);
            this.goBackButton.Name = "goBackButton";
            this.goBackButton.Size = new System.Drawing.Size(119, 31);
            this.goBackButton.TabIndex = 11;
            this.goBackButton.Text = "Go back";
            this.goBackButton.UseVisualStyleBackColor = true;
            this.goBackButton.Click += new System.EventHandler(this.goBackButton_Click);
            // 
            // answerQuestions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(669, 554);
            this.Controls.Add(this.goBackButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.answerQuestionGroupBox);
            this.Controls.Add(this.chooseTopicGroupBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "answerQuestions";
            this.Text = "Answer questions";
            this.Load += new System.EventHandler(this.answerQuestions_Load);
            this.chooseTopicGroupBox.ResumeLayout(false);
            this.chooseTopicGroupBox.PerformLayout();
            this.answerQuestionGroupBox.ResumeLayout(false);
            this.answerQuestionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.Label topicLable;
        private System.Windows.Forms.GroupBox chooseTopicGroupBox;
        private System.Windows.Forms.GroupBox answerQuestionGroupBox;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.ComboBox LevelComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox TopicComboBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button goBackButton;
        private System.Windows.Forms.Button seeClueButton;
    }
}