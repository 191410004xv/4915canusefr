namespace WindowsFormsApp2.lab3
{
    partial class Formlab3b
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.lblRate = new System.Windows.Forms.Label();
            this.lblValue = new System.Windows.Forms.Label();
            this.lblMillion = new System.Windows.Forms.Label();
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_IR = new System.Windows.Forms.TextBox();
            this.lbl_10years = new System.Windows.Forms.Label();
            this.lblMillion2 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.percentage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(88, 61);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(43, 13);
            this.lblAmount.TabIndex = 0;
            this.lblAmount.Text = "Amount\t";
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Location = new System.Drawing.Point(87, 117);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(110, 13);
            this.lblRate.TabIndex = 1;
            this.lblRate.Text = "Interest Rate (Annual)";
            // 
            // lblValue
            // 
            this.lblValue.AutoSize = true;
            this.lblValue.Location = new System.Drawing.Point(91, 219);
            this.lblValue.Name = "lblValue";
            this.lblValue.Size = new System.Drawing.Size(101, 13);
            this.lblValue.TabIndex = 2;
            this.lblValue.Text = "Value after 10 years";
            // 
            // lblMillion
            // 
            this.lblMillion.AutoSize = true;
            this.lblMillion.Location = new System.Drawing.Point(91, 291);
            this.lblMillion.Name = "lblMillion";
            this.lblMillion.Size = new System.Drawing.Size(100, 13);
            this.lblMillion.TabIndex = 3;
            this.lblMillion.Text = "Years to reach $1M";
            // 
            // txt_Amount
            // 
            this.txt_Amount.Location = new System.Drawing.Point(285, 61);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(138, 20);
            this.txt_Amount.TabIndex = 4;
            this.txt_Amount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_IR
            // 
            this.txt_IR.Location = new System.Drawing.Point(285, 114);
            this.txt_IR.Name = "txt_IR";
            this.txt_IR.Size = new System.Drawing.Size(138, 20);
            this.txt_IR.TabIndex = 5;
            // 
            // lbl_10years
            // 
            this.lbl_10years.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_10years.Location = new System.Drawing.Point(282, 219);
            this.lbl_10years.Name = "lbl_10years";
            this.lbl_10years.Size = new System.Drawing.Size(141, 31);
            this.lbl_10years.TabIndex = 6;
            this.lbl_10years.Click += new System.EventHandler(this.lblValue2_Click);
            // 
            // lblMillion2
            // 
            this.lblMillion2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMillion2.Location = new System.Drawing.Point(282, 291);
            this.lblMillion2.Name = "lblMillion2";
            this.lblMillion2.Size = new System.Drawing.Size(141, 41);
            this.lblMillion2.TabIndex = 7;
            this.lblMillion2.Click += new System.EventHandler(this.lblMillion2_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(94, 160);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(286, 35);
            this.btnCalculate.TabIndex = 8;
            this.btnCalculate.Text = "Start Calculation";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // percentage
            // 
            this.percentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage.Location = new System.Drawing.Point(441, 114);
            this.percentage.Name = "percentage";
            this.percentage.Size = new System.Drawing.Size(20, 20);
            this.percentage.TabIndex = 9;
            this.percentage.Text = "%";
            // 
            // Formlab3b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.percentage);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblMillion2);
            this.Controls.Add(this.lbl_10years);
            this.Controls.Add(this.txt_IR);
            this.Controls.Add(this.txt_Amount);
            this.Controls.Add(this.lblMillion);
            this.Controls.Add(this.lblValue);
            this.Controls.Add(this.lblRate);
            this.Controls.Add(this.lblAmount);
            this.Name = "Formlab3b";
            this.Text = "Compound Interest";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.Label lblValue;
        private System.Windows.Forms.Label lblMillion;
        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_IR;
        private System.Windows.Forms.Label lbl_10years;
        private System.Windows.Forms.Label lblMillion2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label percentage;
    }
}