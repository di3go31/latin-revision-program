namespace Project
{
    partial class ChooseTopic
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
            this.chooseChapterchecbox = new System.Windows.Forms.CheckedListBox();
            this.topicLable = new System.Windows.Forms.Label();
            this.topicDoneButton = new System.Windows.Forms.Button();
            this.backtoLoginButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // chooseChapterchecbox
            // 
            this.chooseChapterchecbox.FormattingEnabled = true;
            this.chooseChapterchecbox.Items.AddRange(new object[] {
            "Chapter 1 (verbs, present sum)",
            "Chapter 2 (genitive, ablative, dative case, infinitive)",
            "Chapter 3 (imperfect tense, possum, vocative)",
            "Chapter 4 (perfect tense, direct questions)",
            "Chapter 5 (future tense, sum, possum, nos, vos)",
            "Chapter 6 (pluperfect tense, quod, quamquam, numerals)",
            "Chapter 7 (hic, ille, active and passive, future passive)",
            "Chapter 8 (pluperfect passive, ablative absolute)",
            "Chapter 9 (passive infinitive, deponent verbs)",
            "Chapter 10 (imperfect subjunctive, complex sentences, cum clauses)",
            "Chapter 11 (revision passages)",
            "Chapter 12 (practice papers)"});
            this.chooseChapterchecbox.Location = new System.Drawing.Point(40, 107);
            this.chooseChapterchecbox.Name = "chooseChapterchecbox";
            this.chooseChapterchecbox.Size = new System.Drawing.Size(479, 212);
            this.chooseChapterchecbox.TabIndex = 0;
            this.chooseChapterchecbox.SelectedIndexChanged += new System.EventHandler(this.chooseChapterchecbox_SelectedIndexChanged);
            // 
            // topicLable
            // 
            this.topicLable.AutoSize = true;
            this.topicLable.Location = new System.Drawing.Point(51, 55);
            this.topicLable.Name = "topicLable";
            this.topicLable.Size = new System.Drawing.Size(325, 21);
            this.topicLable.TabIndex = 1;
            this.topicLable.Text = "Which topic are you struggling the most with:";
            // 
            // topicDoneButton
            // 
            this.topicDoneButton.Location = new System.Drawing.Point(40, 350);
            this.topicDoneButton.Name = "topicDoneButton";
            this.topicDoneButton.Size = new System.Drawing.Size(124, 56);
            this.topicDoneButton.TabIndex = 2;
            this.topicDoneButton.Text = "Done";
            this.topicDoneButton.UseVisualStyleBackColor = true;
            this.topicDoneButton.Click += new System.EventHandler(this.topicDoneButton_Click);
            // 
            // backtoLoginButton
            // 
            this.backtoLoginButton.Location = new System.Drawing.Point(219, 350);
            this.backtoLoginButton.Name = "backtoLoginButton";
            this.backtoLoginButton.Size = new System.Drawing.Size(127, 56);
            this.backtoLoginButton.TabIndex = 3;
            this.backtoLoginButton.Text = "Back to login";
            this.backtoLoginButton.UseVisualStyleBackColor = true;
            this.backtoLoginButton.Click += new System.EventHandler(this.backtoLoginButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(406, 350);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(113, 56);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Chapter 1 (verbs, present sum)",
            "Chapter 2 (genitive, ablative, dative case, infinitive)",
            "Chapter 3 (imperfect tense, possum, vocative)",
            "Chapter 4 (perfect tense, direct questions)",
            "Chapter 5 (future tense, sum, possum, nos, vos)",
            "Chapter 6 (pluperfect tense, quod, quamquam, numerals)",
            "Chapter 7 (hic, ille, active and passive, future passive)",
            "Chapter 8 (pluperfect passive, ablative absolute)",
            "Chapter 9 (passive infinitive, deponent verbs)",
            "Chapter 10 (imperfect subjunctive, complex sentences, cum clauses)",
            "Chapter 11 (revision passages)",
            "Chapter 12 (practice papers)"});
            this.comboBox1.Location = new System.Drawing.Point(398, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // ChooseTopic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(570, 443);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.backtoLoginButton);
            this.Controls.Add(this.topicDoneButton);
            this.Controls.Add(this.topicLable);
            this.Controls.Add(this.chooseChapterchecbox);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChooseTopic";
            this.Text = "Choose Topic";
            this.Load += new System.EventHandler(this.ChooseTopic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label topicLable;
        private System.Windows.Forms.Button topicDoneButton;
        private System.Windows.Forms.CheckedListBox chooseChapterchecbox;
        private System.Windows.Forms.Button backtoLoginButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}