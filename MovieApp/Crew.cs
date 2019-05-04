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
    public partial class Crew : Form
    {
        public Crew()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=NEW-PC;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String name = name_tb.Text;
            SqlCommand command= new SqlCommand("Insert Into Crew(Name)Values(@Name)",connection);
            command.Parameters.AddWithValue("@Name", name);
            command.ExecuteNonQuery();
            Category  category= new Category();
            category.Show();

        }
    }
}
