namespace MovieApp
{
    partial class Add_Customer
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
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lable1 = new System.Windows.Forms.Label();
            this.cusName_tb = new System.Windows.Forms.TextBox();
            this.lable2 = new System.Windows.Forms.Label();
            this.cusBirthDate_tb = new System.Windows.Forms.Label();
            this.cusUserName_tb = new System.Windows.Forms.TextBox();
            this.sex_cb = new System.Windows.Forms.ComboBox();
            this.Year_cb = new System.Windows.Forms.ComboBox();
            this.Day_cb = new System.Windows.Forms.ComboBox();
            this.Month_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(273, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sign-up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Sex";
            // 
            // lable1
            // 
            this.lable1.AutoSize = true;
            this.lable1.Location = new System.Drawing.Point(22, 23);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(35, 13);
            this.lable1.TabIndex = 2;
            this.lable1.Text = "Name";
            this.lable1.Click += new System.EventHandler(this.Label2_Click);
            // 
            // cusName_tb
            // 
            this.cusName_tb.Location = new System.Drawing.Point(109, 20);
            this.cusName_tb.Name = "cusName_tb";
            this.cusName_tb.Size = new System.Drawing.Size(172, 20);
            this.cusName_tb.TabIndex = 3;
            this.cusName_tb.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lable2
            // 
            this.lable2.AutoSize = true;
            this.lable2.Location = new System.Drawing.Point(22, 57);
            this.lable2.Name = "lable2";
            this.lable2.Size = new System.Drawing.Size(55, 13);
            this.lable2.TabIndex = 4;
            this.lable2.Text = "Username";
            this.lable2.Click += new System.EventHandler(this.Password_Click);
            // 
            // cusBirthDate_tb
            // 
            this.cusBirthDate_tb.AutoSize = true;
            this.cusBirthDate_tb.Location = new System.Drawing.Point(22, 96);
            this.cusBirthDate_tb.Name = "cusBirthDate_tb";
            this.cusBirthDate_tb.Size = new System.Drawing.Size(54, 13);
            this.cusBirthDate_tb.TabIndex = 6;
            this.cusBirthDate_tb.Text = "Birth Date";
            this.cusBirthDate_tb.Click += new System.EventHandler(this.Label5_Click);
            // 
            // cusUserName_tb
            // 
            this.cusUserName_tb.Location = new System.Drawing.Point(109, 54);
            this.cusUserName_tb.Name = "cusUserName_tb";
            this.cusUserName_tb.Size = new System.Drawing.Size(172, 20);
            this.cusUserName_tb.TabIndex = 7;
            // 
            // sex_cb
            // 
            this.sex_cb.FormattingEnabled = true;
            this.sex_cb.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.sex_cb.Location = new System.Drawing.Point(109, 122);
            this.sex_cb.Name = "sex_cb";
            this.sex_cb.Size = new System.Drawing.Size(100, 21);
            this.sex_cb.TabIndex = 10;
            this.sex_cb.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // Year_cb
            // 
            this.Year_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Year_cb.FormattingEnabled = true;
            this.Year_cb.Items.AddRange(new object[] {
            "2000",
            "1999",
            "1998",
            "1997"});
            this.Year_cb.Location = new System.Drawing.Point(109, 88);
            this.Year_cb.Name = "Year_cb";
            this.Year_cb.Size = new System.Drawing.Size(56, 21);
            this.Year_cb.TabIndex = 11;
            // 
            // Day_cb
            // 
            this.Day_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Day_cb.FormattingEnabled = true;
            this.Day_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Day_cb.Location = new System.Drawing.Point(226, 88);
            this.Day_cb.Name = "Day_cb";
            this.Day_cb.Size = new System.Drawing.Size(55, 21);
            this.Day_cb.TabIndex = 12;
            this.Day_cb.SelectedIndexChanged += new System.EventHandler(this.ComboBox2_SelectedIndexChanged);
            // 
            // Month_cb
            // 
            this.Month_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Month_cb.FormattingEnabled = true;
            this.Month_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.Month_cb.Location = new System.Drawing.Point(171, 88);
            this.Month_cb.Name = "Month_cb";
            this.Month_cb.Size = new System.Drawing.Size(49, 21);
            this.Month_cb.TabIndex = 13;
            // 
            // Add_Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 196);
            this.Controls.Add(this.Month_cb);
            this.Controls.Add(this.Day_cb);
            this.Controls.Add(this.Year_cb);
            this.Controls.Add(this.sex_cb);
            this.Controls.Add(this.cusUserName_tb);
            this.Controls.Add(this.cusBirthDate_tb);
            this.Controls.Add(this.lable2);
            this.Controls.Add(this.cusName_tb);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Name = "Add_Customer";
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox cusName_tb;
        private System.Windows.Forms.Label lable2;
        private System.Windows.Forms.Label cusBirthDate_tb;
        private System.Windows.Forms.TextBox cusUserName_tb;
        private System.Windows.Forms.ComboBox sex_cb;
        private System.Windows.Forms.ComboBox Year_cb;
        private System.Windows.Forms.ComboBox Day_cb;
        private System.Windows.Forms.ComboBox Month_cb;
    }
}

