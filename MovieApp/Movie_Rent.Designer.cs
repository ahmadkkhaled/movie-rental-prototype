namespace MovieApp
{
    partial class Movie_Rent
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
            this.customerList_cb = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Duration_nud = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.Duration_nud)).BeginInit();
            this.SuspendLayout();
            // 
            // customerList_cb
            // 
            this.customerList_cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.customerList_cb.FormattingEnabled = true;
            this.customerList_cb.Location = new System.Drawing.Point(83, 23);
            this.customerList_cb.Name = "customerList_cb";
            this.customerList_cb.Size = new System.Drawing.Size(121, 21);
            this.customerList_cb.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Rent!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Duration";
            // 
            // Duration_nud
            // 
            this.Duration_nud.Location = new System.Drawing.Point(83, 54);
            this.Duration_nud.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.Duration_nud.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Duration_nud.Name = "Duration_nud";
            this.Duration_nud.Size = new System.Drawing.Size(39, 20);
            this.Duration_nud.TabIndex = 5;
            this.Duration_nud.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Movie_Rent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 120);
            this.Controls.Add(this.Duration_nud);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customerList_cb);
            this.Name = "Movie_Rent";
            this.Text = "Movie_Rent";
            this.Load += new System.EventHandler(this.Movie_Rent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Duration_nud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox customerList_cb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Duration_nud;
    }
}