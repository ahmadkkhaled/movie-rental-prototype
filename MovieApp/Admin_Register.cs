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
    public partial class Admin_Register : Form
    {
        public Admin_Register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String username = admUsername_tb.Text;
            SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE Username = @username", connection);
            command.Parameters.AddWithValue("@username", username);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                if( dt.Rows.Count != 0)
                    MessageBox.Show("Admin with the same username already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    String password = admPassword_tb.Text;
                    String fullName = admFirstName_tb.Text + " " + admLastName_tb.Text;
                    double salary = Double.Parse(admSalary_tb.Text);
                    String sex = admSex_cb.Text;
                    DateTime bd = new DateTime(int.Parse(admYear_cb.Text), int.Parse(admMonth_tb.Text), int.Parse(admDay_cb.Text));
                    SqlCommand insertCommand = new SqlCommand("INSERT INTO Admin (Name, Password, Birthdate, Salary, Sex, Username) VALUES (@fullName, @password, @birthdate, @salary, @sex, @username)", connection);
                    insertCommand.Parameters.AddWithValue("@fullName", fullName);
                    insertCommand.Parameters.AddWithValue("@password", password);
                    insertCommand.Parameters.AddWithValue("@salary", salary);
                    insertCommand.Parameters.AddWithValue("@sex", sex);
                    insertCommand.Parameters.AddWithValue("@username", username);
                    insertCommand.Parameters.AddWithValue("@birthdate", bd);
                    insertCommand.ExecuteNonQuery();
                    MessageBox.Show("Admin succssfully created");
                    this.Close();
                }
                connection.Close();
            }
        }

    }
}
