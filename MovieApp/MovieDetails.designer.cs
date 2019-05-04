namespace MovieApp
{
    partial class MovieDetails
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
            this.pic_pb = new System.Windows.Forms.PictureBox();
            this.name_lbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.name_tb = new System.Windows.Forms.TextBox();
            this.description_tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pgRate_tb = new System.Windows.Forms.TextBox();
            this.price_ntb = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.duration_ntb = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.picPath_tb = new System.Windows.Forms.TextBox();
            this.browsePic_btn = new System.Windows.Forms.Button();
            this.year_tb = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.category_cb = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rentMovie_btn = new System.Windows.Forms.Button();
            this.rate_lbl = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.qty_ntb = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pic_pb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_ntb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration_ntb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_tb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_ntb)).BeginInit();
            this.SuspendLayout();
            // 
            // pic_pb
            // 
            this.pic_pb.Location = new System.Drawing.Point(355, 57);
            this.pic_pb.Name = "pic_pb";
            this.pic_pb.Size = new System.Drawing.Size(256, 289);
            this.pic_pb.TabIndex = 0;
            this.pic_pb.TabStop = false;
            // 
            // name_lbl
            // 
            this.name_lbl.AutoSize = true;
            this.name_lbl.Font = new System.Drawing.Font("Impact", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_lbl.Location = new System.Drawing.Point(7, 9);
            this.name_lbl.Name = "name_lbl";
            this.name_lbl.Size = new System.Drawing.Size(214, 45);
            this.name_lbl.TabIndex = 1;
            this.name_lbl.Text = "Movie Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // name_tb
            // 
            this.name_tb.Location = new System.Drawing.Point(129, 78);
            this.name_tb.Name = "name_tb";
            this.name_tb.Size = new System.Drawing.Size(210, 20);
            this.name_tb.TabIndex = 6;
            // 
            // description_tb
            // 
            this.description_tb.Location = new System.Drawing.Point(129, 104);
            this.description_tb.Multiline = true;
            this.description_tb.Name = "description_tb";
            this.description_tb.Size = new System.Drawing.Size(210, 47);
            this.description_tb.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Description";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "PG Rating";
            // 
            // pgRate_tb
            // 
            this.pgRate_tb.Location = new System.Drawing.Point(129, 157);
            this.pgRate_tb.Name = "pgRate_tb";
            this.pgRate_tb.Size = new System.Drawing.Size(210, 20);
            this.pgRate_tb.TabIndex = 10;
            // 
            // price_ntb
            // 
            this.price_ntb.DecimalPlaces = 2;
            this.price_ntb.Location = new System.Drawing.Point(129, 183);
            this.price_ntb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.price_ntb.Name = "price_ntb";
            this.price_ntb.Size = new System.Drawing.Size(210, 20);
            this.price_ntb.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Price";
            // 
            // duration_ntb
            // 
            this.duration_ntb.Location = new System.Drawing.Point(129, 237);
            this.duration_ntb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.duration_ntb.Name = "duration_ntb";
            this.duration_ntb.Size = new System.Drawing.Size(210, 20);
            this.duration_ntb.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Duration (in minutes)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 266);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Picture Path";
            // 
            // picPath_tb
            // 
            this.picPath_tb.Enabled = false;
            this.picPath_tb.Location = new System.Drawing.Point(129, 263);
            this.picPath_tb.Name = "picPath_tb";
            this.picPath_tb.Size = new System.Drawing.Size(129, 20);
            this.picPath_tb.TabIndex = 16;
            // 
            // browsePic_btn
            // 
            this.browsePic_btn.Location = new System.Drawing.Point(264, 263);
            this.browsePic_btn.Name = "browsePic_btn";
            this.browsePic_btn.Size = new System.Drawing.Size(75, 22);
            this.browsePic_btn.TabIndex = 17;
            this.browsePic_btn.Text = "Browse";
            this.browsePic_btn.UseVisualStyleBackColor = true;
            this.browsePic_btn.Click += new System.EventHandler(this.browsePic_btn_Click);
            // 
            // year_tb
            // 
            this.year_tb.Location = new System.Drawing.Point(129, 288);
            this.year_tb.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.year_tb.Name = "year_tb";
            this.year_tb.Size = new System.Drawing.Size(210, 20);
            this.year_tb.TabIndex = 18;
            this.year_tb.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Year";
            // 
            // category_cb
            // 
            this.category_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.category_cb.FormattingEnabled = true;
            this.category_cb.Location = new System.Drawing.Point(129, 315);
            this.category_cb.Name = "category_cb";
            this.category_cb.Size = new System.Drawing.Size(210, 21);
            this.category_cb.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 318);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Category";
            // 
            // rentMovie_btn
            // 
            this.rentMovie_btn.Location = new System.Drawing.Point(536, 12);
            this.rentMovie_btn.Name = "rentMovie_btn";
            this.rentMovie_btn.Size = new System.Drawing.Size(75, 23);
            this.rentMovie_btn.TabIndex = 23;
            this.rentMovie_btn.Text = "Rent Movie";
            this.rentMovie_btn.UseVisualStyleBackColor = true;
            this.rentMovie_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // rate_lbl
            // 
            this.rate_lbl.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rate_lbl.Location = new System.Drawing.Point(355, 349);
            this.rate_lbl.Name = "rate_lbl";
            this.rate_lbl.Size = new System.Drawing.Size(256, 16);
            this.rate_lbl.TabIndex = 24;
            this.rate_lbl.Text = "4.5★";
            this.rate_lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(254, 342);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(85, 23);
            this.button3.TabIndex = 25;
            this.button3.Text = "Save Changes";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(164, 342);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 23);
            this.button4.TabIndex = 26;
            this.button4.Text = "Delete Movie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // qty_ntb
            // 
            this.qty_ntb.Location = new System.Drawing.Point(129, 209);
            this.qty_ntb.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.qty_ntb.Name = "qty_ntb";
            this.qty_ntb.Size = new System.Drawing.Size(210, 20);
            this.qty_ntb.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 211);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Quantity";
            // 
            // MovieDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 375);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qty_ntb);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.rate_lbl);
            this.Controls.Add(this.rentMovie_btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.category_cb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.year_tb);
            this.Controls.Add(this.browsePic_btn);
            this.Controls.Add(this.picPath_tb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.duration_ntb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.price_ntb);
            this.Controls.Add(this.pgRate_tb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.description_tb);
            this.Controls.Add(this.name_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.name_lbl);
            this.Controls.Add(this.pic_pb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MovieDetails";
            this.Text = "MovieDetails";
            this.Load += new System.EventHandler(this.MovieDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_pb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.price_ntb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.duration_ntb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.year_tb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty_ntb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pic_pb;
        private System.Windows.Forms.Label name_lbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox name_tb;
        private System.Windows.Forms.TextBox description_tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pgRate_tb;
        private System.Windows.Forms.NumericUpDown price_ntb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown duration_ntb;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox picPath_tb;
        private System.Windows.Forms.Button browsePic_btn;
        private System.Windows.Forms.NumericUpDown year_tb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox category_cb;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button rentMovie_btn;
        private System.Windows.Forms.Label rate_lbl;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown qty_ntb;
        private System.Windows.Forms.Label label1;
    }
}