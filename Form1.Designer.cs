
namespace TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Fact_Number_TextBox = new System.Windows.Forms.TextBox();
            this.Fact_Result_TextBox = new System.Windows.Forms.TextBox();
            this.Fact_Result_Button = new System.Windows.Forms.Button();
            this.Prime_Number_TextBox = new System.Windows.Forms.TextBox();
            this.Prime_Result_TextBox = new System.Windows.Forms.TextBox();
            this.Prime_Result_Button = new System.Windows.Forms.Button();
            this.Fib_Result_Button = new System.Windows.Forms.Button();
            this.Fib_Number_TextBox = new System.Windows.Forms.TextBox();
            this.Fib_Result_TextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(490, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Fact_Result_Button);
            this.tabPage1.Controls.Add(this.Fact_Result_TextBox);
            this.tabPage1.Controls.Add(this.Fact_Number_TextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(482, 305);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Fact";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Prime_Result_Button);
            this.tabPage2.Controls.Add(this.Prime_Result_TextBox);
            this.tabPage2.Controls.Add(this.Prime_Number_TextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(482, 305);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Prime Number";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.Fib_Result_TextBox);
            this.tabPage3.Controls.Add(this.Fib_Number_TextBox);
            this.tabPage3.Controls.Add(this.Fib_Result_Button);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(482, 305);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Fib";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Fact_Number_TextBox
            // 
            this.Fact_Number_TextBox.Location = new System.Drawing.Point(108, 47);
            this.Fact_Number_TextBox.Name = "Fact_Number_TextBox";
            this.Fact_Number_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Fact_Number_TextBox.TabIndex = 0;
            this.Fact_Number_TextBox.TextChanged += new System.EventHandler(this.Fact_Number_TextBox_TextChanged);
            // 
            // Fact_Result_TextBox
            // 
            this.Fact_Result_TextBox.Location = new System.Drawing.Point(108, 128);
            this.Fact_Result_TextBox.Name = "Fact_Result_TextBox";
            this.Fact_Result_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Fact_Result_TextBox.TabIndex = 1;
            // 
            // Fact_Result_Button
            // 
            this.Fact_Result_Button.Location = new System.Drawing.Point(108, 209);
            this.Fact_Result_Button.Name = "Fact_Result_Button";
            this.Fact_Result_Button.Size = new System.Drawing.Size(75, 23);
            this.Fact_Result_Button.TabIndex = 2;
            this.Fact_Result_Button.Text = "Result";
            this.Fact_Result_Button.UseVisualStyleBackColor = true;
            this.Fact_Result_Button.Click += new System.EventHandler(this.Fact_Result_Button_Click);
            // 
            // Prime_Number_TextBox
            // 
            this.Prime_Number_TextBox.Location = new System.Drawing.Point(118, 47);
            this.Prime_Number_TextBox.Name = "Prime_Number_TextBox";
            this.Prime_Number_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Prime_Number_TextBox.TabIndex = 1;
            // 
            // Prime_Result_TextBox
            // 
            this.Prime_Result_TextBox.Location = new System.Drawing.Point(118, 111);
            this.Prime_Result_TextBox.Name = "Prime_Result_TextBox";
            this.Prime_Result_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Prime_Result_TextBox.TabIndex = 2;
            // 
            // Prime_Result_Button
            // 
            this.Prime_Result_Button.Location = new System.Drawing.Point(118, 175);
            this.Prime_Result_Button.Name = "Prime_Result_Button";
            this.Prime_Result_Button.Size = new System.Drawing.Size(75, 23);
            this.Prime_Result_Button.TabIndex = 3;
            this.Prime_Result_Button.Text = "Result";
            this.Prime_Result_Button.UseVisualStyleBackColor = true;
            this.Prime_Result_Button.Click += new System.EventHandler(this.Prime_Result_Button_Click);
            // 
            // Fib_Result_Button
            // 
            this.Fib_Result_Button.Location = new System.Drawing.Point(119, 141);
            this.Fib_Result_Button.Name = "Fib_Result_Button";
            this.Fib_Result_Button.Size = new System.Drawing.Size(75, 23);
            this.Fib_Result_Button.TabIndex = 4;
            this.Fib_Result_Button.Text = "Result";
            this.Fib_Result_Button.UseVisualStyleBackColor = true;
            this.Fib_Result_Button.Click += new System.EventHandler(this.Fib_Result_Button_Click);
            // 
            // Fib_Number_TextBox
            // 
            this.Fib_Number_TextBox.Location = new System.Drawing.Point(119, 39);
            this.Fib_Number_TextBox.Name = "Fib_Number_TextBox";
            this.Fib_Number_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Fib_Number_TextBox.TabIndex = 5;
            // 
            // Fib_Result_TextBox
            // 
            this.Fib_Result_TextBox.Location = new System.Drawing.Point(119, 88);
            this.Fib_Result_TextBox.Name = "Fib_Result_TextBox";
            this.Fib_Result_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Fib_Result_TextBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 370);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button Fact_Result_Button;
        private System.Windows.Forms.TextBox Fact_Result_TextBox;
        private System.Windows.Forms.TextBox Fact_Number_TextBox;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button Prime_Result_Button;
        private System.Windows.Forms.TextBox Prime_Result_TextBox;
        private System.Windows.Forms.TextBox Prime_Number_TextBox;
        private System.Windows.Forms.Button Fib_Result_Button;
        private System.Windows.Forms.TextBox Fib_Result_TextBox;
        private System.Windows.Forms.TextBox Fib_Number_TextBox;
    }
}

