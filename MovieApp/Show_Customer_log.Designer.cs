namespace MovieApp
{
    partial class Show_Customer_log
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
            this.customerList_lv = new System.Windows.Forms.ListView();
            this.returnmovie_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerList_lv
            // 
            this.customerList_lv.FullRowSelect = true;
            this.customerList_lv.GridLines = true;
            this.customerList_lv.Location = new System.Drawing.Point(-1, 36);
            this.customerList_lv.MultiSelect = false;
            this.customerList_lv.Name = "customerList_lv";
            this.customerList_lv.Size = new System.Drawing.Size(800, 414);
            this.customerList_lv.TabIndex = 1;
            this.customerList_lv.UseCompatibleStateImageBehavior = false;
            this.customerList_lv.View = System.Windows.Forms.View.Details;
            this.customerList_lv.SelectedIndexChanged += new System.EventHandler(this.CustomerList_lv_SelectedIndexChanged);
            // 
            // returnmovie_btn
            // 
            this.returnmovie_btn.Location = new System.Drawing.Point(-1, 7);
            this.returnmovie_btn.Name = "returnmovie_btn";
            this.returnmovie_btn.Size = new System.Drawing.Size(80, 23);
            this.returnmovie_btn.TabIndex = 2;
            this.returnmovie_btn.Text = "Return Movie";
            this.returnmovie_btn.UseVisualStyleBackColor = true;
            this.returnmovie_btn.Click += new System.EventHandler(this.Returnmovie_btn_Click);
            // 
            // Show_Customer_log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.returnmovie_btn);
            this.Controls.Add(this.customerList_lv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Show_Customer_log";
            this.Text = "Show_Customer_log";
            this.Load += new System.EventHandler(this.Show_Customer_log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customerList_lv;
        private System.Windows.Forms.Button returnmovie_btn;
    }
}