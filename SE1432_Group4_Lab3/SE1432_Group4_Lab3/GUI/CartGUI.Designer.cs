
namespace Lab_3.GUI
{
    partial class CartGUI
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
            this.cartView = new System.Windows.Forms.DataGridView();
            this.checkOutBtn = new System.Windows.Forms.Button();
            this.totalTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).BeginInit();
            this.SuspendLayout();
            // 
            // cartView
            // 
            this.cartView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartView.Location = new System.Drawing.Point(12, 136);
            this.cartView.Name = "cartView";
            this.cartView.RowHeadersWidth = 82;
            this.cartView.RowTemplate.Height = 33;
            this.cartView.Size = new System.Drawing.Size(1067, 368);
            this.cartView.TabIndex = 0;
            this.cartView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cartView_CellClick);
            // 
            // checkOutBtn
            // 
            this.checkOutBtn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkOutBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkOutBtn.Location = new System.Drawing.Point(12, 64);
            this.checkOutBtn.Name = "checkOutBtn";
            this.checkOutBtn.Size = new System.Drawing.Size(195, 47);
            this.checkOutBtn.TabIndex = 1;
            this.checkOutBtn.Text = "Checkout>>";
            this.checkOutBtn.UseVisualStyleBackColor = false;
            this.checkOutBtn.Click += new System.EventHandler(this.checkOutBtn_Click);
            // 
            // totalTxt
            // 
            this.totalTxt.Location = new System.Drawing.Point(921, 80);
            this.totalTxt.Name = "totalTxt";
            this.totalTxt.Size = new System.Drawing.Size(158, 31);
            this.totalTxt.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(849, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // CartGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 516);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.totalTxt);
            this.Controls.Add(this.checkOutBtn);
            this.Controls.Add(this.cartView);
            this.Name = "CartGUI";
            this.Text = "CartGUI";
            ((System.ComponentModel.ISupportInitialize)(this.cartView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView cartView;
        private System.Windows.Forms.Button checkOutBtn;
        private System.Windows.Forms.TextBox totalTxt;
        private System.Windows.Forms.Label label1;
    }
}