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
    public partial class MovieDetails : Form
    {
        int movieID, adminID;
        SqlConnection connection;
        public MovieDetails(int mid, int aid)
        {
            movieID = mid;
            adminID = aid;
            InitializeComponent();
            connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
        }
        List<String> catIDs = new List<String>();
        private void MovieDetails_Load(object sender, EventArgs e)
        {
            // Load all Categories
            SqlCommand catCommand = new SqlCommand("SELECT * FROM Category", connection);
            using (SqlDataReader reader = catCommand.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                category_cb.Items.Clear();
                foreach (DataRow dr in dt.Rows)
                {
                    catIDs.Add(dr["CategoryID"].ToString());
                    String name = dr["Name"].ToString();
                    category_cb.Items.Add(name);
                }
                reader.Close();
            }

            SqlCommand command = new SqlCommand("SELECT * FROM Movie WHERE MovieID = @id", connection);
            command.Parameters.AddWithValue("@id", movieID);
            using (SqlDataReader reader = command.ExecuteReader()) // TODO fetch CategoryID directly from movCategory_cb
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                // Only 1 Row
                DataRow dr = dt.Rows[0];
                name_lbl.Text = dr["Name"].ToString();
                pic_pb.Image = Image.FromFile(dr["PicturePath"].ToString());
                pic_pb.SizeMode = PictureBoxSizeMode.Zoom;

                name_tb.Text = dr["Name"].ToString();
                description_tb.Text = dr["Description"].ToString();
                pgRate_tb.Text = dr["PGRating"].ToString();
                price_ntb.Value = Decimal.Parse(dr["Price"].ToString());
                qty_ntb.Value = Decimal.Parse(dr["Quantity"].ToString());
                if (qty_ntb.Value < 1)
                    rentMovie_btn.Enabled = false;
                duration_ntb.Value = (int)dr["Duration"];
                picPath_tb.Text = dr["PicturePath"].ToString();
                year_tb.Value = (int) dr["Year"];
                category_cb.SelectedIndex = catIDs.IndexOf(dr["CategoryID"].ToString());
            }

            command = new SqlCommand("SELECT AVG(Rate) AS r, COUNT(*) AS c FROM Rating WHERE MovieID = @id", connection);
            command.Parameters.AddWithValue("@id", movieID);
            using (SqlDataReader reader = command.ExecuteReader()) // TODO fetch CategoryID directly from movCategory_cb
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                // Only 1 Row
                DataRow dr = dt.Rows[0];
                float rate = float.Parse(dr["r"].ToString() == "" ? "0" : dr["r"].ToString());
                
                rate_lbl.Text = Math.Round(rate, 2).ToString() +"★ (" + dr["c"].ToString() + " reviews)";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("DELETE FROM Movie WHERE MovieID = @id", connection);
            command.Parameters.AddWithValue("@id", movieID);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("UPDATE Movie SET Name = @name, Description = @description, PGRating = @pgRate, Price = @price, Duration = @duration, PicturePath = @picPath, Year = @year, Quantity = @qty, CategoryID = @categoryID WHERE MovieID = @movieID", connection);
            command.Parameters.AddWithValue("@movieID", movieID);
            command.Parameters.AddWithValue("@name", name_tb.Text);
            command.Parameters.AddWithValue("@description", description_tb.Text);
            command.Parameters.AddWithValue("@pgRate", pgRate_tb.Text);
            command.Parameters.AddWithValue("@price", price_ntb.Value);
            command.Parameters.AddWithValue("@duration", duration_ntb.Value);
            command.Parameters.AddWithValue("@picPath", picPath_tb.Text);
            command.Parameters.AddWithValue("@year", year_tb.Value);
            command.Parameters.AddWithValue("@qty", qty_ntb.Value);
            command.Parameters.AddWithValue("@categoryID", catIDs[category_cb.SelectedIndex]);
            command.ExecuteNonQuery();
            this.Close();
        }

        private void browsePic_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            // Show the dialog and get result.
            DialogResult result = ofd.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                picPath_tb.Text = ofd.FileName;
                pic_pb.Image = Image.FromFile(ofd.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Movie_Rent mr = new Movie_Rent(movieID, adminID);
            mr.Show();
            mr.Closed += MovieDetails_Load;
        }


    }
}
