namespace Restraunt_Management_System
{
    partial class After_mngr_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(After_mngr_login));
            this.label1 = new System.Windows.Forms.Label();
            this.bt_back_login = new System.Windows.Forms.Button();
            this.bt_revenue_form = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_inventory_form = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(311, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager";
            // 
            // bt_back_login
            // 
            this.bt_back_login.BackColor = System.Drawing.Color.Black;
            this.bt_back_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_back_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back_login.Image = ((System.Drawing.Image)(resources.GetObject("bt_back_login.Image")));
            this.bt_back_login.Location = new System.Drawing.Point(14, 15);
            this.bt_back_login.Name = "bt_back_login";
            this.bt_back_login.Size = new System.Drawing.Size(51, 61);
            this.bt_back_login.TabIndex = 1;
            this.bt_back_login.UseVisualStyleBackColor = false;
            this.bt_back_login.Click += new System.EventHandler(this.bt_back_login_Click);
            // 
            // bt_revenue_form
            // 
            this.bt_revenue_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_revenue_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_revenue_form.Image = ((System.Drawing.Image)(resources.GetObject("bt_revenue_form.Image")));
            this.bt_revenue_form.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_revenue_form.Location = new System.Drawing.Point(151, 192);
            this.bt_revenue_form.Name = "bt_revenue_form";
            this.bt_revenue_form.Size = new System.Drawing.Size(127, 115);
            this.bt_revenue_form.TabIndex = 3;
            this.bt_revenue_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_revenue_form.UseVisualStyleBackColor = true;
            this.bt_revenue_form.Click += new System.EventHandler(this.bt_bill_form_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(161, 307);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 35);
            this.label2.TabIndex = 4;
            this.label2.Text = "Revenue";
            // 
            // bt_inventory_form
            // 
            this.bt_inventory_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_inventory_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_inventory_form.Image = ((System.Drawing.Image)(resources.GetObject("bt_inventory_form.Image")));
            this.bt_inventory_form.Location = new System.Drawing.Point(506, 192);
            this.bt_inventory_form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_inventory_form.Name = "bt_inventory_form";
            this.bt_inventory_form.Size = new System.Drawing.Size(141, 127);
            this.bt_inventory_form.TabIndex = 5;
            this.bt_inventory_form.UseVisualStyleBackColor = true;
            this.bt_inventory_form.Click += new System.EventHandler(this.bt_inventory_form_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(510, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 35);
            this.label3.TabIndex = 6;
            this.label3.Text = "Inventory";
            // 
            // After_mngr_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(816, 548);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_inventory_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bt_revenue_form);
            this.Controls.Add(this.bt_back_login);
            this.Controls.Add(this.label1);
            this.Name = "After_mngr_login";
            this.Text = "After_mngr_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button bt_back_login;
        private Button bt_revenue_form;
        private Label label2;
        private Button bt_inventory_form;
        private Label label3;
    }
}