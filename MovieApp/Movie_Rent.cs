using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieApp
{
    public partial class Movie_Rent : Form
    {
        int movieID = 4;
        int adminID = 1;
        List<String> IDs = new List<String>();
        public Movie_Rent(int mi, int ai)
        {
            movieID = mi;
            adminID = ai;
            InitializeComponent();
        }

        private void Movie_Rent_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Customer", connection);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach (DataRow dr in dt.Rows)
                {
                    
                    String name = dr["Username"].ToString();
                    customerList_cb.Items.Add(name);
                    IDs.Add(dr["CustomerID"].ToString());
                }
                reader.Close();
            }
            connection.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            int selectedCustomerID = int.Parse(IDs[customerList_cb.SelectedIndex]);
            SqlCommand update = new SqlCommand("UPDATE Movie SET Quantity = Quantity-1 WHERE MovieID = @movieID", connection); //TODO replace Quantity+1 with Quantity-1
            update.Parameters.AddWithValue("@movieID", movieID);
            update.ExecuteNonQuery();
            SqlCommand selectPrice = new SqlCommand("SELECT Price FROM Movie WHERE MovieID = @movieID", connection);
            selectPrice.Parameters.AddWithValue("@movieID", movieID);
            int rentalPrice;
            using (SqlDataReader reader = selectPrice.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                DataRow dr = dt.Rows[0];
                rentalPrice = int.Parse(dr["Price"].ToString()) * int.Parse(Duration_nud.Value.ToString());
            }
            DateTime now = DateTime.Now;
            DateTime expiration = now.AddDays(int.Parse(Duration_nud.Value.ToString()));
            SqlCommand rentInsert = new SqlCommand("INSERT INTO Rents (AdminID, CustomerID, MovieID, Price, RentalDate, Expiration) VALUES (@adminID, @selectedCustomerID, @movieID, @rentalPrice, @now, @expiration)", connection);
            rentInsert.Parameters.AddWithValue("@movieID", movieID);
            rentInsert.Parameters.AddWithValue("@selectedCustomerID", selectedCustomerID);
            rentInsert.Parameters.AddWithValue("@adminID", adminID);
            rentInsert.Parameters.AddWithValue("@rentalPrice", rentalPrice);
            rentInsert.Parameters.AddWithValue("@now", DateTime.Now);
            rentInsert.Parameters.AddWithValue("@expiration", expiration);
            rentInsert.ExecuteNonQuery();
            MessageBox.Show("Thank you for using Venus!\nRental price: $" + rentalPrice.ToString());
            this.Close();
        }
    }
}
