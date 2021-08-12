using Lab3_Template.DAL;
using Lab3_Template.DTL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Lab_3.DAL
{
    class ArtistDAO
    {
        public static DataTable GetDataTable()
        {
            string sql = "select * from Artists";
            return DAO.GetDataTable(sql);
        }

        public static Artist GetArtistById(int id)
        {
            Artist artist = null;
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Artists where ArtistId = @ID");
                cmd.Parameters.AddWithValue("@ID", id);
                DataTable dt = DAO.GetDataTable(cmd);
                if(dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    artist = new Artist
                    {
                        ArtistID = int.Parse(row["ArtistId"].ToString()),
                        Name = row["Name"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return artist;
        }
    }
}
