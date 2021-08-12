using Lab_3.DAL;
using Lab_3.GUI;
using Lab3_Template.DTL;
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
    public partial class CheckoutGUI : Form
    {
        public CheckoutGUI(string total)
        {
            InitializeComponent();
            binTextField(total);
        }

        private void binTextField(string total)
        {
            orderDatePicker.Value = DateTime.Today;
            userNameTxt.Text = Variable.UserName;
            User user = UserDAO.loginUserByName(userNameTxt.Text);
            firstNameTxt.Text = user.FirstName;
            lastNameTxt.Text = user.LastName;
            addressTxt.Text = user.Address;
            cityTxt.Text = user.City;
            stateTxt.Text = user.State;
            countryTxt.Text = user.Country;
            phoneTxt.Text = user.Phone;
            mailTxt.Text = user.Email;
            totalTxt.Text = total;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            if (checkTextField())
            {
                Order order = new Order
                {
                    OrderDate = orderDatePicker.Value,
                    UserName = userNameTxt.Text,
                    FirstName = firstNameTxt.Text,
                    LastName = lastNameTxt.Text,
                    Address = addressTxt.Text,
                    City = cityTxt.Text,
                    State = stateTxt.Text,
                    Country = countryTxt.Text,
                    Phone = phoneTxt.Text,
                    Email = mailTxt.Text,
                    Total = double.Parse(totalTxt.Text)
                };
                var cart = ShoppingCartDAO.GetCart();
                cart.CreateOrder(order);
                MessageBox.Show("Order successful!!");
                this.Close();
            }
        }

        private bool checkTextField()
        {
            if (string.IsNullOrEmpty(userNameTxt.Text))
            {
                MessageBox.Show("Requirement username!");
                return false;
            }
            else if (string.IsNullOrEmpty(firstNameTxt.Text))
            {
                MessageBox.Show("Requirement firstname!");
                return false;
            }
            else if (string.IsNullOrEmpty(lastNameTxt.Text))
            {
                MessageBox.Show("Requirement lastname!");
                return false;
            }
            else if (string.IsNullOrEmpty(addressTxt.Text))
            {
                MessageBox.Show("Requirement address!");
                return false;
            }
            else if (string.IsNullOrEmpty(cityTxt.Text))
            {
                MessageBox.Show("Requirement city!");
                return false;
            }
            else if (string.IsNullOrEmpty(stateTxt.Text))
            {
                MessageBox.Show("Requirement state!");
                return false;
            }
            else if (string.IsNullOrEmpty(countryTxt.Text))
            {
                MessageBox.Show("Requirement country!");
                return false;
            }
            else if (string.IsNullOrEmpty(phoneTxt.Text))
            {
                MessageBox.Show("Requirement phone!");
                return false;
            }
            else if (string.IsNullOrEmpty(mailTxt.Text))
            {
                MessageBox.Show("Requirement email!");
                return false;
            }
            return true;
        }
    }
}
