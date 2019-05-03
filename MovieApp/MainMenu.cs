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
        }
    }
}
