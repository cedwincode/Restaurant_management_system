namespace Restraunt_Management_System
{
    partial class Reservation_Form
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
            this.bt_back_cash = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_back_cash
            // 
            this.bt_back_cash.Location = new System.Drawing.Point(670, 30);
            this.bt_back_cash.Name = "bt_back_cash";
            this.bt_back_cash.Size = new System.Drawing.Size(94, 29);
            this.bt_back_cash.TabIndex = 0;
            this.bt_back_cash.Text = "back";
            this.bt_back_cash.UseVisualStyleBackColor = true;
            this.bt_back_cash.Click += new System.EventHandler(this.bt_back_cash_Click);
            // 
            // Reservation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_back_cash);
            this.Name = "Reservation_Form";
            this.Text = "Reservation_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt_back_cash;
    }
}