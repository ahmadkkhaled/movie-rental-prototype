namespace MovieApp
{
    partial class Admin_Register
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.admUsername_tb = new System.Windows.Forms.TextBox();
            this.admPassword_tb = new System.Windows.Forms.TextBox();
            this.admFirstName_tb = new System.Windows.Forms.TextBox();
            this.admLastName_tb = new System.Windows.Forms.TextBox();
            this.admSalary_tb = new System.Windows.Forms.TextBox();
            this.admSex_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.admYear_cb = new System.Windows.Forms.ComboBox();
            this.admMonth_tb = new System.Windows.Forms.ComboBox();
            this.admDay_cb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Birthdate";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Starting Salary";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "First Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Last Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Sex";
            // 
            // admUsername_tb
            // 
            this.admUsername_tb.Location = new System.Drawing.Point(124, 71);
            this.admUsername_tb.Name = "admUsername_tb";
            this.admUsername_tb.Size = new System.Drawing.Size(132, 20);
            this.admUsername_tb.TabIndex = 7;
            // 
            // admPassword_tb
            // 
            this.admPassword_tb.Location = new System.Drawing.Point(124, 95);
            this.admPassword_tb.Name = "admPassword_tb";
            this.admPassword_tb.Size = new System.Drawing.Size(132, 20);
            this.admPassword_tb.TabIndex = 8;
            // 
            // admFirstName_tb
            // 
            this.admFirstName_tb.Location = new System.Drawing.Point(124, 152);
            this.admFirstName_tb.Name = "admFirstName_tb";
            this.admFirstName_tb.Size = new System.Drawing.Size(132, 20);
            this.admFirstName_tb.TabIndex = 9;
            // 
            // admLastName_tb
            // 
            this.admLastName_tb.Location = new System.Drawing.Point(124, 183);
            this.admLastName_tb.Name = "admLastName_tb";
            this.admLastName_tb.Size = new System.Drawing.Size(132, 20);
            this.admLastName_tb.TabIndex = 10;
            // 
            // admSalary_tb
            // 
            this.admSalary_tb.Location = new System.Drawing.Point(124, 221);
            this.admSalary_tb.Name = "admSalary_tb";
            this.admSalary_tb.Size = new System.Drawing.Size(132, 20);
            this.admSalary_tb.TabIndex = 11;
            // 
            // admSex_cb
            // 
            this.admSex_cb.AutoCompleteCustomSource.AddRange(new string[] {
            "Male",
            "Female"});
            this.admSex_cb.FormattingEnabled = true;
            this.admSex_cb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.admSex_cb.Location = new System.Drawing.Point(124, 269);
            this.admSex_cb.Name = "admSex_cb";
            this.admSex_cb.Size = new System.Drawing.Size(132, 21);
            this.admSex_cb.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(393, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Sign-up";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // admYear_cb
            // 
            this.admYear_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admYear_cb.FormattingEnabled = true;
            this.admYear_cb.Items.AddRange(new object[] {
            "2001",
            "2000",
            "1999"});
            this.admYear_cb.Location = new System.Drawing.Point(124, 128);
            this.admYear_cb.Name = "admYear_cb";
            this.admYear_cb.Size = new System.Drawing.Size(48, 21);
            this.admYear_cb.TabIndex = 15;
            // 
            // admMonth_tb
            // 
            this.admMonth_tb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admMonth_tb.FormattingEnabled = true;
            this.admMonth_tb.Items.AddRange(new object[] {
            "12",
            "11",
            "10"});
            this.admMonth_tb.Location = new System.Drawing.Point(178, 128);
            this.admMonth_tb.Name = "admMonth_tb";
            this.admMonth_tb.Size = new System.Drawing.Size(36, 21);
            this.admMonth_tb.TabIndex = 16;
            // 
            // admDay_cb
            // 
            this.admDay_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admDay_cb.FormattingEnabled = true;
            this.admDay_cb.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.admDay_cb.Location = new System.Drawing.Point(220, 128);
            this.admDay_cb.Name = "admDay_cb";
            this.admDay_cb.Size = new System.Drawing.Size(36, 21);
            this.admDay_cb.TabIndex = 17;
            // 
            // Admin_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 324);
            this.Controls.Add(this.admDay_cb);
            this.Controls.Add(this.admMonth_tb);
            this.Controls.Add(this.admYear_cb);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.admSex_cb);
            this.Controls.Add(this.admSalary_tb);
            this.Controls.Add(this.admLastName_tb);
            this.Controls.Add(this.admFirstName_tb);
            this.Controls.Add(this.admPassword_tb);
            this.Controls.Add(this.admUsername_tb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Admin_Register";
            this.Text = "Admin_Register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox admUsername_tb;
        private System.Windows.Forms.TextBox admPassword_tb;
        private System.Windows.Forms.TextBox admFirstName_tb;
        private System.Windows.Forms.TextBox admLastName_tb;
        private System.Windows.Forms.TextBox admSalary_tb;
        private System.Windows.Forms.ComboBox admSex_cb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox admYear_cb;
        private System.Windows.Forms.ComboBox admMonth_tb;
        private System.Windows.Forms.ComboBox admDay_cb;
    }
}