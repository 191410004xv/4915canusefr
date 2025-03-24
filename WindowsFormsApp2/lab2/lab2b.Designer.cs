namespace WindowsFormsApp2
{
    partial class lab2b
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(lab2b));
            this.name = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sunny = new System.Windows.Forms.RadioButton();
            this.rainy = new System.Windows.Forms.RadioButton();
            this.cloudy = new System.Windows.Forms.RadioButton();
            this.pic_cloudy = new System.Windows.Forms.PictureBox();
            this.pic_rainy = new System.Windows.Forms.PictureBox();
            this.pic_sunny = new System.Windows.Forms.PictureBox();
            this.pic_snow = new System.Windows.Forms.PictureBox();
            this.snowy = new System.Windows.Forms.RadioButton();
            this.label_result = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cloudy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rainy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sunny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_snow)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(85, 49);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(107, 13);
            this.name.TabIndex = 0;
            this.name.Text = "enter your name here";
            this.name.Click += new System.EventHandler(this.name_Click);
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(226, 49);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(244, 20);
            this.txtname.TabIndex = 1;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.snowy);
            this.groupBox1.Controls.Add(this.sunny);
            this.groupBox1.Controls.Add(this.rainy);
            this.groupBox1.Controls.Add(this.cloudy);
            this.groupBox1.Location = new System.Drawing.Point(82, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 236);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "choose";
            // 
            // sunny
            // 
            this.sunny.AutoSize = true;
            this.sunny.Location = new System.Drawing.Point(26, 160);
            this.sunny.Name = "sunny";
            this.sunny.Size = new System.Drawing.Size(55, 17);
            this.sunny.TabIndex = 4;
            this.sunny.TabStop = true;
            this.sunny.Text = "Sunny";
            this.sunny.UseVisualStyleBackColor = true;
            this.sunny.CheckedChanged += new System.EventHandler(this.sunny_CheckedChanged);
            // 
            // rainy
            // 
            this.rainy.AutoSize = true;
            this.rainy.Location = new System.Drawing.Point(26, 87);
            this.rainy.Name = "rainy";
            this.rainy.Size = new System.Drawing.Size(52, 17);
            this.rainy.TabIndex = 1;
            this.rainy.TabStop = true;
            this.rainy.Text = "Rainy";
            this.rainy.UseVisualStyleBackColor = true;
            this.rainy.CheckedChanged += new System.EventHandler(this.rainy_CheckedChanged);
            // 
            // cloudy
            // 
            this.cloudy.AutoSize = true;
            this.cloudy.Location = new System.Drawing.Point(26, 53);
            this.cloudy.Name = "cloudy";
            this.cloudy.Size = new System.Drawing.Size(57, 17);
            this.cloudy.TabIndex = 0;
            this.cloudy.TabStop = true;
            this.cloudy.Text = "Cloudy";
            this.cloudy.UseVisualStyleBackColor = true;
            this.cloudy.CheckedChanged += new System.EventHandler(this.cloudy_CheckedChanged);
            // 
            // pic_cloudy
            // 
            this.pic_cloudy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pic_cloudy.Image = ((System.Drawing.Image)(resources.GetObject("pic_cloudy.Image")));
            this.pic_cloudy.Location = new System.Drawing.Point(460, 159);
            this.pic_cloudy.Name = "pic_cloudy";
            this.pic_cloudy.Size = new System.Drawing.Size(64, 64);
            this.pic_cloudy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_cloudy.TabIndex = 3;
            this.pic_cloudy.TabStop = false;
            // 
            // pic_rainy
            // 
            this.pic_rainy.Image = ((System.Drawing.Image)(resources.GetObject("pic_rainy.Image")));
            this.pic_rainy.Location = new System.Drawing.Point(530, 159);
            this.pic_rainy.Name = "pic_rainy";
            this.pic_rainy.Size = new System.Drawing.Size(64, 64);
            this.pic_rainy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_rainy.TabIndex = 4;
            this.pic_rainy.TabStop = false;
            this.pic_rainy.Click += new System.EventHandler(this.pic_rainy_Click);
            // 
            // pic_sunny
            // 
            this.pic_sunny.Image = ((System.Drawing.Image)(resources.GetObject("pic_sunny.Image")));
            this.pic_sunny.Location = new System.Drawing.Point(460, 229);
            this.pic_sunny.Name = "pic_sunny";
            this.pic_sunny.Size = new System.Drawing.Size(64, 64);
            this.pic_sunny.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_sunny.TabIndex = 5;
            this.pic_sunny.TabStop = false;
            // 
            // pic_snow
            // 
            this.pic_snow.Image = ((System.Drawing.Image)(resources.GetObject("pic_snow.Image")));
            this.pic_snow.Location = new System.Drawing.Point(530, 229);
            this.pic_snow.Name = "pic_snow";
            this.pic_snow.Size = new System.Drawing.Size(64, 64);
            this.pic_snow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pic_snow.TabIndex = 6;
            this.pic_snow.TabStop = false;
            this.pic_snow.Click += new System.EventHandler(this.pic_snow_Click);
            // 
            // snowy
            // 
            this.snowy.AutoSize = true;
            this.snowy.Location = new System.Drawing.Point(26, 122);
            this.snowy.Name = "snowy";
            this.snowy.Size = new System.Drawing.Size(55, 17);
            this.snowy.TabIndex = 5;
            this.snowy.TabStop = true;
            this.snowy.Text = "snowy";
            this.snowy.UseVisualStyleBackColor = true;
            this.snowy.CheckedChanged += new System.EventHandler(this.snowy_CheckedChanged);
            // 
            // label_result
            // 
            this.label_result.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label_result.Location = new System.Drawing.Point(70, 370);
            this.label_result.Name = "label_result";
            this.label_result.Size = new System.Drawing.Size(621, 61);
            this.label_result.TabIndex = 7;
            this.label_result.Click += new System.EventHandler(this.label_result_Click);
            // 
            // lab2b
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_result);
            this.Controls.Add(this.pic_snow);
            this.Controls.Add(this.pic_sunny);
            this.Controls.Add(this.pic_rainy);
            this.Controls.Add(this.pic_cloudy);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.name);
            this.Name = "lab2b";
            this.Text = "lab2b";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_cloudy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_rainy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_sunny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_snow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rainy;
        private System.Windows.Forms.RadioButton cloudy;
        private System.Windows.Forms.RadioButton sunny;
        private System.Windows.Forms.PictureBox pic_cloudy;
        private System.Windows.Forms.PictureBox pic_sunny;
        private System.Windows.Forms.PictureBox pic_snow;
        private System.Windows.Forms.RadioButton snowy;
        private System.Windows.Forms.Label label_result;
        private System.Windows.Forms.PictureBox pic_rainy;
    }
}