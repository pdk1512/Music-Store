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
    class GenreDAO
    {
        public static DataTable GetDataTable()
        {
            string sql = "select * from Genres";
            return DAO.GetDataTable(sql);
        }

        public static Genre GetGenreById(int id)
        {
            Genre genre = null;
            try
            {
                SqlCommand cmd = new SqlCommand("select * from Genres where GenreId = @ID");
                cmd.Parameters.AddWithValue("@ID", id);
                DataTable dt = DAO.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    genre = new Genre
                    {
                        GenreID = int.Parse(row["GenreId"].ToString()),
                        Name = row["Name"].ToString(),
                        Description = row["Description"].ToString()
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return genre;
        }
    }
}
