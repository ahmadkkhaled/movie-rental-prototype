namespace MovieApp
{
    partial class AddMovie
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
            this.movName_tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.movDesc_tb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.movPrice_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.movPG_tb = new System.Windows.Forms.TextBox();
            this.movDuration_tb = new System.Windows.Forms.TextBox();
            this.movPoster_tb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.movQuantity_tb = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.movCategory_cb = new System.Windows.Forms.ComboBox();
            this.movAdd_button = new System.Windows.Forms.Button();
            this.movYear_tb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // movName_tb
            // 
            this.movName_tb.Location = new System.Drawing.Point(123, 57);
            this.movName_tb.Name = "movName_tb";
            this.movName_tb.Size = new System.Drawing.Size(210, 20);
            this.movName_tb.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Movie Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Description";
            // 
            // movDesc_tb
            // 
            this.movDesc_tb.Location = new System.Drawing.Point(123, 87);
            this.movDesc_tb.Multiline = true;
            this.movDesc_tb.Name = "movDesc_tb";
            this.movDesc_tb.Size = new System.Drawing.Size(210, 54);
            this.movDesc_tb.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Year";
            // 
            // movPrice_tb
            // 
            this.movPrice_tb.Location = new System.Drawing.Point(123, 179);
            this.movPrice_tb.Name = "movPrice_tb";
            this.movPrice_tb.Size = new System.Drawing.Size(210, 20);
            this.movPrice_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PG Rating";
            // 
            // movPG_tb
            // 
            this.movPG_tb.Location = new System.Drawing.Point(123, 213);
            this.movPG_tb.Name = "movPG_tb";
            this.movPG_tb.Size = new System.Drawing.Size(210, 20);
            this.movPG_tb.TabIndex = 10;
            // 
            // movDuration_tb
            // 
            this.movDuration_tb.Location = new System.Drawing.Point(123, 240);
            this.movDuration_tb.Name = "movDuration_tb";
            this.movDuration_tb.Size = new System.Drawing.Size(210, 20);
            this.movDuration_tb.TabIndex = 11;
            // 
            // movPoster_tb
            // 
            this.movPoster_tb.Enabled = false;
            this.movPoster_tb.Location = new System.Drawing.Point(123, 267);
            this.movPoster_tb.Name = "movPoster_tb";
            this.movPoster_tb.Size = new System.Drawing.Size(129, 20);
            this.movPoster_tb.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Duration (in minutes)";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(258, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 275);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Poster";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Initial quatntity";
            // 
            // movQuantity_tb
            // 
            this.movQuantity_tb.Location = new System.Drawing.Point(123, 303);
            this.movQuantity_tb.Name = "movQuantity_tb";
            this.movQuantity_tb.Size = new System.Drawing.Size(210, 20);
            this.movQuantity_tb.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 340);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Catrgory";
            // 
            // movCategory_cb
            // 
            this.movCategory_cb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.movCategory_cb.FormattingEnabled = true;
            this.movCategory_cb.Location = new System.Drawing.Point(123, 332);
            this.movCategory_cb.Name = "movCategory_cb";
            this.movCategory_cb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.movCategory_cb.Size = new System.Drawing.Size(210, 21);
            this.movCategory_cb.TabIndex = 19;
            // 
            // movAdd_button
            // 
            this.movAdd_button.Location = new System.Drawing.Point(257, 360);
            this.movAdd_button.Name = "movAdd_button";
            this.movAdd_button.Size = new System.Drawing.Size(75, 23);
            this.movAdd_button.TabIndex = 20;
            this.movAdd_button.Text = "Add";
            this.movAdd_button.UseVisualStyleBackColor = true;
            this.movAdd_button.Click += new System.EventHandler(this.MovAdd_button_Click);
            // 
            // movYear_tb
            // 
            this.movYear_tb.Location = new System.Drawing.Point(123, 150);
            this.movYear_tb.Name = "movYear_tb";
            this.movYear_tb.Size = new System.Drawing.Size(210, 20);
            this.movYear_tb.TabIndex = 6;
            // 
            // AddMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 398);
            this.Controls.Add(this.movAdd_button);
            this.Controls.Add(this.movCategory_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.movQuantity_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.movPoster_tb);
            this.Controls.Add(this.movDuration_tb);
            this.Controls.Add(this.movPG_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movPrice_tb);
            this.Controls.Add(this.movYear_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movDesc_tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.movName_tb);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "AddMovie";
            this.Text = "AddMovie";
            this.Load += new System.EventHandler(this.AddMovie_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox movName_tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movDesc_tb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox movPrice_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox movPG_tb;
        private System.Windows.Forms.TextBox movDuration_tb;
        private System.Windows.Forms.TextBox movPoster_tb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox movQuantity_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox movCategory_cb;
        private System.Windows.Forms.Button movAdd_button;
        private System.Windows.Forms.TextBox movYear_tb;
    }
}