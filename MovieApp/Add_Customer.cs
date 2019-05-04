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
    public partial class Add_Customer : Form
    {
        public Add_Customer()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=NEW-PC;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String Name = cusName_tb.Text;
            String Username = cusUserName_tb.Text;
            SqlCommand check = new SqlCommand("SELECT * FROM Customer WHERE Username = @Username", connection);
            check.Parameters.AddWithValue("@Username", Username);
            using (SqlDataReader reader = check.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                if(dt.Rows.Count != 0)
                    MessageBox.Show("Customer with the same username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DateTime bd = new DateTime(int.Parse(Year_cb.Text), int.Parse(Month_cb.Text), int.Parse(Day_cb.Text));
                    String Sex = sex_cb.Text;
                    //TODO ensure customer with the same username hasn't been registered before
                    SqlCommand command = new SqlCommand("Insert Into Customer(Name , Username , Birthdate , Sex) Values(@Name , @Username , @Birthdate , @Sex)", connection);
                    command.Parameters.AddWithValue("@Name", Name);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Birthdate", bd);
                    command.Parameters.AddWithValue("@Sex", Sex);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Customer succssfully registered");
                }
            }
            connection.Close();
            this.Close();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Password_Click(object sender, EventArgs e)
        {

        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Year_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
