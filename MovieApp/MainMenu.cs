using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovieApp
{
    public partial class MainMenu : Form
    {
        private String username;
        public MainMenu(String ausername)
        {
            username = ausername;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Admin_Register ar = new Admin_Register();
            ar.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddMovie am = new AddMovie();
            am.Show();
           // Category c = new Category();
          //  c.Show();
        }

        private void movieLog_btn_Click(object sender, EventArgs e)
        {
            MovieCatalog mc = new MovieCatalog();
            mc.Show();
        }

        private void AddCustomer_button_Click(object sender, EventArgs e)
        {
            Add_Customer ac = new Add_Customer();
            ac.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Customer_List cl = new Customer_List();
            cl.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Movie_Rent mr = new Movie_Rent();
            mr.Show();
        }
    }
}
