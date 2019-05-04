namespace MovieApp
{
    partial class MovieCatalog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.categories_cb = new System.Windows.Forms.ComboBox();
            this.year_cb = new System.Windows.Forms.ComboBox();
            this.name_filter_tb = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.addCategory_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(12, 38);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 390);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(662, 8);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 24);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Movie";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categories_cb
            // 
            this.categories_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categories_cb.FormattingEnabled = true;
            this.categories_cb.Location = new System.Drawing.Point(239, 11);
            this.categories_cb.Name = "categories_cb";
            this.categories_cb.Size = new System.Drawing.Size(121, 21);
            this.categories_cb.TabIndex = 4;
            // 
            // year_cb
            // 
            this.year_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.year_cb.FormattingEnabled = true;
            this.year_cb.Location = new System.Drawing.Point(165, 11);
            this.year_cb.Name = "year_cb";
            this.year_cb.Size = new System.Drawing.Size(68, 21);
            this.year_cb.TabIndex = 5;
            // 
            // name_filter_tb
            // 
            this.name_filter_tb.Location = new System.Drawing.Point(12, 12);
            this.name_filter_tb.Name = "name_filter_tb";
            this.name_filter_tb.Size = new System.Drawing.Size(147, 20);
            this.name_filter_tb.TabIndex = 6;
            // 
            // search_btn
            // 
            this.search_btn.Location = new System.Drawing.Point(366, 9);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(75, 23);
            this.search_btn.TabIndex = 7;
            this.search_btn.Text = "Search";
            this.search_btn.UseVisualStyleBackColor = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // addCategory_btn
            // 
            this.addCategory_btn.Location = new System.Drawing.Point(568, 8);
            this.addCategory_btn.Name = "addCategory_btn";
            this.addCategory_btn.Size = new System.Drawing.Size(88, 23);
            this.addCategory_btn.TabIndex = 8;
            this.addCategory_btn.Text = "Add Category";
            this.addCategory_btn.UseVisualStyleBackColor = true;
            this.addCategory_btn.Click += new System.EventHandler(this.addCategory_btn_Click);
            // 
            // MovieCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 440);
            this.Controls.Add(this.addCategory_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.name_filter_tb);
            this.Controls.Add(this.year_cb);
            this.Controls.Add(this.categories_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MovieCatalog";
            this.Text = "MovieCatalog";
            this.Load += new System.EventHandler(this.MovieCatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categories_cb;
        private System.Windows.Forms.ComboBox year_cb;
        private System.Windows.Forms.TextBox name_filter_tb;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button addCategory_btn;



    }
}