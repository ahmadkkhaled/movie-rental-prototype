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
    public partial class Admin_Login : Form
    {
        public Admin_Login()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String username = username_tb.Text;
            String password = password_tb.Text;
            SqlCommand command = new SqlCommand("SELECT * FROM Admin WHERE Username = @username AND password = @password", connection);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            using (SqlDataReader reader = command.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                connection.Close();
                int c = dt.Rows.Count;
                if (c == 0)
                    MessageBox.Show("Wrong username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DataRow dr = dt.Rows[0];
                    this.Hide();
                    MainMenu mm = new MainMenu(int.Parse(dr["AdminID"].ToString())); 
                    mm.Closed += (s, args) => { this.Close(); };
                    mm.Show();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
