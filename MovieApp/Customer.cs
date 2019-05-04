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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-E94MIOU;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            String Name = cusName_tb.Text;
            String Username = cusUserName_tb.Text;
            DateTime bd = new DateTime(int.Parse(Year_cb.Text), int.Parse(Month_cb.Text), int.Parse(Day_cb.Text));
            String Sex = sex_cb.Text;
            SqlCommand command = new SqlCommand("Insert Into Customer(Name , Username , Birthdate , Sex) Values(@Name , @Username , @Birthdate , @Sex)" , connection);
            command.Parameters.AddWithValue("@Name", Name);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Birthdate", bd);
            command.Parameters.AddWithValue("@Sex", Sex);
            command.ExecuteNonQuery();
           

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
