namespace Project
{
    partial class ViewScores
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label1 = new System.Windows.Forms.Label();
            this.averageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.topicProgressChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.topicComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.targetGradeTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.distributionLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.zScoreLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.meanLabel = new System.Windows.Forms.Label();
            this.standardDeviationLabel = new System.Windows.Forms.Label();
            this.IDTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.varianceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.averageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicProgressChart)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Progress made:";
            // 
            // averageChart
            // 
            chartArea1.Name = "ChartArea1";
            this.averageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.averageChart.Legends.Add(legend1);
            this.averageChart.Location = new System.Drawing.Point(400, 354);
            this.averageChart.Name = "averageChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Average";
            this.averageChart.Series.Add(series1);
            this.averageChart.Size = new System.Drawing.Size(333, 280);
            this.averageChart.TabIndex = 1;
            this.averageChart.Text = "chart1";
            // 
            // topicProgressChart
            // 
            chartArea2.Name = "ChartArea1";
            this.topicProgressChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.topicProgressChart.Legends.Add(legend2);
            this.topicProgressChart.Location = new System.Drawing.Point(362, -9);
            this.topicProgressChart.Name = "topicProgressChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Scores";
            this.topicProgressChart.Series.Add(series2);
            this.topicProgressChart.Size = new System.Drawing.Size(472, 368);
            this.topicProgressChart.TabIndex = 2;
            this.topicProgressChart.Text = "chart2";
            title1.Name = "Student scores";
            this.topicProgressChart.Titles.Add(title1);
            this.topicProgressChart.Click += new System.EventHandler(this.chart2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose topic:";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(269, 176);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(72, 29);
            this.viewButton.TabIndex = 7;
            this.viewButton.Text = "Load";
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
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
            this.topicComboBox.Location = new System.Drawing.Point(136, 82);
            this.topicComboBox.Name = "topicComboBox";
            this.topicComboBox.Size = new System.Drawing.Size(208, 29);
            this.topicComboBox.TabIndex = 8;
            this.topicComboBox.SelectedIndexChanged += new System.EventHandler(this.topicComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Enter target grade:";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(25, 536);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(100, 29);
            this.enterButton.TabIndex = 10;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // targetGradeTextBox
            // 
            this.targetGradeTextBox.Location = new System.Drawing.Point(136, 498);
            this.targetGradeTextBox.Name = "targetGradeTextBox";
            this.targetGradeTextBox.Size = new System.Drawing.Size(205, 29);
            this.targetGradeTextBox.TabIndex = 11;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(136, 411);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(205, 29);
            this.subjectTextBox.TabIndex = 12;
            this.subjectTextBox.TextChanged += new System.EventHandler(this.subjectTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 414);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 13;
            this.label4.Text = "Subject:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(250, 21);
            this.label5.TabIndex = 15;
            this.label5.Text = "Probability for normal distribution:";
            // 
            // distributionLabel
            // 
            this.distributionLabel.AutoSize = true;
            this.distributionLabel.Location = new System.Drawing.Point(32, 363);
            this.distributionLabel.Name = "distributionLabel";
            this.distributionLabel.Size = new System.Drawing.Size(41, 21);
            this.distributionLabel.TabIndex = 17;
            this.distributionLabel.Text = "<P>";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 305);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 21);
            this.label9.TabIndex = 19;
            this.label9.Text = "Z score:";
            // 
            // zScoreLabel
            // 
            this.zScoreLabel.AutoSize = true;
            this.zScoreLabel.Location = new System.Drawing.Point(103, 305);
            this.zScoreLabel.Name = "zScoreLabel";
            this.zScoreLabel.Size = new System.Drawing.Size(67, 21);
            this.zScoreLabel.TabIndex = 20;
            this.zScoreLabel.Text = "<none>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(12, 225);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(143, 21);
            this.label11.TabIndex = 21;
            this.label11.Text = "Standard deviation:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(16, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 21);
            this.label12.TabIndex = 22;
            this.label12.Text = "Mean:";
            // 
            // meanLabel
            // 
            this.meanLabel.AutoSize = true;
            this.meanLabel.Location = new System.Drawing.Point(88, 180);
            this.meanLabel.Name = "meanLabel";
            this.meanLabel.Size = new System.Drawing.Size(67, 21);
            this.meanLabel.TabIndex = 23;
            this.meanLabel.Text = "<none>";
            this.meanLabel.Click += new System.EventHandler(this.meanLabel_Click);
            // 
            // standardDeviationLabel
            // 
            this.standardDeviationLabel.AutoSize = true;
            this.standardDeviationLabel.Location = new System.Drawing.Point(177, 225);
            this.standardDeviationLabel.Name = "standardDeviationLabel";
            this.standardDeviationLabel.Size = new System.Drawing.Size(67, 21);
            this.standardDeviationLabel.TabIndex = 24;
            this.standardDeviationLabel.Text = "<none>";
            // 
            // IDTextBox
            // 
            this.IDTextBox.Location = new System.Drawing.Point(136, 135);
            this.IDTextBox.Name = "IDTextBox";
            this.IDTextBox.Size = new System.Drawing.Size(208, 29);
            this.IDTextBox.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 125);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 21);
            this.label13.TabIndex = 26;
            this.label13.Text = "id:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(865, 364);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(0, 21);
            this.label14.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.varianceLabel);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.nextButton);
            this.groupBox1.Controls.Add(this.topicComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.meanLabel);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.distributionLabel);
            this.groupBox1.Controls.Add(this.standardDeviationLabel);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.enterButton);
            this.groupBox1.Controls.Add(this.IDTextBox);
            this.groupBox1.Controls.Add(this.viewButton);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.subjectTextBox);
            this.groupBox1.Controls.Add(this.zScoreLabel);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.targetGradeTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(23, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 589);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Information";
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(266, 305);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(75, 32);
            this.nextButton.TabIndex = 27;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 21);
            this.label6.TabIndex = 28;
            this.label6.Text = "Variance:";
            // 
            // varianceLabel
            // 
            this.varianceLabel.AutoSize = true;
            this.varianceLabel.Location = new System.Drawing.Point(177, 260);
            this.varianceLabel.Name = "varianceLabel";
            this.varianceLabel.Size = new System.Drawing.Size(67, 21);
            this.varianceLabel.TabIndex = 29;
            this.varianceLabel.Text = "<none>";
            // 
            // ViewScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(816, 643);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.topicProgressChart);
            this.Controls.Add(this.averageChart);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ViewScores";
            this.Text = "ViewScores";
            this.Load += new System.EventHandler(this.ViewScores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.averageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topicProgressChart)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart averageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart topicProgressChart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.ComboBox topicComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox targetGradeTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label distributionLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label zScoreLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label meanLabel;
        private System.Windows.Forms.Label standardDeviationLabel;
        private System.Windows.Forms.TextBox IDTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label varianceLabel;
        private System.Windows.Forms.Label label6;
    }
}