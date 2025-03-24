namespace WindowsFormsApp2.lab3
{
    partial class Formlab3a
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
            this.btnCast = new System.Windows.Forms.Button();
            this.cboMovie = new System.Windows.Forms.ComboBox();
            this.lblCast = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCast
            // 
            this.btnCast.Location = new System.Drawing.Point(349, 295);
            this.btnCast.Name = "btnCast";
            this.btnCast.Size = new System.Drawing.Size(105, 33);
            this.btnCast.TabIndex = 0;
            this.btnCast.Text = "Cast your vote";
            this.btnCast.UseCompatibleTextRendering = true;
            this.btnCast.UseVisualStyleBackColor = true;
            this.btnCast.Click += new System.EventHandler(this.btnCast_Click);
            // 
            // cboMovie
            // 
            this.cboMovie.FormattingEnabled = true;
            this.cboMovie.Items.AddRange(new object[] {
            "The Godfather",
            "Terminator",
            "Back to the Future",
            "Matrix"});
            this.cboMovie.Location = new System.Drawing.Point(304, 193);
            this.cboMovie.Name = "cboMovie";
            this.cboMovie.Size = new System.Drawing.Size(196, 21);
            this.cboMovie.TabIndex = 1;
            this.cboMovie.Text = "DropDown";
            this.cboMovie.SelectedIndexChanged += new System.EventHandler(this.cboMovie_SelectedIndexChanged);
            // 
            // lblCast
            // 
            this.lblCast.AutoSize = true;
            this.lblCast.Location = new System.Drawing.Point(323, 80);
            this.lblCast.Name = "lblCast";
            this.lblCast.Size = new System.Drawing.Size(157, 13);
            this.lblCast.TabIndex = 2;
            this.lblCast.Text = "My Choice of Best Movie Series";
            this.lblCast.Click += new System.EventHandler(this.lblCast_Click);
            // 
            // Formlab3a
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblCast);
            this.Controls.Add(this.cboMovie);
            this.Controls.Add(this.btnCast);
            this.Name = "Formlab3a";
            this.Text = "Formab3a";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCast;
        private System.Windows.Forms.ComboBox cboMovie;
        private System.Windows.Forms.Label lblCast;
    }
}