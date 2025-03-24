namespace WindowsFormsApp2.lab2
{
    partial class Formlab2a
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
            this.label1 = new System.Windows.Forms.Label();
            this.redwine = new System.Windows.Forms.RadioButton();
            this.whitewine = new System.Windows.Forms.RadioButton();
            this.beer = new System.Windows.Forms.RadioButton();
            this.visa = new System.Windows.Forms.RadioButton();
            this.mastercard = new System.Windows.Forms.RadioButton();
            this.winelist = new System.Windows.Forms.GroupBox();
            this.paymentmed = new System.Windows.Forms.GroupBox();
            this.cal = new System.Windows.Forms.Button();
            this.lbnresult = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.TextBox();
            this.winelist.SuspendLayout();
            this.paymentmed.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "QTY";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // redwine
            // 
            this.redwine.AutoSize = true;
            this.redwine.Location = new System.Drawing.Point(47, 33);
            this.redwine.Name = "redwine";
            this.redwine.Size = new System.Drawing.Size(109, 17);
            this.redwine.TabIndex = 1;
            this.redwine.TabStop = true;
            this.redwine.Text = "Red winde ($250)";
            this.redwine.UseVisualStyleBackColor = true;
            this.redwine.CheckedChanged += new System.EventHandler(this.redwine_CheckedChanged);
            // 
            // whitewine
            // 
            this.whitewine.AutoSize = true;
            this.whitewine.Location = new System.Drawing.Point(47, 57);
            this.whitewine.Name = "whitewine";
            this.whitewine.Size = new System.Drawing.Size(105, 17);
            this.whitewine.TabIndex = 2;
            this.whitewine.TabStop = true;
            this.whitewine.Text = "white wine($180)";
            this.whitewine.UseVisualStyleBackColor = true;
            this.whitewine.CheckedChanged += new System.EventHandler(this.whitewine_CheckedChanged_1);
            // 
            // beer
            // 
            this.beer.AutoSize = true;
            this.beer.Location = new System.Drawing.Point(47, 81);
            this.beer.Name = "beer";
            this.beer.Size = new System.Drawing.Size(118, 17);
            this.beer.TabIndex = 3;
            this.beer.TabStop = true;
            this.beer.Text = "Beer (1dozen) ($75)";
            this.beer.UseVisualStyleBackColor = true;
            this.beer.CheckedChanged += new System.EventHandler(this.beer_CheckedChanged);
            // 
            // visa
            // 
            this.visa.AutoSize = true;
            this.visa.Location = new System.Drawing.Point(16, 22);
            this.visa.Name = "visa";
            this.visa.Size = new System.Drawing.Size(49, 17);
            this.visa.TabIndex = 4;
            this.visa.TabStop = true;
            this.visa.Text = "VISA";
            this.visa.UseVisualStyleBackColor = true;
            this.visa.CheckedChanged += new System.EventHandler(this.visa_CheckedChanged);
            // 
            // mastercard
            // 
            this.mastercard.AutoSize = true;
            this.mastercard.BackColor = System.Drawing.SystemColors.Control;
            this.mastercard.Location = new System.Drawing.Point(16, 46);
            this.mastercard.Name = "mastercard";
            this.mastercard.Size = new System.Drawing.Size(79, 17);
            this.mastercard.TabIndex = 5;
            this.mastercard.TabStop = true;
            this.mastercard.Text = "MasterCard";
            this.mastercard.UseVisualStyleBackColor = false;
            this.mastercard.CheckedChanged += new System.EventHandler(this.mastercard_CheckedChanged);
            // 
            // winelist
            // 
            this.winelist.Controls.Add(this.beer);
            this.winelist.Controls.Add(this.whitewine);
            this.winelist.Controls.Add(this.redwine);
            this.winelist.Location = new System.Drawing.Point(122, 104);
            this.winelist.Name = "winelist";
            this.winelist.Size = new System.Drawing.Size(217, 157);
            this.winelist.TabIndex = 6;
            this.winelist.TabStop = false;
            this.winelist.Text = "Winelist";
            // 
            // paymentmed
            // 
            this.paymentmed.Controls.Add(this.mastercard);
            this.paymentmed.Controls.Add(this.visa);
            this.paymentmed.Location = new System.Drawing.Point(461, 104);
            this.paymentmed.Name = "paymentmed";
            this.paymentmed.Size = new System.Drawing.Size(200, 115);
            this.paymentmed.TabIndex = 7;
            this.paymentmed.TabStop = false;
            this.paymentmed.Text = "payment method";
            // 
            // cal
            // 
            this.cal.Location = new System.Drawing.Point(624, 245);
            this.cal.Name = "cal";
            this.cal.Size = new System.Drawing.Size(75, 23);
            this.cal.TabIndex = 8;
            this.cal.Text = "calculate";
            this.cal.UseVisualStyleBackColor = true;
            this.cal.Click += new System.EventHandler(this.cal_Click);
            // 
            // lbnresult
            // 
            this.lbnresult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbnresult.Location = new System.Drawing.Point(95, 320);
            this.lbnresult.Name = "lbnresult";
            this.lbnresult.Size = new System.Drawing.Size(637, 96);
            this.lbnresult.TabIndex = 9;
            this.lbnresult.Click += new System.EventHandler(this.lbnresult_Click);
            // 
            // qty
            // 
            this.qty.Location = new System.Drawing.Point(514, 248);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(85, 20);
            this.qty.TabIndex = 10;
            this.qty.TextChanged += new System.EventHandler(this.qty_TextChanged);
            // 
            // Formlab2a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.lbnresult);
            this.Controls.Add(this.cal);
            this.Controls.Add(this.paymentmed);
            this.Controls.Add(this.winelist);
            this.Controls.Add(this.label1);
            this.Name = "Formlab2a";
            this.Text = "Formlab2a";
            this.winelist.ResumeLayout(false);
            this.winelist.PerformLayout();
            this.paymentmed.ResumeLayout(false);
            this.paymentmed.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton redwine;
        private System.Windows.Forms.RadioButton whitewine;
        private System.Windows.Forms.RadioButton beer;
        private System.Windows.Forms.RadioButton visa;
        private System.Windows.Forms.RadioButton mastercard;
        private System.Windows.Forms.GroupBox winelist;
        private System.Windows.Forms.GroupBox paymentmed;
        private System.Windows.Forms.Button cal;
        private System.Windows.Forms.Label lbnresult;
        private System.Windows.Forms.TextBox qty;
    }
}