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
    public partial class AddMovie : Form
    {
        public AddMovie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            ofd.ShowDialog();
            movPoster_tb.Text = ofd.FileName;
        }

        private void AddMovie_Load(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=NEW-PC;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            SqlCommand command = new SqlCommand("SELECT * FROM Category", connection);
            //command.Parameters.AddWithValue("@username", username); /// TODO read how @ operator replaces ' ' and identifies different data types.
            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                foreach(DataRow dr in dt.Rows)
                {
                    String name = dr["Name"].ToString();
                    movCategory_cb.Items.Add(name);
                }
                reader.Close();
            }
            connection.Close();
        }

        private void MovAdd_button_Click(object sender, EventArgs e)
        {
            //NOTE: change connection string when updating the code on a different PC
            SqlConnection connection = new SqlConnection(@"Data Source=NEW-PC;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String Name = movName_tb.Text;
            String Description = movDesc_tb.Text;
            int Year = int.Parse(movYear_tb.Text);
            double Price = double.Parse(movPrice_tb.Text);
            String PG = movPG_tb.Text;
            int Duration = int.Parse(movDuration_tb.Text);
            String posterPath = movPoster_tb.Text;
            int Quantity = int.Parse(movQuantity_tb.Text);
            String categoryName = movCategory_cb.Text;
            String categoryID = ""; // must be initialized or code will not run.
            SqlCommand selectCommand = new SqlCommand("SELECT CategoryID FROM Category WHERE Name = @categoryName", connection);
            selectCommand.Parameters.AddWithValue("@categoryName", categoryName);
            using (SqlDataReader reader = selectCommand.ExecuteReader()) // TODO fetch CategoryID directly from movCategory_cb
            {
                while (reader.Read())
                    categoryID = reader["CategoryID"].ToString();
                reader.Close();

            }
            SqlCommand insertCommand = new SqlCommand("INSERT INTO Movie VALUES (@Name, @Description, @PG, @Price, @Duration, @posterPath, @Year, @Quantity, @categoryID)", connection);
            insertCommand.Parameters.AddWithValue("@Name", Name);
            insertCommand.Parameters.AddWithValue("@Description", Description);
            insertCommand.Parameters.AddWithValue("PG", PG);
            insertCommand.Parameters.AddWithValue("@Price", Price);
            insertCommand.Parameters.AddWithValue("@Duration", Duration);
            insertCommand.Parameters.AddWithValue("@posterPath", posterPath);
            insertCommand.Parameters.AddWithValue("@Year", Year);
            insertCommand.Parameters.AddWithValue("@Quantity", Quantity);
            insertCommand.Parameters.AddWithValue("@categoryID", categoryID);
            insertCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Movie Succssfully added!");
            this.Hide();
        }
    }
}
