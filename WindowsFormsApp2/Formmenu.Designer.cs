namespace WindowsFormsApp2
{
    partial class Formmenu
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
            this.cboLabs = new System.Windows.Forms.ComboBox();
            this.btnopen = new System.Windows.Forms.Button();
            this.labellab = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboLabs
            // 
            this.cboLabs.FormattingEnabled = true;
            this.cboLabs.Location = new System.Drawing.Point(62, 114);
            this.cboLabs.Name = "cboLabs";
            this.cboLabs.Size = new System.Drawing.Size(298, 21);
            this.cboLabs.TabIndex = 0;
            this.cboLabs.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(176, 267);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 1;
            this.btnopen.Text = "Open";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.Click += new System.EventHandler(this.btnopen_Click);
            // 
            // labellab
            // 
            this.labellab.AutoSize = true;
            this.labellab.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labellab.Location = new System.Drawing.Point(58, 34);
            this.labellab.Name = "labellab";
            this.labellab.Size = new System.Drawing.Size(65, 19);
            this.labellab.TabIndex = 2;
            this.labellab.Text = "SDP labs";
            // 
            // Formmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 388);
            this.Controls.Add(this.labellab);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.cboLabs);
            this.Name = "Formmenu";
            this.Text = "Formmenu";
            this.Load += new System.EventHandler(this.Formmenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboLabs;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Label labellab;
    }
}