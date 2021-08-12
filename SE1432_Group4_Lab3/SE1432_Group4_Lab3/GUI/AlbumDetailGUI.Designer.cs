
namespace Lab_3.GUI
{
    partial class AlbumDetailGUI
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
            this.titleTxt = new System.Windows.Forms.TextBox();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.artistTxt = new System.Windows.Forms.TextBox();
            this.genreTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addCartBtn = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTxt
            // 
            this.titleTxt.Location = new System.Drawing.Point(242, 259);
            this.titleTxt.Name = "titleTxt";
            this.titleTxt.ReadOnly = true;
            this.titleTxt.Size = new System.Drawing.Size(342, 31);
            this.titleTxt.TabIndex = 0;
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(242, 328);
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.ReadOnly = true;
            this.priceTxt.Size = new System.Drawing.Size(100, 31);
            this.priceTxt.TabIndex = 1;
            // 
            // artistTxt
            // 
            this.artistTxt.Location = new System.Drawing.Point(242, 399);
            this.artistTxt.Name = "artistTxt";
            this.artistTxt.ReadOnly = true;
            this.artistTxt.Size = new System.Drawing.Size(342, 31);
            this.artistTxt.TabIndex = 2;
            // 
            // genreTxt
            // 
            this.genreTxt.Location = new System.Drawing.Point(242, 474);
            this.genreTxt.Name = "genreTxt";
            this.genreTxt.ReadOnly = true;
            this.genreTxt.Size = new System.Drawing.Size(342, 31);
            this.genreTxt.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Title:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 331);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(103, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Artist:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 477);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Genre:";
            // 
            // addCartBtn
            // 
            this.addCartBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.addCartBtn.Location = new System.Drawing.Point(131, 560);
            this.addCartBtn.Name = "addCartBtn";
            this.addCartBtn.Size = new System.Drawing.Size(158, 49);
            this.addCartBtn.TabIndex = 8;
            this.addCartBtn.Text = "Add to Cart";
            this.addCartBtn.UseVisualStyleBackColor = true;
            this.addCartBtn.Click += new System.EventHandler(this.addCartBtn_Click);
            // 
            // backBtn
            // 
            this.backBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.backBtn.Location = new System.Drawing.Point(477, 560);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(107, 49);
            this.backBtn.TabIndex = 9;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(282, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(240, 160);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // AlbumDetailGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 672);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.addCartBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.genreTxt);
            this.Controls.Add(this.artistTxt);
            this.Controls.Add(this.priceTxt);
            this.Controls.Add(this.titleTxt);
            this.Name = "AlbumDetailGUI";
            this.Text = "AlbumDetailGUI";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titleTxt;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.TextBox artistTxt;
        private System.Windows.Forms.TextBox genreTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button addCartBtn;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}