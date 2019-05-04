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
    public partial class Customer_List : Form
    {
        public Customer_List()
        {
            InitializeComponent();
        }

        private void Customer_List_Load(object sender, EventArgs e)
        {
            customerList_lv.Items.Clear();
            customerList_lv.Columns.Clear();
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
            connection.Open();
            SqlCommand selectCommand = new SqlCommand(@"SELECT * FROM Customer", connection);
            using (SqlDataReader reader = selectCommand.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                customerList_lv.Columns.Add("ID");
                customerList_lv.Columns.Add("Name");
                customerList_lv.Columns.Add("Username");
                customerList_lv.Columns.Add("Birthdate");
                customerList_lv.Columns.Add("Sex");
                foreach (DataRow dr in dt.Rows)
                {
                    ListViewItem lvi = new ListViewItem(dr["CustomerID"].ToString());
                    lvi.SubItems.Add(dr["Name"].ToString());
                    lvi.SubItems.Add(dr["Username"].ToString());
                    lvi.SubItems.Add(((DateTime) dr["Birthdate"]).ToShortDateString());
                    lvi.SubItems.Add(dr["Sex"].ToString());
                    customerList_lv.Items.Add(lvi);
                }
                customerList_lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            }
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            if(customerList_lv.SelectedItems.Count > 0)
            {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-7SO1TNO\SQLEXPRESS;Initial Catalog=MovieRental;Integrated Security=True");
                connection.Open();
                int customerID = int.Parse(customerList_lv.SelectedItems[0].Text);
                SqlCommand delete = new SqlCommand("DELETE FROM Customer WHERE CustomerID = @customerID", connection);
                delete.Parameters.AddWithValue("@customerID", customerID); //TODO on delete cascade.
                delete.ExecuteNonQuery();
                connection.Close();
                customerList_lv.Items.Clear();
                customerList_lv.Columns.Clear();
                this.Customer_List_Load(null, null);
            }
        }

        private void ShowLog_button_Click(object sender, EventArgs e)
        {
            if(customerList_lv.SelectedItems.Count > 0)
            {
                Show_Customer_log csl = new Show_Customer_log(int.Parse(customerList_lv.SelectedItems[0].Text));
                csl.Show();
            }
        }

        private void regCustomer_btn_Click(object sender, EventArgs e)
        {
            Add_Customer ac = new Add_Customer();
            ac.Show();
            ac.Closed += Customer_List_Load;
        }
    }
}
