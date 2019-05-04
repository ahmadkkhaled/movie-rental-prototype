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
    public partial class MovieCatalog : Form
    {
        SqlConnection connection;
        private int adminID;
        public MovieCatalog(int aid)
        {
            adminID = aid;
            connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            InitializeComponent();
        }

        List<String> IDs = new List<String>();
        List<String> years = new List<String>();
        private void MovieCatalog_Load(object sender, EventArgs e)
        {
            if (!IDs.Contains("ALL")) {
                IDs.Add("ALL");
                categories_cb.Items.Add("All");
                categories_cb.SelectedIndex = 0;
            }
            if (!years.Contains("ALL"))
            {
                year_cb.Items.Add("All");
                years.Add("ALL");
                year_cb.SelectedIndex = 0;
            }
            
            SqlCommand command = new SqlCommand("SELECT *, Category.Name AS cName FROM Movie INNER JOIN Category ON Movie.CategoryID = Category.CategoryID ORDER BY Movie.Name", connection);
            loadList(command);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                String movieID = listView1.SelectedItems[0].Text;
                MovieDetails md = new MovieDetails(int.Parse(movieID), adminID);
                md.Show();
                md.Closed += MovieCatalog_Load;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.Show();
            am.Closed += MovieCatalog_Load; 
        }

        private void loadList(SqlCommand command)
        {
            listView1.Columns.Clear();
            listView1.Items.Clear();
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("PG Rating");
            listView1.Columns.Add("Price");
            listView1.Columns.Add("Year");
            listView1.Columns.Add("Quantity");
            listView1.Columns.Add("Category");
            
            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable table = new DataTable("Movies");
                table.Load(reader);
                foreach (DataRow dr in table.Rows)
                {
                    ListViewItem item = new ListViewItem(dr["MovieID"].ToString());
                    item.SubItems.Add(dr["Name"].ToString());
                    item.SubItems.Add(dr["PGRating"].ToString());
                    item.SubItems.Add(dr["Price"].ToString());
                    item.SubItems.Add(dr["Year"].ToString());
                    item.SubItems.Add(dr["Quantity"].ToString());
                    item.SubItems.Add(dr["cName"].ToString());
                    listView1.Items.Add(item);
                    if (!IDs.Contains(dr["CategoryID"].ToString()))
                    {
                        IDs.Add(dr["CategoryID"].ToString());
                        categories_cb.Items.Add(dr["cName"].ToString());
                    }
                    if (!years.Contains(dr["Year"].ToString()))
                    {
                        years.Add(dr["Year"].ToString());
                        year_cb.Items.Add(dr["Year"].ToString());
                    }
                }

            }
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            String query = "SELECT *, Category.Name AS cName FROM Movie INNER JOIN Category ON Category.CategoryID = Movie.CategoryID WHERE Movie.Name LIKE @name";
            if (categories_cb.SelectedItem.ToString() != "All")
            {
                query += " AND Category.CategoryID = @categoryID";
            }
            if (year_cb.SelectedItem.ToString() != "All")
            {
                query += " AND Year = @year";
            }
            query += " ORDER BY Movie.Name";

            String name = '%' + name_filter_tb.Text + '%';
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@name", name);
            if(categories_cb.SelectedIndex > 0){
                command.Parameters.AddWithValue("@categoryID", IDs[categories_cb.SelectedIndex]);
            }
            if (year_cb.SelectedIndex > 0)
            {
                command.Parameters.AddWithValue("@year", years[year_cb.SelectedIndex]);
            }
            loadList(command);
            
        }

        private void addCategory_btn_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.Show();
            c.Closed += MovieCatalog_Load;
        }

        private void categories_cb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        
    }
}
