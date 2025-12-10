namespace Project
{
    partial class ParentCredentials
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
            this.addressLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.NoofKidsTextBox = new System.Windows.Forms.TextBox();
            this.postcodeTextBox = new System.Windows.Forms.TextBox();
            this.nameChildTextBox = new System.Windows.Forms.TextBox();
            this.saveParentDetailsButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(100, 48);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(66, 21);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of kids";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Postcode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Name of children";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(52, 87);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(174, 29);
            this.addressTextBox.TabIndex = 4;
            // 
            // NoofKidsTextBox
            // 
            this.NoofKidsTextBox.Location = new System.Drawing.Point(52, 172);
            this.NoofKidsTextBox.Name = "NoofKidsTextBox";
            this.NoofKidsTextBox.Size = new System.Drawing.Size(174, 29);
            this.NoofKidsTextBox.TabIndex = 5;
            // 
            // postcodeTextBox
            // 
            this.postcodeTextBox.Location = new System.Drawing.Point(52, 254);
            this.postcodeTextBox.Name = "postcodeTextBox";
            this.postcodeTextBox.Size = new System.Drawing.Size(174, 29);
            this.postcodeTextBox.TabIndex = 6;
            // 
            // nameChildTextBox
            // 
            this.nameChildTextBox.Location = new System.Drawing.Point(52, 336);
            this.nameChildTextBox.Name = "nameChildTextBox";
            this.nameChildTextBox.Size = new System.Drawing.Size(174, 29);
            this.nameChildTextBox.TabIndex = 7;
            // 
            // saveParentDetailsButton
            // 
            this.saveParentDetailsButton.Location = new System.Drawing.Point(298, 290);
            this.saveParentDetailsButton.Name = "saveParentDetailsButton";
            this.saveParentDetailsButton.Size = new System.Drawing.Size(123, 75);
            this.saveParentDetailsButton.TabIndex = 8;
            this.saveParentDetailsButton.Text = "Save credentials ";
            this.saveParentDetailsButton.UseVisualStyleBackColor = true;
            this.saveParentDetailsButton.Click += new System.EventHandler(this.saveParentDetailsButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(318, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Parent details";
            // 
            // parentCredentials
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(488, 410);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.saveParentDetailsButton);
            this.Controls.Add(this.nameChildTextBox);
            this.Controls.Add(this.postcodeTextBox);
            this.Controls.Add(this.NoofKidsTextBox);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addressLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "parentCredentials";
            this.Text = "Please enter your details";
            this.Load += new System.EventHandler(this.ParentLoggedin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox NoofKidsTextBox;
        private System.Windows.Forms.TextBox postcodeTextBox;
        private System.Windows.Forms.TextBox nameChildTextBox;
        private System.Windows.Forms.Button saveParentDetailsButton;
        private System.Windows.Forms.Label label4;
    }
}