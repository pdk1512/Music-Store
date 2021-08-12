using Lab_3.DAL;
using Lab_3.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_3
{
    public partial class HomeGUI : Form
    {
        public HomeGUI()
        {
            InitializeComponent();
            displayMenu();
        }
        private void Embed(Panel p, Form f)
        {
            p.Controls.Clear();
            f.FormBorderStyle = FormBorderStyle.None;
            f.TopLevel = false;
            f.Visible = true;
            f.Dock = DockStyle.Fill;
            p.Controls.Add(f);//thêm form mới vào panel
            p.Show();
        }

        private void displayMenu()
        {
            if(Variable.Role == 1)
            {
                albumMenuItems.Visible = true;
                reportMenuItems.Visible = true;
            }
            else
            {
                albumMenuItems.Visible = false;
                reportMenuItems.Visible = false;
            }
            if(Variable.UserName == null || Variable.UserName == "")
            {
                loginMenuItems.Text = "Login";
            }
            else
            {
                loginMenuItems.Text = "Logout (" + Variable.UserName + ")";
            }
            var cart = ShoppingCartDAO.GetCart();
            string cartSummary = "Cart (" + cart.GetCount() + ")";
            cartMenuItems.Text = cartSummary;
        }

        private void storeMenuItem_Click(object sender, EventArgs e)
        {
            Embed(panelForm, new StoreGUI());
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Embed(panelForm, new AboutGUI());
        }

        private void loginMenuItems_Click(object sender, EventArgs e)
        {
            if(Variable.UserName == null || Variable.UserName == "")
            {
                new LoginGUI().ShowDialog();
            }
            else
            {
                Variable.Role = -1;
                Variable.UserName = null;
                var cart = ShoppingCartDAO.GetCart();
                ShoppingCartDAO.UserName = null;
                cart.ResetCartID();
                displayMenu();
                panelForm.Controls.Clear();
            }
        }

        private void cartMenuItems_Click(object sender, EventArgs e)
        {
            new CartGUI().ShowDialog();
        }

        private void HomeGUI_Activated(object sender, EventArgs e)
        {
            displayMenu();
        }

        private void HomeGUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Variable.UserName == null || Variable.UserName == "")
            {
                var cart = ShoppingCartDAO.GetCart();
                cart.EmptyCart();
            }
        }

        private void reportMenuItems_Click(object sender, EventArgs e)
        {
            Embed(panelForm, new ReportGUI());
        }

        private void albumMenuItems_Click(object sender, EventArgs e)
        {
            Embed(panelForm, new FormAlbum());
        }
    }
}
