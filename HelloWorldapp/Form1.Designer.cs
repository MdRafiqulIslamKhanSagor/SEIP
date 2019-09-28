namespace HelloWorldapp
{
    partial class Form1
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
            this.divNumber = new System.Windows.Forms.Button();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.secoundNumberTextBox = new System.Windows.Forms.TextBox();
            this.showResultBox = new System.Windows.Forms.TextBox();
            this.subNumber = new System.Windows.Forms.Button();
            this.addNumber = new System.Windows.Forms.Button();
            this.mulNumber = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // divNumber
            // 
            this.divNumber.Location = new System.Drawing.Point(495, 137);
            this.divNumber.Name = "divNumber";
            this.divNumber.Size = new System.Drawing.Size(61, 31);
            this.divNumber.TabIndex = 0;
            this.divNumber.Text = "Div";
            this.divNumber.UseVisualStyleBackColor = true;
            this.divNumber.Click += new System.EventHandler(this.divNumber_Click);
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(183, 46);
            this.firstNumberTextBox.Multiline = true;
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(375, 31);
            this.firstNumberTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Insert First Number : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Insert Secound Number: ";
            // 
            // secoundNumberTextBox
            // 
            this.secoundNumberTextBox.Location = new System.Drawing.Point(183, 95);
            this.secoundNumberTextBox.Multiline = true;
            this.secoundNumberTextBox.Name = "secoundNumberTextBox";
            this.secoundNumberTextBox.Size = new System.Drawing.Size(375, 36);
            this.secoundNumberTextBox.TabIndex = 4;
            // 
            // showResultBox
            // 
            this.showResultBox.Location = new System.Drawing.Point(183, 186);
            this.showResultBox.Multiline = true;
            this.showResultBox.Name = "showResultBox";
            this.showResultBox.Size = new System.Drawing.Size(375, 41);
            this.showResultBox.TabIndex = 5;
            // 
            // subNumber
            // 
            this.subNumber.Location = new System.Drawing.Point(361, 137);
            this.subNumber.Name = "subNumber";
            this.subNumber.Size = new System.Drawing.Size(61, 31);
            this.subNumber.TabIndex = 6;
            this.subNumber.Text = "Sub";
            this.subNumber.UseVisualStyleBackColor = true;
            this.subNumber.Click += new System.EventHandler(this.subNumber_Click);
            // 
            // addNumber
            // 
            this.addNumber.Location = new System.Drawing.Point(281, 137);
            this.addNumber.Name = "addNumber";
            this.addNumber.Size = new System.Drawing.Size(61, 31);
            this.addNumber.TabIndex = 7;
            this.addNumber.Text = "Add";
            this.addNumber.UseVisualStyleBackColor = true;
            this.addNumber.Click += new System.EventHandler(this.addNumber_Click);
            // 
            // mulNumber
            // 
            this.mulNumber.Location = new System.Drawing.Point(428, 137);
            this.mulNumber.Name = "mulNumber";
            this.mulNumber.Size = new System.Drawing.Size(61, 31);
            this.mulNumber.TabIndex = 8;
            this.mulNumber.Text = "Mul";
            this.mulNumber.UseVisualStyleBackColor = true;
            this.mulNumber.Click += new System.EventHandler(this.mulNumber_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result : ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(573, 257);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mulNumber);
            this.Controls.Add(this.addNumber);
            this.Controls.Add(this.subNumber);
            this.Controls.Add(this.showResultBox);
            this.Controls.Add(this.secoundNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.divNumber);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button divNumber;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox secoundNumberTextBox;
        private System.Windows.Forms.TextBox showResultBox;
        private System.Windows.Forms.Button subNumber;
        private System.Windows.Forms.Button addNumber;
        private System.Windows.Forms.Button mulNumber;
        private System.Windows.Forms.Label label3;
    }
}

