namespace WindowsFormsApp2.lab3
{
    partial class Formlab3c
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
            this.but_arrow_right = new System.Windows.Forms.Button();
            this.but_arrow_left = new System.Windows.Forms.Button();
            this.lbl_add = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lit_Shop = new System.Windows.Forms.ListBox();
            this.lit_cart = new System.Windows.Forms.ListBox();
            this.but_addfruit = new System.Windows.Forms.Button();
            this.but_shopcart = new System.Windows.Forms.Button();
            this.but_clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // but_arrow_right
            // 
            this.but_arrow_right.Location = new System.Drawing.Point(353, 112);
            this.but_arrow_right.Name = "but_arrow_right";
            this.but_arrow_right.Size = new System.Drawing.Size(66, 22);
            this.but_arrow_right.TabIndex = 2;
            this.but_arrow_right.Text = "---->";
            this.but_arrow_right.UseVisualStyleBackColor = true;
            this.but_arrow_right.Click += new System.EventHandler(this.but_arrow_right_Click);
            // 
            // but_arrow_left
            // 
            this.but_arrow_left.Location = new System.Drawing.Point(348, 189);
            this.but_arrow_left.Name = "but_arrow_left";
            this.but_arrow_left.Size = new System.Drawing.Size(70, 29);
            this.but_arrow_left.TabIndex = 3;
            this.but_arrow_left.Text = "<----";
            this.but_arrow_left.UseVisualStyleBackColor = true;
            // 
            // lbl_add
            // 
            this.lbl_add.AutoSize = true;
            this.lbl_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_add.Location = new System.Drawing.Point(106, 316);
            this.lbl_add.Name = "lbl_add";
            this.lbl_add.Size = new System.Drawing.Size(84, 24);
            this.lbl_add.TabIndex = 4;
            this.lbl_add.Text = "add Fruit";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(214, 320);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(104, 20);
            this.textBox1.TabIndex = 5;
            // 
            // lit_Shop
            // 
            this.lit_Shop.FormattingEnabled = true;
            this.lit_Shop.Items.AddRange(new object[] {
            "Apple ",
            "banana",
            "grape",
            "orange",
            "peach",
            "pear",
            "pipeapple"});
            this.lit_Shop.Location = new System.Drawing.Point(124, 78);
            this.lit_Shop.Name = "lit_Shop";
            this.lit_Shop.Size = new System.Drawing.Size(149, 186);
            this.lit_Shop.TabIndex = 6;
            this.lit_Shop.SelectedIndexChanged += new System.EventHandler(this.lit_Shop_SelectedIndexChanged);
            // 
            // lit_cart
            // 
            this.lit_cart.FormattingEnabled = true;
            this.lit_cart.Location = new System.Drawing.Point(514, 78);
            this.lit_cart.Name = "lit_cart";
            this.lit_cart.Size = new System.Drawing.Size(151, 186);
            this.lit_cart.TabIndex = 7;
            // 
            // but_addfruit
            // 
            this.but_addfruit.Location = new System.Drawing.Point(184, 374);
            this.but_addfruit.Name = "but_addfruit";
            this.but_addfruit.Size = new System.Drawing.Size(75, 23);
            this.but_addfruit.TabIndex = 8;
            this.but_addfruit.Text = "add fruit";
            this.but_addfruit.UseVisualStyleBackColor = true;
            // 
            // but_shopcart
            // 
            this.but_shopcart.Location = new System.Drawing.Point(477, 362);
            this.but_shopcart.Name = "but_shopcart";
            this.but_shopcart.Size = new System.Drawing.Size(81, 47);
            this.but_shopcart.TabIndex = 9;
            this.but_shopcart.Text = "count shop + cart";
            this.but_shopcart.UseVisualStyleBackColor = true;
            // 
            // but_clear
            // 
            this.but_clear.Location = new System.Drawing.Point(610, 362);
            this.but_clear.Name = "but_clear";
            this.but_clear.Size = new System.Drawing.Size(75, 47);
            this.but_clear.TabIndex = 10;
            this.but_clear.Text = "Clear cart";
            this.but_clear.UseVisualStyleBackColor = true;
            // 
            // Formlab3c
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.but_clear);
            this.Controls.Add(this.but_shopcart);
            this.Controls.Add(this.but_addfruit);
            this.Controls.Add(this.lit_cart);
            this.Controls.Add(this.lit_Shop);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbl_add);
            this.Controls.Add(this.but_arrow_left);
            this.Controls.Add(this.but_arrow_right);
            this.Name = "Formlab3c";
            this.Text = "Formlab3c";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button but_arrow_right;
        private System.Windows.Forms.Button but_arrow_left;
        private System.Windows.Forms.Label lbl_add;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox lit_Shop;
        private System.Windows.Forms.ListBox lit_cart;
        private System.Windows.Forms.Button but_addfruit;
        private System.Windows.Forms.Button but_shopcart;
        private System.Windows.Forms.Button but_clear;
    }
}