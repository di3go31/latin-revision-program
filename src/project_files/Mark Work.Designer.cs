namespace Project
{
    partial class Mark_Work
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
            this.studentComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.loadNamesButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.answerLabel = new System.Windows.Forms.Label();
            this.numberMarksTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.questionsComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.originalAnswerLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.doneQuestionButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.numberMarksLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // studentComboBox
            // 
            this.studentComboBox.FormattingEnabled = true;
            this.studentComboBox.Location = new System.Drawing.Point(193, 74);
            this.studentComboBox.Name = "studentComboBox";
            this.studentComboBox.Size = new System.Drawing.Size(142, 29);
            this.studentComboBox.TabIndex = 0;
            this.studentComboBox.SelectedIndexChanged += new System.EventHandler(this.studentCombobox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of students:";
            // 
            // loadNamesButton
            // 
            this.loadNamesButton.Location = new System.Drawing.Point(40, 74);
            this.loadNamesButton.Name = "loadNamesButton";
            this.loadNamesButton.Size = new System.Drawing.Size(117, 29);
            this.loadNamesButton.TabIndex = 2;
            this.loadNamesButton.Text = "Start";
            this.loadNamesButton.UseVisualStyleBackColor = true;
            this.loadNamesButton.Click += new System.EventHandler(this.loadNamesButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(362, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Current student:";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Location = new System.Drawing.Point(535, 77);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(67, 21);
            this.studentNameLabel.TabIndex = 4;
            this.studentNameLabel.Text = "<none>";
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(189, 283);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(67, 21);
            this.answerLabel.TabIndex = 5;
            this.answerLabel.Text = "<none>";
            // 
            // numberMarksTextBox
            // 
            this.numberMarksTextBox.Location = new System.Drawing.Point(189, 392);
            this.numberMarksTextBox.Name = "numberMarksTextBox";
            this.numberMarksTextBox.Size = new System.Drawing.Size(110, 29);
            this.numberMarksTextBox.TabIndex = 6;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(366, 392);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(110, 29);
            this.nextButton.TabIndex = 7;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 358);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Marks awarded:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "Student answer:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "Original question:";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(189, 211);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(67, 21);
            this.questionLabel.TabIndex = 11;
            this.questionLabel.Text = "<none>";
            // 
            // questionsComboBox
            // 
            this.questionsComboBox.FormattingEnabled = true;
            this.questionsComboBox.Location = new System.Drawing.Point(189, 148);
            this.questionsComboBox.Name = "questionsComboBox";
            this.questionsComboBox.Size = new System.Drawing.Size(341, 29);
            this.questionsComboBox.TabIndex = 12;
            this.questionsComboBox.SelectedIndexChanged += new System.EventHandler(this.questionsComboBox_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(544, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 21);
            this.label3.TabIndex = 13;
            this.label3.Text = "Answer to the question:";
            // 
            // originalAnswerLabel
            // 
            this.originalAnswerLabel.AutoSize = true;
            this.originalAnswerLabel.Location = new System.Drawing.Point(548, 283);
            this.originalAnswerLabel.Name = "originalAnswerLabel";
            this.originalAnswerLabel.Size = new System.Drawing.Size(52, 21);
            this.originalAnswerLabel.TabIndex = 14;
            this.originalAnswerLabel.Text = "label4";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 21);
            this.label4.TabIndex = 15;
            this.label4.Text = "Questions:";
            // 
            // doneQuestionButton
            // 
            this.doneQuestionButton.Location = new System.Drawing.Point(579, 143);
            this.doneQuestionButton.Name = "doneQuestionButton";
            this.doneQuestionButton.Size = new System.Drawing.Size(75, 37);
            this.doneQuestionButton.TabIndex = 16;
            this.doneQuestionButton.Text = "Done";
            this.doneQuestionButton.UseVisualStyleBackColor = true;
            this.doneQuestionButton.Click += new System.EventHandler(this.doneQuestionButton_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(787, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(120, 21);
            this.label8.TabIndex = 17;
            this.label8.Text = "Mark allocation:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // numberMarksLabel
            // 
            this.numberMarksLabel.AutoSize = true;
            this.numberMarksLabel.Location = new System.Drawing.Point(855, 242);
            this.numberMarksLabel.Name = "numberMarksLabel";
            this.numberMarksLabel.Size = new System.Drawing.Size(52, 21);
            this.numberMarksLabel.TabIndex = 18;
            this.numberMarksLabel.Text = "label9";
            // 
            // Mark_Work
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 484);
            this.Controls.Add(this.numberMarksLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.doneQuestionButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.originalAnswerLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.questionsComboBox);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.numberMarksTextBox);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.loadNamesButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studentComboBox);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Mark_Work";
            this.Text = "Mark_Work";
            this.Load += new System.EventHandler(this.Mark_Work_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox studentComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loadNamesButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.TextBox numberMarksTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.ComboBox questionsComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label originalAnswerLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button doneQuestionButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label numberMarksLabel;
    }
}