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
    public partial class Category : Form
    {
        public Category()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String catName = CatName_tb.Text;
            String categoryID = catName.Substring(0, 3).ToUpper();
            SqlCommand checker = new SqlCommand("SELECT * FROM Category WHERE CategoryID = @categoryID", connection);
            checker.Parameters.AddWithValue("@categoryID", categoryID);
            using (SqlDataReader reader = checker.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                if (dt.Rows.Count != 0)
                    MessageBox.Show("CategoryID already exists in the database please rename the category before adding it.");
                else
                {
                    SqlCommand command = new SqlCommand("Insert Into Category (CategoryID , Name) Values(@categoryID, @catName)", connection);
                    command.Parameters.AddWithValue("@categoryID", categoryID);
                    command.Parameters.AddWithValue("@catName", catName);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Category Added Successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            connection.Close();
            this.Close();
        }
            
    }
}
