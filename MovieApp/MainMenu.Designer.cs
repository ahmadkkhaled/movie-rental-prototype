namespace MovieApp
{
    partial class MainMenu
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
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.movieLog_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(151, 120);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Admin";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(350, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(149, 120);
            this.button5.TabIndex = 4;
            this.button5.Text = "Customers";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // movieLog_btn
            // 
            this.movieLog_btn.Location = new System.Drawing.Point(169, 12);
            this.movieLog_btn.Name = "movieLog_btn";
            this.movieLog_btn.Size = new System.Drawing.Size(175, 120);
            this.movieLog_btn.TabIndex = 5;
            this.movieLog_btn.Text = "Movies";
            this.movieLog_btn.UseVisualStyleBackColor = true;
            this.movieLog_btn.Click += new System.EventHandler(this.movieLog_btn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 144);
            this.Controls.Add(this.movieLog_btn);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button movieLog_btn;
    }
}