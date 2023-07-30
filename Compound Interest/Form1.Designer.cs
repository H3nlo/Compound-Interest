
namespace Prac6_Interest_37279432
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AmountInvestedInput = new System.Windows.Forms.TextBox();
            this.YearsInvestedInput = new System.Windows.Forms.TextBox();
            this.InterestRateInput = new System.Windows.Forms.TextBox();
            this.lbOutput = new System.Windows.Forms.ListBox();
            this.Calculatebtn = new System.Windows.Forms.Button();
            this.Exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initail amount invested:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Years invested:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "Interest rate:";
            // 
            // AmountInvestedInput
            // 
            this.AmountInvestedInput.Location = new System.Drawing.Point(264, 29);
            this.AmountInvestedInput.Name = "AmountInvestedInput";
            this.AmountInvestedInput.Size = new System.Drawing.Size(180, 30);
            this.AmountInvestedInput.TabIndex = 1;
            // 
            // YearsInvestedInput
            // 
            this.YearsInvestedInput.Location = new System.Drawing.Point(264, 80);
            this.YearsInvestedInput.Name = "YearsInvestedInput";
            this.YearsInvestedInput.Size = new System.Drawing.Size(180, 30);
            this.YearsInvestedInput.TabIndex = 2;
            // 
            // InterestRateInput
            // 
            this.InterestRateInput.Location = new System.Drawing.Point(264, 138);
            this.InterestRateInput.Name = "InterestRateInput";
            this.InterestRateInput.Size = new System.Drawing.Size(180, 30);
            this.InterestRateInput.TabIndex = 3;
            // 
            // lbOutput
            // 
            this.lbOutput.FormattingEnabled = true;
            this.lbOutput.ItemHeight = 23;
            this.lbOutput.Location = new System.Drawing.Point(39, 197);
            this.lbOutput.Name = "lbOutput";
            this.lbOutput.Size = new System.Drawing.Size(405, 211);
            this.lbOutput.TabIndex = 6;
            // 
            // Calculatebtn
            // 
            this.Calculatebtn.Location = new System.Drawing.Point(75, 436);
            this.Calculatebtn.Name = "Calculatebtn";
            this.Calculatebtn.Size = new System.Drawing.Size(124, 41);
            this.Calculatebtn.TabIndex = 4;
            this.Calculatebtn.Text = "Calculate";
            this.Calculatebtn.UseVisualStyleBackColor = true;
            this.Calculatebtn.Click += new System.EventHandler(this.Calculatebtn_Click);
            // 
            // Exitbtn
            // 
            this.Exitbtn.Location = new System.Drawing.Point(264, 436);
            this.Exitbtn.Name = "Exitbtn";
            this.Exitbtn.Size = new System.Drawing.Size(124, 41);
            this.Exitbtn.TabIndex = 8;
            this.Exitbtn.Text = "Exit";
            this.Exitbtn.UseVisualStyleBackColor = true;
            this.Exitbtn.Click += new System.EventHandler(this.Exitbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 518);
            this.Controls.Add(this.Exitbtn);
            this.Controls.Add(this.Calculatebtn);
            this.Controls.Add(this.lbOutput);
            this.Controls.Add(this.InterestRateInput);
            this.Controls.Add(this.YearsInvestedInput);
            this.Controls.Add(this.AmountInvestedInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AmountInvestedInput;
        private System.Windows.Forms.TextBox YearsInvestedInput;
        private System.Windows.Forms.TextBox InterestRateInput;
        private System.Windows.Forms.ListBox lbOutput;
        private System.Windows.Forms.Button Calculatebtn;
        private System.Windows.Forms.Button Exitbtn;
    }
}

