﻿namespace AddTwoNumbers
{
    partial class AddForm
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
            this.addButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.number1TextBox = new System.Windows.Forms.TextBox();
            this.number2TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SumTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.priviousButton = new System.Windows.Forms.Button();
            this.firstButton = new System.Windows.Forms.Button();
            this.lastButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(543, 261);
            this.addButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(112, 35);
            this.addButton.TabIndex = 0;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(434, 135);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Number1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(434, 215);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number2:";
            // 
            // number1TextBox
            // 
            this.number1TextBox.Location = new System.Drawing.Point(522, 135);
            this.number1TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.number1TextBox.Name = "number1TextBox";
            this.number1TextBox.Size = new System.Drawing.Size(148, 26);
            this.number1TextBox.TabIndex = 4;
            // 
            // number2TextBox
            // 
            this.number2TextBox.Location = new System.Drawing.Point(522, 211);
            this.number2TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.number2TextBox.Name = "number2TextBox";
            this.number2TextBox.Size = new System.Drawing.Size(148, 26);
            this.number2TextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 322);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Sum:";
            // 
            // SumTextBox
            // 
            this.SumTextBox.Location = new System.Drawing.Point(522, 322);
            this.SumTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SumTextBox.Name = "SumTextBox";
            this.SumTextBox.Size = new System.Drawing.Size(148, 26);
            this.SumTextBox.TabIndex = 7;
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(802, 448);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(150, 45);
            this.nextButton.TabIndex = 9;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // priviousButton
            // 
            this.priviousButton.Location = new System.Drawing.Point(242, 450);
            this.priviousButton.Name = "priviousButton";
            this.priviousButton.Size = new System.Drawing.Size(175, 45);
            this.priviousButton.TabIndex = 10;
            this.priviousButton.Text = "Privious";
            this.priviousButton.UseVisualStyleBackColor = true;
            this.priviousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // firstButton
            // 
            this.firstButton.Location = new System.Drawing.Point(438, 450);
            this.firstButton.Name = "firstButton";
            this.firstButton.Size = new System.Drawing.Size(140, 45);
            this.firstButton.TabIndex = 11;
            this.firstButton.Text = "First";
            this.firstButton.UseVisualStyleBackColor = true;
            this.firstButton.Click += new System.EventHandler(this.firstButton_Click);
            // 
            // lastButton
            // 
            this.lastButton.Location = new System.Drawing.Point(615, 450);
            this.lastButton.Name = "lastButton";
            this.lastButton.Size = new System.Drawing.Size(143, 43);
            this.lastButton.TabIndex = 12;
            this.lastButton.Text = "Last";
            this.lastButton.UseVisualStyleBackColor = true;
            this.lastButton.Click += new System.EventHandler(this.lastButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(543, 389);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(112, 38);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.lastButton);
            this.Controls.Add(this.firstButton);
            this.Controls.Add(this.priviousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.SumTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.number2TextBox);
            this.Controls.Add(this.number1TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox number1TextBox;
        private System.Windows.Forms.TextBox number2TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SumTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button priviousButton;
        private System.Windows.Forms.Button firstButton;
        private System.Windows.Forms.Button lastButton;
        private System.Windows.Forms.Button saveButton;
    }
}

