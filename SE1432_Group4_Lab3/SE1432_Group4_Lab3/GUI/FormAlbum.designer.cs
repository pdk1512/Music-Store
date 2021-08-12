
namespace Lab_3.GUI
{
    partial class FormAlbum
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
            this.dataDisplay = new System.Windows.Forms.DataGridView();
            this.btnCreate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataDisplay
            // 
            this.dataDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDisplay.Location = new System.Drawing.Point(18, 114);
            this.dataDisplay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataDisplay.Name = "dataDisplay";
            this.dataDisplay.RowHeadersWidth = 51;
            this.dataDisplay.RowTemplate.Height = 24;
            this.dataDisplay.Size = new System.Drawing.Size(1398, 781);
            this.dataDisplay.TabIndex = 0;
            this.dataDisplay.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataDisplay_CellContentClick);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(18, 19);
            this.btnCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(321, 86);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create a new album";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1429, 909);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.dataDisplay);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormAlbum";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataDisplay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataDisplay;
        private System.Windows.Forms.Button btnCreate;
    }
}

