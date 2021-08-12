using Lab_3.GUI;
using Lab3_Template.DAL;
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
    public partial class FormAlbum : Form
    {
     
        public FormAlbum()
        {
            InitializeComponent();
        }
        private void bindGrid1()
        {
            int count = dataDisplay.Columns.Count;
            dataDisplay.DataSource = AlbumDAO.GetDataTable();

            DataGridViewButtonColumn btnDetail = new DataGridViewButtonColumn
            {
                Name = "Detail",
                Text = "Detail",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                Name = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn btnAdd = new DataGridViewButtonColumn
            {
                Name = "Add",
                Text = "Add",
                UseColumnTextForButtonValue = true
            };
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                Name = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true
            };

            dataDisplay.Columns.Insert(count, btnDelete);
            dataDisplay.Columns.Insert(count, btnEdit);
            dataDisplay.Columns.Insert(count, btnDetail);



        }


        private void Form1_Load(object sender, EventArgs e)
        {
            bindGrid1();

            //   String sql = "SELECT * FROM albums";

            // dataDisplay.DataSource = dao.GetDataTable(sql);

        }

        private void dataDisplay_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataDisplay.Columns["Detail"].Index)
            {
                int albumID = (int)dataDisplay.Rows[e.RowIndex].Cells["albumID"].Value;
                
                AlbumDetailGUI albumDetail = new AlbumDetailGUI(albumID);
                albumDetail.ShowDialog();
            }

           else if (e.ColumnIndex == dataDisplay.Columns["Delete"].Index)
            {
                int albumID = (int)dataDisplay.Rows[e.RowIndex].Cells["albumID"].Value;
                string message = "Do you want to delete this album?";
                string title = "Confirm";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    AlbumDAO.Delete(AlbumDAO.GetAlbumByID(albumID));
                    MessageBox.Show("Delete successfull");
                    dataDisplay.DataSource = AlbumDAO.GetAlbums();
                }

            }
           else if (e.ColumnIndex == dataDisplay.Columns["Edit"].Index)
            {
                int albumID = (int)dataDisplay.Rows[e.RowIndex].Cells["albumID"].Value;
                AlbumAdd albumEdit  = new AlbumAdd(albumID);
                albumEdit.ShowDialog();
                dataDisplay.DataSource = AlbumDAO.GetAlbums();
            }

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            AlbumAdd albumadd = new AlbumAdd(-1);
            albumadd.ShowDialog();
            dataDisplay.DataSource = AlbumDAO.GetAlbums();
        }
    }
}
