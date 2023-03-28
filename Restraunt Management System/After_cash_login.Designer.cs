namespace Restraunt_Management_System
{
    partial class After_cash_login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(After_cash_login));
            label1 = new Label();
            bt_back_login = new Button();
            bt_bill_form = new Button();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(253, 9);
            label1.Name = "label1";
            label1.Size = new Size(136, 39);
            label1.TabIndex = 0;
            label1.Text = "Cashier";
            // 
            // bt_back_login
            // 
            bt_back_login.FlatStyle = FlatStyle.Flat;
            bt_back_login.Image = (Image)resources.GetObject("bt_back_login.Image");
            bt_back_login.Location = new Point(12, 5);
            bt_back_login.Margin = new Padding(3, 2, 3, 2);
            bt_back_login.Name = "bt_back_login";
            bt_back_login.Size = new Size(51, 62);
            bt_back_login.TabIndex = 1;
            bt_back_login.UseVisualStyleBackColor = true;
            bt_back_login.Click += bt_back_login_Click;
            // 
            // bt_bill_form
            // 
            bt_bill_form.FlatStyle = FlatStyle.Flat;
            bt_bill_form.Image = (Image)resources.GetObject("bt_bill_form.Image");
            bt_bill_form.ImageAlign = ContentAlignment.TopCenter;
            bt_bill_form.Location = new Point(126, 194);
            bt_bill_form.Margin = new Padding(3, 2, 3, 2);
            bt_bill_form.Name = "bt_bill_form";
            bt_bill_form.Size = new Size(101, 106);
            bt_bill_form.TabIndex = 2;
            bt_bill_form.TextAlign = ContentAlignment.BottomCenter;
            bt_bill_form.UseVisualStyleBackColor = true;
            bt_bill_form.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(149, 302);
            label2.Name = "label2";
            label2.Size = new Size(60, 28);
            label2.TabIndex = 3;
            label2.Text = "Bill";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(435, 193);
            button1.Name = "button1";
            button1.Size = new Size(106, 106);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(418, 302);
            label3.Name = "label3";
            label3.Size = new Size(144, 28);
            label3.TabIndex = 5;
            label3.Text = "Reservation";
            // 
            // After_cash_login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(714, 411);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(bt_bill_form);
            Controls.Add(bt_back_login);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "After_cash_login";
            Text = "After_cash_login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button bt_back_login;
        private Button bt_bill_form;
        private Label label2;
        private Button button1;
        private Label label3;
    }
}