namespace MovieApp
{
    partial class Customer_List
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
            this.delete_button = new System.Windows.Forms.Button();
            this.showLog_button = new System.Windows.Forms.Button();
            this.regCustomer_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerList_lv
            // 
            this.customerList_lv.FullRowSelect = true;
            this.customerList_lv.GridLines = true;
            this.customerList_lv.Location = new System.Drawing.Point(12, 36);
            this.customerList_lv.MultiSelect = false;
            this.customerList_lv.Name = "customerList_lv";
            this.customerList_lv.Size = new System.Drawing.Size(788, 414);
            this.customerList_lv.TabIndex = 0;
            this.customerList_lv.UseCompatibleStateImageBehavior = false;
            this.customerList_lv.View = System.Windows.Forms.View.Details;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(0, 1);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(64, 29);
            this.delete_button.TabIndex = 1;
            this.delete_button.Text = "Delete";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // showLog_button
            // 
            this.showLog_button.Location = new System.Drawing.Point(70, 1);
            this.showLog_button.Name = "showLog_button";
            this.showLog_button.Size = new System.Drawing.Size(68, 29);
            this.showLog_button.TabIndex = 2;
            this.showLog_button.Text = "Show Log";
            this.showLog_button.UseVisualStyleBackColor = true;
            this.showLog_button.Click += new System.EventHandler(this.ShowLog_button_Click);
            // 
            // regCustomer_btn
            // 
            this.regCustomer_btn.Location = new System.Drawing.Point(172, 7);
            this.regCustomer_btn.Name = "regCustomer_btn";
            this.regCustomer_btn.Size = new System.Drawing.Size(115, 23);
            this.regCustomer_btn.TabIndex = 3;
            this.regCustomer_btn.Text = "Register Customer";
            this.regCustomer_btn.UseVisualStyleBackColor = true;
            this.regCustomer_btn.Click += new System.EventHandler(this.regCustomer_btn_Click);
            // 
            // Customer_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.regCustomer_btn);
            this.Controls.Add(this.showLog_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.customerList_lv);
            this.Name = "Customer_List";
            this.Text = "Customer_List";
            this.Load += new System.EventHandler(this.Customer_List_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView customerList_lv;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button showLog_button;
        private System.Windows.Forms.Button regCustomer_btn;
    }
}