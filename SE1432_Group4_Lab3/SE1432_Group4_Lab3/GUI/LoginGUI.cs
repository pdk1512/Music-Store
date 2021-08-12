using Lab_3.DAL;
using Lab3_Template.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_3.GUI
{
    public partial class LoginGUI : Form
    {
        public LoginGUI()
        {
            InitializeComponent();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTxt.Text))
                MessageBox.Show("Please fill the name!");
            else if(string.IsNullOrEmpty(passTxt.Text))
                MessageBox.Show("Please fill the password!");
            else
            {
                User user = UserDAO.loginUser(nameTxt.Text, passTxt.Text);
                if (user == null)
                    MessageBox.Show("User does not exist!");
                else
                {
                    Variable.UserName = user.UserName;
                    Variable.Role = user.Role;
                    ShoppingCartDAO.UserName = user.UserName;
                    var cart = ShoppingCartDAO.GetCart();
                    cart.MigrateCart();
                    this.Close();
                }
            }
            
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
