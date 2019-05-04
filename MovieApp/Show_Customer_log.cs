using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class Show_Customer_log : Form
    {
        private int customerID;
        public Show_Customer_log(int customerID)
        {
            this.customerID = customerID;
            InitializeComponent();
        }

        private void Show_Customer_log_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=NEW-PC;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            SqlCommand selectCommand = new SqlCommand(@"SELECT RentID, Movie.Name, RentalDate, Expiration, IsReturned FROM Rents, Movie, Customer WHERE Rents.CustomerID = @customerID AND Rents.MovieID = Movie.MovieID AND Customer.CustomerID = Rents.CustomerID ", connection);
            selectCommand.Parameters.AddWithValue("@customerID", customerID);
            using (SqlDataReader reader = selectCommand.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                customerList_lv.Columns.Add("RentID");
                customerList_lv.Columns.Add("Movie Name");
                customerList_lv.Columns.Add("Rental Date");
                customerList_lv.Columns.Add("Expiration Date");
                customerList_lv.Columns.Add("IsReturned");
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem lvi = new ListViewItem(dr["RentID"].ToString());
                    lvi.SubItems.Add(dr["Name"].ToString());
                    lvi.SubItems.Add(((DateTime)dr["RentalDate"]).ToShortDateString());
                    lvi.SubItems.Add(dr["Expiration"].ToString());
                    lvi.SubItems.Add(dr["IsReturned"].ToString() == "False" ? "No" : "Yes");
                    customerList_lv.Items.Add(lvi);
                }
                customerList_lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            connection.Close();
        }

        private void Returnmovie_btn_Click(object sender, EventArgs e)
        {
            if(customerList_lv.SelectedItems.Count > 0)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=NEW-PC;Initial Catalog=MovieRental;Integrated Security=True");
                connection.Open();
                int rentID = int.Parse(customerList_lv.SelectedItems[0].Text);
                SqlCommand update = new SqlCommand("UPDATE Rents set IsReturned = 1 WHERE RentID = @rentID", connection);
                update.Parameters.AddWithValue("@rentID", rentID);
                update.ExecuteNonQuery();
                customerList_lv.SelectedItems[0].SubItems[4].Text = "Yes";
                int movieID = 0;
                SqlCommand getMovieID = new SqlCommand("SELECT MovieID FROM Rents WHERE RentID = @rentID", connection);
                getMovieID.Parameters.AddWithValue("@rentID", rentID);
                using (SqlDataReader reader = getMovieID.ExecuteReader())
                {
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    DataRow dr = dt.Rows[0];
                    movieID = int.Parse(dr["MovieID"].ToString());
                }
                SqlCommand updQuantity = new SqlCommand("UPDATE Movie SET Quantity = Quantity+1 WHERE MovieID = @movieID", connection);
                updQuantity.Parameters.AddWithValue("@movieID", movieID);
                updQuantity.ExecuteNonQuery();
                connection.Close();

            }
        }

        private void CustomerList_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(customerList_lv.SelectedItems.Count > 0)
            {
                if (customerList_lv.SelectedItems[0].SubItems[4].Text == "Yes")
                    returnmovie_btn.Enabled = false;
                else
                    returnmovie_btn.Enabled = true;
            }
        }
    }
}
