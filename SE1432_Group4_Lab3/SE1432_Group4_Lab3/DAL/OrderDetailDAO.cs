using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Lab3_Template.DTL;

namespace Lab3_Template.DAL
{
    class OrderDetailDAO
    {
        public static DataTable GetDataTable()
        {
            string sql = "Select * from OrderDetails";
            return DAO.GetDataTable(sql);
        }

        public static bool Insert(OrderDetail a)
        {
                SqlCommand cmd = new SqlCommand("Insert into OrderDetails(OrderID, AlbumID, Quantity, UnitPrice) Values(@OrderID, @AlbumID, @Quantity, @UnitPrice)");
                cmd.Parameters.AddWithValue("@OrderID", a.OrderID);
                cmd.Parameters.AddWithValue("@AlbumID", a.AlbumID);
                cmd.Parameters.AddWithValue("@Quantity", a.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", a.UnitPrice);

                return DAO.UpdateTable(cmd);
        }

        public static bool Update(OrderDetail a)
        {
                SqlCommand cmd = new SqlCommand("Update OrderDetails set OrderID=@OrderID,AlbumID=@AlbumID,Quantity=@Quantity, UnitPrice=@UnitPrice WHERE OrderDetailID=@OrderDetailID");
                cmd.Parameters.AddWithValue("@OrderDetailID", a.OrderDetailID);
                cmd.Parameters.AddWithValue("@OrderID", a.OrderID);
                cmd.Parameters.AddWithValue("@AlbumID", a.AlbumID);
                cmd.Parameters.AddWithValue("@Quantity", a.Quantity);
                cmd.Parameters.AddWithValue("@UnitPrice", a.UnitPrice);

                return DAO.UpdateTable(cmd);


        }

        public static bool Delete(OrderDetail a)
        {
                SqlCommand cmd = new SqlCommand("Delete from OrderDetails where OrderDetailID=@OrderDetailID");
                cmd.Parameters.AddWithValue("@OrderDetailID", a.OrderDetailID);

                return DAO.UpdateTable(cmd);
        }

    }
}
