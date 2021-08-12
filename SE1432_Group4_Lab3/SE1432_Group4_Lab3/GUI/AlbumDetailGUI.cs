using Lab_3.DAL;
using Lab3_Template.DAL;
using Lab3_Template.DTL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab_3.GUI
{
    public partial class AlbumDetailGUI : Form
    {
        public AlbumDetailGUI(int albumId)
        {
            InitializeComponent();
            Album album = AlbumDAO.GetAlbumByID(albumId);
            titleTxt.Text = album.Title;
            priceTxt.Text = album.Price.ToString();
            artistTxt.Text = ArtistDAO.GetArtistById(album.ArtistID).Name.ToString();
            genreTxt.Text = GenreDAO.GetGenreById(album.GenreID).Name.ToString();
            string path = album.AlbumUrl.Replace('/', '\\');
            try
            {
                pictureBox1.Image = Image.FromFile(getProjectPath() + path);
            }
            catch(Exception e)
            {
                MessageBox.Show("Cannot find image file");
            }
        }

        private string getProjectPath()
        {
            string path = Application.StartupPath;
            DirectoryInfo di = new DirectoryInfo(path);
            for (int i = 0; i < 2; i++)
            {
                di = Directory.GetParent(di.FullName);
            }
            return di.FullName;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addCartBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
