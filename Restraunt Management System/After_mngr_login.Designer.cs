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
            label1 = new Label();
            bt_back_login = new Button();
            bt_revenue_form = new Button();
            label2 = new Label();
            bt_inventory_form = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(253, 7);
            label1.Name = "label1";
            label1.Size = new Size(136, 39);
            label1.TabIndex = 0;
            label1.Text = "Manager";
            // 
            // bt_back_login
            // 
            bt_back_login.BackColor = Color.Black;
            bt_back_login.FlatStyle = FlatStyle.Flat;
            bt_back_login.Image = (Image)resources.GetObject("bt_back_login.Image");
            bt_back_login.Location = new Point(12, 11);
            bt_back_login.Margin = new Padding(3, 2, 3, 2);
            bt_back_login.Name = "bt_back_login";
            bt_back_login.Size = new Size(45, 46);
            bt_back_login.TabIndex = 1;
            bt_back_login.UseVisualStyleBackColor = false;
            bt_back_login.Click += bt_back_login_Click;
            // 
            // bt_revenue_form
            // 
            bt_revenue_form.FlatStyle = FlatStyle.Flat;
            bt_revenue_form.Image = (Image)resources.GetObject("bt_revenue_form.Image");
            bt_revenue_form.ImageAlign = ContentAlignment.TopCenter;
            bt_revenue_form.Location = new Point(126, 194);
            bt_revenue_form.Margin = new Padding(3, 2, 3, 2);
            bt_revenue_form.Name = "bt_revenue_form";
            bt_revenue_form.Size = new Size(107, 99);
            bt_revenue_form.TabIndex = 3;
            bt_revenue_form.TextAlign = ContentAlignment.BottomCenter;
            bt_revenue_form.UseVisualStyleBackColor = true;
            bt_revenue_form.Click += bt_bill_form_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(131, 295);
            label2.Name = "label2";
            label2.Size = new Size(96, 28);
            label2.TabIndex = 4;
            label2.Text = "Revenue";
            // 
            // bt_inventory_form
            // 
            bt_inventory_form.FlatStyle = FlatStyle.Flat;
            bt_inventory_form.Image = (Image)resources.GetObject("bt_inventory_form.Image");
            bt_inventory_form.Location = new Point(434, 194);
            bt_inventory_form.Name = "bt_inventory_form";
            bt_inventory_form.Size = new Size(123, 99);
            bt_inventory_form.TabIndex = 5;
            bt_inventory_form.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(437, 296);
            label3.Name = "label3";
            label3.Size = new Size(120, 28);
            label3.TabIndex = 6;
            label3.Text = "Inventory";
            // 
            // After_mngr_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(714, 411);
            Controls.Add(label3);
            Controls.Add(bt_inventory_form);
            Controls.Add(label2);
            Controls.Add(bt_revenue_form);
            Controls.Add(bt_back_login);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "After_mngr_login";
            Text = "After_mngr_login";
            ResumeLayout(false);
            PerformLayout();
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