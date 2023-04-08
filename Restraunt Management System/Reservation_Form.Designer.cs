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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation_Form));
            this.bt_back_cash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_pno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_hr = new System.Windows.Forms.ComboBox();
            this.cbt = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bt_show_resev = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_clear = new System.Windows.Forms.Button();
            this.tb_tno = new System.Windows.Forms.TextBox();
            this.cb_min = new System.Windows.Forms.ComboBox();
            this.cb_nseat = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_back_cash
            // 
            this.bt_back_cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_back_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back_cash.Image = ((System.Drawing.Image)(resources.GetObject("bt_back_cash.Image")));
            this.bt_back_cash.Location = new System.Drawing.Point(14, 8);
            this.bt_back_cash.Name = "bt_back_cash";
            this.bt_back_cash.Size = new System.Drawing.Size(57, 71);
            this.bt_back_cash.TabIndex = 0;
            this.bt_back_cash.UseVisualStyleBackColor = true;
            this.bt_back_cash.Click += new System.EventHandler(this.bt_back_cash_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(167, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 52);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reservation Form";
            // 
            // tb_name
            // 
            this.tb_name.Location = new System.Drawing.Point(332, 130);
            this.tb_name.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(228, 27);
            this.tb_name.TabIndex = 2;
            this.tb_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_name_KeyPress);
            // 
            // tb_pno
            // 
            this.tb_pno.Location = new System.Drawing.Point(332, 202);
            this.tb_pno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_pno.Name = "tb_pno";
            this.tb_pno.Size = new System.Drawing.Size(228, 27);
            this.tb_pno.TabIndex = 3;
            this.tb_pno.TextChanged += new System.EventHandler(this.tb_pno_TextChanged);
            this.tb_pno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_pno_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(256, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 25);
            this.label2.TabIndex = 6;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(173, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(173, 272);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Table Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(147, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Number of Seats";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(332, 407);
            this.dtp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(228, 27);
            this.dtp.TabIndex = 10;
            this.dtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(260, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Date";
            // 
            // cb_hr
            // 
            this.cb_hr.FormattingEnabled = true;
            this.cb_hr.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8 ",
            "9",
            "10",
            "11",
            "12"});
            this.cb_hr.Location = new System.Drawing.Point(332, 466);
            this.cb_hr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_hr.Name = "cb_hr";
            this.cb_hr.Size = new System.Drawing.Size(61, 28);
            this.cb_hr.TabIndex = 12;
            this.cb_hr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_hr_KeyPress);
            // 
            // cbt
            // 
            this.cbt.FormattingEnabled = true;
            this.cbt.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.cbt.Location = new System.Drawing.Point(340, 366);
            this.cbt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbt.Name = "cbt";
            this.cbt.Size = new System.Drawing.Size(61, 28);
            this.cbt.TabIndex = 13;
            this.cbt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbt_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(260, 466);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 14;
            this.label7.Text = "Time";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(207, 416);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 62);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // bt_show_resev
            // 
            this.bt_show_resev.BackColor = System.Drawing.Color.Black;
            this.bt_show_resev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_show_resev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_show_resev.FlatAppearance.BorderSize = 2;
            this.bt_show_resev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_show_resev.Font = new System.Drawing.Font("Cascadia Code", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_show_resev.ForeColor = System.Drawing.Color.Lime;
            this.bt_show_resev.Location = new System.Drawing.Point(643, 527);
            this.bt_show_resev.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_show_resev.Name = "bt_show_resev";
            this.bt_show_resev.Size = new System.Drawing.Size(134, 51);
            this.bt_show_resev.TabIndex = 16;
            this.bt_show_resev.Text = "Reservation";
            this.bt_show_resev.UseVisualStyleBackColor = false;
            this.bt_show_resev.Click += new System.EventHandler(this.bt_show_resev_Click);
            this.bt_show_resev.MouseEnter += new System.EventHandler(this.bt_show_resev_MouseEnter);
            this.bt_show_resev.MouseLeave += new System.EventHandler(this.bt_show_resev_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bt_clear);
            this.panel1.Controls.Add(this.tb_tno);
            this.panel1.Controls.Add(this.cb_min);
            this.panel1.Controls.Add(this.cb_nseat);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbt);
            this.panel1.Location = new System.Drawing.Point(125, 99);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 494);
            this.panel1.TabIndex = 17;
            // 
            // bt_clear
            // 
            this.bt_clear.BackColor = System.Drawing.Color.DarkRed;
            this.bt_clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_clear.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bt_clear.FlatAppearance.BorderSize = 2;
            this.bt_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_clear.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bt_clear.ForeColor = System.Drawing.Color.Black;
            this.bt_clear.Location = new System.Drawing.Point(315, 416);
            this.bt_clear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_clear.Name = "bt_clear";
            this.bt_clear.Size = new System.Drawing.Size(102, 62);
            this.bt_clear.TabIndex = 19;
            this.bt_clear.Text = "Clear";
            this.bt_clear.UseVisualStyleBackColor = false;
            this.bt_clear.Click += new System.EventHandler(this.bt_clear_Click);
            this.bt_clear.MouseEnter += new System.EventHandler(this.bt_clear_MouseEnter);
            this.bt_clear.MouseLeave += new System.EventHandler(this.bt_clear_MouseLeave);
            // 
            // tb_tno
            // 
            this.tb_tno.Location = new System.Drawing.Point(206, 170);
            this.tb_tno.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tb_tno.Name = "tb_tno";
            this.tb_tno.PlaceholderText = "1-50";
            this.tb_tno.Size = new System.Drawing.Size(62, 27);
            this.tb_tno.TabIndex = 18;
            this.tb_tno.TextChanged += new System.EventHandler(this.tb_tno_TextChanged);
            this.tb_tno.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_tno_KeyPress);
            // 
            // cb_min
            // 
            this.cb_min.FormattingEnabled = true;
            this.cb_min.Items.AddRange(new object[] {
            "00",
            "15",
            "30",
            "45"});
            this.cb_min.Location = new System.Drawing.Point(273, 366);
            this.cb_min.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_min.Name = "cb_min";
            this.cb_min.Size = new System.Drawing.Size(61, 28);
            this.cb_min.TabIndex = 17;
            this.cb_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_min_KeyPress);
            // 
            // cb_nseat
            // 
            this.cb_nseat.FormattingEnabled = true;
            this.cb_nseat.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6"});
            this.cb_nseat.Location = new System.Drawing.Point(207, 232);
            this.cb_nseat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nseat.Name = "cb_nseat";
            this.cb_nseat.Size = new System.Drawing.Size(61, 28);
            this.cb_nseat.TabIndex = 16;
            this.cb_nseat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_nseat_KeyPress);
            // 
            // Reservation_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 641);
            this.Controls.Add(this.bt_show_resev);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_hr);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_pno);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_back_cash);
            this.Controls.Add(this.panel1);
            this.Name = "Reservation_Form";
            this.Text = "Reservation_Form";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button bt_back_cash;
        private Label label1;
        private TextBox tb_name;
        private TextBox tb_pno;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtp;
        private Label label6;
        private ComboBox cb_hr;
        private ComboBox cbt;
        private Label label7;
        private Button button1;
        private Button bt_show_resev;
        private Panel panel1;
        private ComboBox cb_min;
        private ComboBox cb_nseat;
        private TextBox tb_tno;
        private Button bt_clear;
    }
}