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
    public partial class MovieCatalog : Form
    {
        public MovieCatalog()
        {
            InitializeComponent();
        }

        private void MovieCatalog_Load(object sender, EventArgs e)
        {
            listView1.Columns.Add("ID");
            listView1.Columns.Add("Name");
            listView1.Columns.Add("Description");
            listView1.Columns.Add("PG Rating");
            listView1.Columns.Add("Price");
            listView1.Columns.Add("Duration");
            listView1.Columns.Add("Year");
            listView1.Columns.Add("Quantity");
            listView1.Columns.Add("Category");
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
                MessageBox.Show("You clicked " + listView1.SelectedItems[0].Text);
        }

        
    }
}
