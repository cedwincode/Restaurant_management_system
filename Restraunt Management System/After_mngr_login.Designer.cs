﻿namespace Restraunt_Management_System
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
            this.label1 = new System.Windows.Forms.Label();
            this.bt_back_login = new System.Windows.Forms.Button();
            this.bt_revenue_form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(336, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manager page";
            // 
            // bt_back_login
            // 
            this.bt_back_login.Location = new System.Drawing.Point(351, 409);
            this.bt_back_login.Name = "bt_back_login";
            this.bt_back_login.Size = new System.Drawing.Size(94, 29);
            this.bt_back_login.TabIndex = 1;
            this.bt_back_login.Text = "Back";
            this.bt_back_login.UseVisualStyleBackColor = true;
            this.bt_back_login.Click += new System.EventHandler(this.bt_back_login_Click);
            // 
            // bt_revenue_form
            // 
            this.bt_revenue_form.Image = global::Restraunt_Management_System.Properties.Resources.revenue_bt;
            this.bt_revenue_form.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bt_revenue_form.Location = new System.Drawing.Point(66, 139);
            this.bt_revenue_form.Name = "bt_revenue_form";
            this.bt_revenue_form.Size = new System.Drawing.Size(97, 98);
            this.bt_revenue_form.TabIndex = 3;
            this.bt_revenue_form.Text = "Revenue";
            this.bt_revenue_form.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bt_revenue_form.UseVisualStyleBackColor = true;
            this.bt_revenue_form.Click += new System.EventHandler(this.bt_bill_form_Click);
            // 
            // After_mngr_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}