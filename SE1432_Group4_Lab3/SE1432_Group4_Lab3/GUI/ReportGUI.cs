using Lab3_Template.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace Lab_3.GUI
{
    public partial class ReportGUI : Form
    {
        public ReportGUI()
        {
            
            InitializeComponent();
         
            bindGrid1();
        }

        private  void bindGrid1()
        {

            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM orders WHERE orderDate BETWEEN @startDate AND @endDate");
                cmd.Parameters.AddWithValue("@startDate", monthCalendar1.SelectionStart);
                cmd.Parameters.AddWithValue("@endDate", monthCalendar1.SelectionEnd);

                //data -> dataGridViewOrder
                dataGridViewOrder.DataSource = DAO.GetDataTable(cmd);

                //startDate, endDate -> textBox
                txtFrom.Text = monthCalendar1.SelectionStart.ToShortDateString();
                txtTo.Text = monthCalendar1.SelectionEnd.ToShortDateString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            bindGrid1();
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            try
            {
              
                SqlCommand cmd = new SqlCommand("SELECT O.OrderId, AlbumId, Quantity, UnitPrice " +
                    "FROM Orders O, OrderDetails OD " +
                    "WHERE O.OrderId = OD.OrderId AND O.FirstName LIKE @firstName + '%' AND O.Country LIKE @country + '%' " +
                    "AND orderDate BETWEEN @startDate AND @endDate");

                cmd.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                cmd.Parameters.AddWithValue("@country", txtCountry.Text);
                cmd.Parameters.AddWithValue("@startDate", monthCalendar1.SelectionStart);
                cmd.Parameters.AddWithValue("@endDate", monthCalendar1.SelectionEnd);

                dataGridViewOrderDetails.DataSource = DAO.GetDataTable(cmd);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void dataGridViewOrder_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                //get index of selected row
                int indexOfRow;
                indexOfRow = e.RowIndex;

                //get OrderDetails of Order in selected row
                SqlCommand cmd = new SqlCommand("SELECT * FROM OrderDetails WHERE orderId = @OrderId");
                cmd.Parameters.AddWithValue("@OrderId", dataGridViewOrder.Rows[indexOfRow].Cells[0].Value);

                //data -> dataGridView
                dataGridViewOrderDetails.DataSource = DAO.GetDataTable(cmd);
                txtFirstName.Text = dataGridViewOrder.Rows[indexOfRow].Cells["FirstName"].Value.ToString();
                txtCountry.Text = dataGridViewOrder.Rows[indexOfRow].Cells["Country"].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
