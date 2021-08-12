using Lab_3.DAL;
using Lab_3.GUI;
using Lab3_Template.DAL;
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
    public partial class StoreGUI : Form
    {
        public StoreGUI()
        {
            InitializeComponent();
            genreView.DataSource = GenreDAO.GetDataTable();
            foreach(DataGridViewColumn col in genreView.Columns)
            {
                if (col.HeaderText == "GenreId" || col.HeaderText == "Description")
                    col.Visible = false;
            }
            DataGridViewRow row = genreView.Rows[0];
            binDataGridView(row);
        }

        private void genreView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = genreView.Rows[e.RowIndex];
                binDataGridView(row);
            }
        }

        private void binDataGridView(DataGridViewRow row)
        {
            int genreId = (int)row.Cells[0].Value;
            albumView.DataSource = AlbumDAO.getDataByGenre(genreId);
            if (albumView.Columns.Contains("Detail"))
                albumView.Columns.Remove("Detail");
            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            int count = albumView.Columns.Count;
            albumView.Columns.Insert(count, btnDetail);
        }

        private void albumView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == albumView.Columns["Detail"].Index)
            {
                int albumId = (int) albumView.Rows[e.RowIndex].Cells["AlbumId"].Value;
                AlbumDetailGUI detailForm = new AlbumDetailGUI(albumId);
                DialogResult dr = detailForm.ShowDialog();
                if(dr == DialogResult.OK)
                {
                    var cart = ShoppingCartDAO.GetCart();
                    cart.AddToCart(albumId);
                    CartGUI fc = new CartGUI();
                    fc.ShowDialog();
                    detailForm.Close();
                }
            }
        }
    }
}
