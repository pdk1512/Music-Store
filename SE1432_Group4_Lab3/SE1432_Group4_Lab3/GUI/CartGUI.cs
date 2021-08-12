using Lab_3.DAL;
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
    public partial class CartGUI : Form
    {
        public CartGUI()
        {
            InitializeComponent();
            binDataCartView();
        }

        private void binDataCartView()
        {
            var cart = ShoppingCartDAO.GetCart();
            var cartItems = cart.GetCartItems();
            totalTxt.Text = String.Format("{0:0.00}", cart.GetTotal());
            cartView.Columns.Clear();
            cartView.DataSource = cartItems;
            cartView.Columns["RecordID"].Visible = false;
            cartView.Columns["cartID"].Visible = false;
            int count = cartView.Columns.Count;
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            cartView.Columns.Insert(count, btnDetail);
            DataGridViewButtonColumn btnRemove = new DataGridViewButtonColumn
            {
                Name = "Remove",
                Text = "Remove",
                UseColumnTextForButtonValue = true
            };
            cartView.Columns.Insert(count, btnRemove);
        }

        private void cartView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == cartView.Columns["Detail"].Index)
            {
                int albumId = (int)cartView.Rows[e.RowIndex].Cells["AlbumId"].Value;
                AlbumDetailGUI detailForm = new AlbumDetailGUI(albumId);
                DialogResult dr = detailForm.ShowDialog();
                if (dr == DialogResult.OK)
                {
                    var cart = ShoppingCartDAO.GetCart();
                    cart.AddToCart(albumId);
                    binDataCartView();
                    detailForm.Close();
                }
                
            }
            if (e.ColumnIndex == cartView.Columns["Remove"].Index)
            {
                int albumId = (int)cartView.Rows[e.RowIndex].Cells["AlbumId"].Value;
                var cart = ShoppingCartDAO.GetCart();
                cart.RemoveFromCart(albumId);
                binDataCartView();
            }
        }

        private void checkOutBtn_Click(object sender, EventArgs e)
        {
            if (cartView.Rows.Count == 0)
            {
                MessageBox.Show("Cart Empty!");
            }
            else
            {
                this.Close();
                if (Variable.UserName == null || Variable.UserName == "")
                {
                    new LoginGUI().ShowDialog();
                }
                else
                {
                    new CheckoutGUI(totalTxt.Text).ShowDialog();
                }
            }
        }

        
    }
}
