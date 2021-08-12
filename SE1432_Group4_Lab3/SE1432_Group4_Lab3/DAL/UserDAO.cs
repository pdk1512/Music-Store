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
    class UserDAO
    {
        public static User GetUsers(string username)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT [id],[UserName],[Password],[FirstName],[LastName]," +
                "[Address],[City],[State],[Country],[Phone],[Email],[Role] FROM [Users] " +
                "WHERE [UserName] = @ID AND [Password] = @Password");
                cmd.Parameters.AddWithValue("@ID", username);
                DataTable dt = DAO.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    User user = new User()
                    {
                        Id = int.Parse(row["id"].ToString()),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        Role = int.Parse(row["Role"].ToString()),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Address = row["Address"].ToString(),
                        City = row["City"].ToString(),
                        State = row["State"].ToString(),
                        Country = row["Country"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Email = row["Email"].ToString()
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static User loginUser(string id, string password)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT [id],[UserName],[Password],[FirstName],[LastName]," +
                "[Address],[City],[State],[Country],[Phone],[Email],[Role] FROM [Users] " +
                "WHERE [UserName] = @ID AND [Password] = @Password");
                cmd.Parameters.AddWithValue("@ID", id);
                cmd.Parameters.AddWithValue("@Password", password);
                DataTable dt = DAO.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    User user = new User()
                    {
                        Id = int.Parse(row["id"].ToString()),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        Role = int.Parse(row["Role"].ToString()),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Address = row["Address"].ToString(),
                        City = row["City"].ToString(),
                        State = row["State"].ToString(),
                        Country = row["Country"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Email = row["Email"].ToString()
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static User loginUserByName(string name)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT [id],[UserName],[Password],[FirstName],[LastName]," +
                "[Address],[City],[State],[Country],[Phone],[Email],[Role] FROM [Users] " +
                "WHERE [UserName] = @ID");
                cmd.Parameters.AddWithValue("@ID", name);
                DataTable dt = DAO.GetDataTable(cmd);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    User user = new User()
                    {
                        Id = int.Parse(row["id"].ToString()),
                        UserName = row["UserName"].ToString(),
                        Password = row["Password"].ToString(),
                        Role = int.Parse(row["Role"].ToString()),
                        FirstName = row["FirstName"].ToString(),
                        LastName = row["LastName"].ToString(),
                        Address = row["Address"].ToString(),
                        City = row["City"].ToString(),
                        State = row["State"].ToString(),
                        Country = row["Country"].ToString(),
                        Phone = row["Phone"].ToString(),
                        Email = row["Email"].ToString()
                    };
                    return user;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
