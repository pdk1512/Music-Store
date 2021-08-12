
namespace Lab_3
{
    partial class HomeGUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.storeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cartMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.loginMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.albumMenuItems = new System.Windows.Forms.ToolStripMenuItem();
            this.panelForm = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.storeMenuItem,
            this.cartMenuItems,
            this.loginMenuItems,
            this.reportMenuItems,
            this.albumMenuItems,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2008, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // storeMenuItem
            // 
            this.storeMenuItem.BackColor = System.Drawing.SystemColors.Control;
            this.storeMenuItem.Image = global::Lab_3.Properties.Resources.vrerg;
            this.storeMenuItem.Name = "storeMenuItem";
            this.storeMenuItem.Size = new System.Drawing.Size(129, 38);
            this.storeMenuItem.Text = " Store";
            this.storeMenuItem.Click += new System.EventHandler(this.storeMenuItem_Click);
            // 
            // cartMenuItems
            // 
            this.cartMenuItems.Image = global::Lab_3.Properties.Resources.Screenshot_2021_06_07_003539;
            this.cartMenuItems.Name = "cartMenuItems";
            this.cartMenuItems.Size = new System.Drawing.Size(110, 38);
            this.cartMenuItems.Text = "Cart";
            this.cartMenuItems.Click += new System.EventHandler(this.cartMenuItems_Click);
            // 
            // loginMenuItems
            // 
            this.loginMenuItems.Image = global::Lab_3.Properties.Resources.user_man_user_interface_app_person_512;
            this.loginMenuItems.Name = "loginMenuItems";
            this.loginMenuItems.Size = new System.Drawing.Size(126, 38);
            this.loginMenuItems.Text = "Login";
            this.loginMenuItems.Click += new System.EventHandler(this.loginMenuItems_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::Lab_3.Properties.Resources.images__1_;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(132, 38);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // reportMenuItems
            // 
            this.reportMenuItems.Image = global::Lab_3.Properties.Resources.Screenshot_2021_06_07_003826;
            this.reportMenuItems.Name = "reportMenuItems";
            this.reportMenuItems.Size = new System.Drawing.Size(137, 38);
            this.reportMenuItems.Text = "Report";
            this.reportMenuItems.Click += new System.EventHandler(this.reportMenuItems_Click);
            // 
            // albumMenuItems
            // 
            this.albumMenuItems.Image = global::Lab_3.Properties.Resources.images;
            this.albumMenuItems.Name = "albumMenuItems";
            this.albumMenuItems.Size = new System.Drawing.Size(137, 38);
            this.albumMenuItems.Text = "Album";
            this.albumMenuItems.Click += new System.EventHandler(this.albumMenuItems_Click);
            // 
            // panelForm
            // 
            this.panelForm.Location = new System.Drawing.Point(0, 71);
            this.panelForm.Name = "panelForm";
            this.panelForm.Size = new System.Drawing.Size(2609, 1181);
            this.panelForm.TabIndex = 1;
            // 
            // HomeGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2008, 1175);
            this.Controls.Add(this.panelForm);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeGUI";
            this.Text = "Music Stone";
            this.Activated += new System.EventHandler(this.HomeGUI_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeGUI_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem storeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartMenuItems;
        private System.Windows.Forms.ToolStripMenuItem loginMenuItems;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.ToolStripMenuItem reportMenuItems;
        private System.Windows.Forms.ToolStripMenuItem albumMenuItems;
    }
}

