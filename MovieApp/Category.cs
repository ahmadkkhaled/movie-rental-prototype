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
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-E94MIOU;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String categoryID = CatID_tb.Text.Substring(0,3);
            String catName = CatName_tb.Text;
            SqlCommand command = new SqlCommand("Insert Into Category (CategoryID , Name) Values(@categoryID , @catName)", connection);
            command.Parameters.AddWithValue("@categoryID", categoryID);
            command.Parameters.AddWithValue("@catName", catName);
            command.ExecuteNonQuery();

        }
            
    }
}
