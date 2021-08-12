using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Lab3_Template.DTL;
using Lab3_Template.DAL;

namespace Lab_3.GUI
{
    public partial class AlbumAdd : Form
    {
        Album album;
        public AlbumAdd(int albumID)
        {
            InitializeComponent();
            if (albumID > 0)
            {
                album = AlbumDAO.GetAlbumByID(albumID);
            }
            else
            {
                album = new Album();
            }
            fillInformation(albumID);
           

        }
        public void fillInformation(int albumID)
        {
            if (albumID > 0)
            {
                txtTitle.Text = album.Title;
                txtPrice.Text = album.Price.ToString();
                txtURL.Text = album.AlbumUrl;
                string path = album.AlbumUrl.Replace('/', '\\');
                try
                {
                    picDisplay.Image = Image.FromFile(getProjectPath() + path);
                }
                catch (Exception e)
                {
                    MessageBox.Show("Cannot find image file");
                }
                passDataToCmb(new SqlCommand("SELECT * FROM Artists"), cbArtist, album.ArtistID);
                passDataToCmb(new SqlCommand("SELECT * FROM Genres"), cbGenre, album.GenreID);
            }
            else
            {
                passDataToCmb(new SqlCommand("SELECT * FROM Artists"), cbArtist, 0);
                passDataToCmb(new SqlCommand("SELECT * FROM Genres"), cbGenre, 0);
            }

        }
        private void passDataToCmb(SqlCommand cmd, ComboBox cmb, int selectedKey)
        {
            var tableData = DAO.GetDataTable(cmd);
            var comboSource = new Dictionary<String, String>();

            string selectedValue = "";
            foreach (DataRow row in tableData.Rows)
            {
                comboSource.Add(row.ItemArray[0].ToString(), row.ItemArray[1].ToString());
                if (selectedKey.ToString().Equals(row.ItemArray[0].ToString())) selectedValue = row.ItemArray[1].ToString();
            }
            cmb.DataSource = new BindingSource(comboSource, null);
            cmb.DisplayMember = "Value";
            cmb.ValueMember = "Key";
            if (selectedKey > 0)
            {
                cmb.SelectedIndex = cmb.FindStringExact(selectedValue);
            }
            else cmb.SelectedIndex = 0;
        }
        public void showCBGenreId()
        {
            cbGenre.DataSource = DAO.GetDataTable("select genreid, name from genres");
            cbGenre.DisplayMember = "name";
            cbGenre.ValueMember = "genreid";
        }
        public void showCBArtist()
        {
            cbArtist.DataSource = DAO.GetDataTable("select artistid, name from artists");
            cbArtist.DisplayMember = "name";
            cbArtist.ValueMember = "artistid";
            
        }

        private void AlbumAdd_Load(object sender, EventArgs e)
        {
            
            this.showCBGenreId();
            this.showCBArtist();
;        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            double price = 0.0f;
            if (txtTitle.Text.Trim() == "")
            {
                MessageBox.Show("Title cannot be empty");
                return;
            }
            else if (txtPrice.Text.Trim() == "")
            {
                MessageBox.Show("Price cannot be empty");
                return;
            }
            else
            {
                    album.Title = txtTitle.Text;
                    album.GenreID = (int)cbGenre.SelectedValue;
                    album.ArtistID = (int)cbArtist.SelectedValue;
                    album.AlbumUrl = txtURL.Text;
                    price = double.Parse(txtPrice.Text);
                    album.Price = price;
            }
            if (album.AlbumID > 0)
            {
                AlbumDAO.Update(album);
                this.Close();
            }
            else
            {
                AlbumDAO.Insert(album);
                this.Close();
            }

        }

        private void cbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string getProjectPath()
        {
            string path = Application.StartupPath;
            DirectoryInfo di = new DirectoryInfo(path);
            for (int i = 0; i < 2; i++)
            {
                di = Directory.GetParent(di.FullName);
            }
            return di.FullName;
        }
        private void btnSelect_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog
            {
                InitialDirectory = getProjectPath() + "\\Images\\",
                Title = "Select image file",
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.gif) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png; *.gif",
                FilterIndex = 1,
                CheckFileExists = true,
                CheckPathExists = true
            };


            if (opf.ShowDialog() == DialogResult.OK)
            {
                string ext = opf.FileName.Substring(opf.FileName.IndexOf('.'));
                string filename = Guid.NewGuid().ToString() + ext;
                string fileDest = getProjectPath() + "\\Images\\" + filename;
                File.Copy(opf.FileName, fileDest);
                txtURL.Text = "/Images/" + filename;
                try
                {
                    picDisplay.Image = Image.FromFile(fileDest);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot find image file");
                }
            }
        }
    }

}
