
namespace Lab_3
{
    partial class StoreGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StoreGUI));
            this.genreView = new System.Windows.Forms.DataGridView();
            this.albumView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.genreView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).BeginInit();
            this.SuspendLayout();
            // 
            // genreView
            // 
            this.genreView.AllowUserToAddRows = false;
            this.genreView.AllowUserToDeleteRows = false;
            this.genreView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreView.Location = new System.Drawing.Point(25, 22);
            this.genreView.MultiSelect = false;
            this.genreView.Name = "genreView";
            this.genreView.ReadOnly = true;
            this.genreView.RowHeadersWidth = 82;
            this.genreView.Size = new System.Drawing.Size(409, 499);
            this.genreView.TabIndex = 0;
            this.genreView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.genreView_CellMouseClick);
            // 
            // albumView
            // 
            this.albumView.AllowUserToAddRows = false;
            this.albumView.AllowUserToDeleteRows = false;
            this.albumView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.albumView.Location = new System.Drawing.Point(25, 542);
            this.albumView.MultiSelect = false;
            this.albumView.Name = "albumView";
            this.albumView.ReadOnly = true;
            this.albumView.RowHeadersWidth = 82;
            this.albumView.Size = new System.Drawing.Size(1728, 369);
            this.albumView.TabIndex = 1;
            this.albumView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.albumView_CellClick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(450, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1303, 499);
            this.panel1.TabIndex = 2;
            // 
            // StoreGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1774, 923);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.albumView);
            this.Controls.Add(this.genreView);
            this.Name = "StoreGUI";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Shopping";
            ((System.ComponentModel.ISupportInitialize)(this.genreView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.albumView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView genreView;
        private System.Windows.Forms.DataGridView albumView;
        private System.Windows.Forms.Panel panel1;
    }
}