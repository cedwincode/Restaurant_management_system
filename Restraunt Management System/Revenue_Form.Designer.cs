namespace Restraunt_Management_System
{
    partial class Revenue_Form
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revenue_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_rev = new System.Windows.Forms.DataGridView();
            this.bt_disp = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.from_dtp = new System.Windows.Forms.DateTimePicker();
            this.to_dtp = new System.Windows.Forms.DateTimePicker();
            this.bt_spec_disp = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_total = new System.Windows.Forms.Label();
            this.day_dtp = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.bt_get_total = new System.Windows.Forms.Button();
            this.cb_Beg = new System.Windows.Forms.ComboBox();
            this.cb_End = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bt_back_mngr = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rev)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(105, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue Statement";
            // 
            // dgv_rev
            // 
            this.dgv_rev.AllowUserToAddRows = false;
            this.dgv_rev.AllowUserToDeleteRows = false;
            this.dgv_rev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rev.BackgroundColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rev.Location = new System.Drawing.Point(31, 127);
            this.dgv_rev.Name = "dgv_rev";
            this.dgv_rev.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rev.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_rev.RowHeadersWidth = 51;
            this.dgv_rev.RowTemplate.Height = 29;
            this.dgv_rev.Size = new System.Drawing.Size(430, 205);
            this.dgv_rev.TabIndex = 1;
            this.dgv_rev.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgv_rev_CellFormatting);
            // 
            // bt_disp
            // 
            this.bt_disp.BackColor = System.Drawing.Color.LightGray;
            this.bt_disp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_disp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_disp.FlatAppearance.BorderSize = 2;
            this.bt_disp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_disp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_disp.ForeColor = System.Drawing.Color.Black;
            this.bt_disp.Location = new System.Drawing.Point(529, 425);
            this.bt_disp.Name = "bt_disp";
            this.bt_disp.Size = new System.Drawing.Size(104, 37);
            this.bt_disp.TabIndex = 2;
            this.bt_disp.Text = "Display All";
            this.bt_disp.UseVisualStyleBackColor = false;
            this.bt_disp.Click += new System.EventHandler(this.bt_disp_Click);
            this.bt_disp.MouseEnter += new System.EventHandler(this.bt_disp_MouseEnter);
            this.bt_disp.MouseLeave += new System.EventHandler(this.bt_disp_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(19, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(19, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // from_dtp
            // 
            this.from_dtp.Location = new System.Drawing.Point(101, 9);
            this.from_dtp.Name = "from_dtp";
            this.from_dtp.Size = new System.Drawing.Size(225, 27);
            this.from_dtp.TabIndex = 5;
            this.from_dtp.ValueChanged += new System.EventHandler(this.from_dtp_ValueChanged_1);
            this.from_dtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.from_dtp_KeyPress);
            // 
            // to_dtp
            // 
            this.to_dtp.Location = new System.Drawing.Point(101, 64);
            this.to_dtp.Name = "to_dtp";
            this.to_dtp.Size = new System.Drawing.Size(225, 27);
            this.to_dtp.TabIndex = 6;
            this.to_dtp.ValueChanged += new System.EventHandler(this.to_dtp_ValueChanged);
            this.to_dtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.to_dtp_KeyPress);
            // 
            // bt_spec_disp
            // 
            this.bt_spec_disp.BackColor = System.Drawing.Color.LightGray;
            this.bt_spec_disp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_spec_disp.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_spec_disp.FlatAppearance.BorderSize = 2;
            this.bt_spec_disp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_spec_disp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_spec_disp.ForeColor = System.Drawing.Color.Black;
            this.bt_spec_disp.Location = new System.Drawing.Point(658, 425);
            this.bt_spec_disp.Name = "bt_spec_disp";
            this.bt_spec_disp.Size = new System.Drawing.Size(94, 37);
            this.bt_spec_disp.TabIndex = 7;
            this.bt_spec_disp.Text = "Display Filter";
            this.bt_spec_disp.UseVisualStyleBackColor = false;
            this.bt_spec_disp.Click += new System.EventHandler(this.bt_spec_disp_Click);
            this.bt_spec_disp.MouseEnter += new System.EventHandler(this.bt_spec_disp_MouseEnter);
            this.bt_spec_disp.MouseLeave += new System.EventHandler(this.bt_spec_disp_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(3, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total amount(Day)";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_total.ForeColor = System.Drawing.Color.Lime;
            this.lb_total.Location = new System.Drawing.Point(144, 68);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(40, 18);
            this.lb_total.TabIndex = 9;
            this.lb_total.Text = "None";
            // 
            // day_dtp
            // 
            this.day_dtp.Location = new System.Drawing.Point(211, 61);
            this.day_dtp.Name = "day_dtp";
            this.day_dtp.Size = new System.Drawing.Size(227, 27);
            this.day_dtp.TabIndex = 10;
            this.day_dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.day_dtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.day_dtp_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(19, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total amount";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Cascadia Code", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.Color.Lime;
            this.total.Location = new System.Drawing.Point(149, 164);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(40, 18);
            this.total.TabIndex = 12;
            this.total.Text = "None";
            // 
            // bt_get_total
            // 
            this.bt_get_total.BackColor = System.Drawing.Color.LightGray;
            this.bt_get_total.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_get_total.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_get_total.FlatAppearance.BorderSize = 2;
            this.bt_get_total.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_get_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_get_total.ForeColor = System.Drawing.Color.Black;
            this.bt_get_total.Location = new System.Drawing.Point(232, 154);
            this.bt_get_total.Name = "bt_get_total";
            this.bt_get_total.Size = new System.Drawing.Size(94, 39);
            this.bt_get_total.TabIndex = 13;
            this.bt_get_total.Text = "Get Total";
            this.bt_get_total.UseVisualStyleBackColor = false;
            this.bt_get_total.Click += new System.EventHandler(this.bt_get_total_Click);
            this.bt_get_total.MouseEnter += new System.EventHandler(this.bt_get_total_MouseEnter);
            this.bt_get_total.MouseLeave += new System.EventHandler(this.bt_get_total_MouseLeave);
            // 
            // cb_Beg
            // 
            this.cb_Beg.FormattingEnabled = true;
            this.cb_Beg.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "300",
            "400",
            "500",
            "1000",
            "2000"});
            this.cb_Beg.Location = new System.Drawing.Point(149, 115);
            this.cb_Beg.Name = "cb_Beg";
            this.cb_Beg.Size = new System.Drawing.Size(71, 28);
            this.cb_Beg.TabIndex = 14;
            this.cb_Beg.TextChanged += new System.EventHandler(this.cb_Beg_TextChanged);
            this.cb_Beg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_Beg_KeyPress);
            // 
            // cb_End
            // 
            this.cb_End.FormattingEnabled = true;
            this.cb_End.Items.AddRange(new object[] {
            "50",
            "100",
            "150",
            "200",
            "300",
            "400",
            "500",
            "1000",
            "2000"});
            this.cb_End.Location = new System.Drawing.Point(255, 115);
            this.cb_End.Name = "cb_End";
            this.cb_End.Size = new System.Drawing.Size(71, 28);
            this.cb_End.TabIndex = 15;
            this.cb_End.TextChanged += new System.EventHandler(this.cb_End_TextChanged);
            this.cb_End.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_End_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(19, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(225, 117);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "To";
            // 
            // bt_back_mngr
            // 
            this.bt_back_mngr.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_back_mngr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back_mngr.Image = ((System.Drawing.Image)(resources.GetObject("bt_back_mngr.Image")));
            this.bt_back_mngr.Location = new System.Drawing.Point(14, 15);
            this.bt_back_mngr.Name = "bt_back_mngr";
            this.bt_back_mngr.Size = new System.Drawing.Size(57, 75);
            this.bt_back_mngr.TabIndex = 18;
            this.bt_back_mngr.UseVisualStyleBackColor = true;
            this.bt_back_mngr.Click += new System.EventHandler(this.bt_back_man_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(522, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(111, 35);
            this.label8.TabIndex = 19;
            this.label8.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.from_dtp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.bt_get_total);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.total);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.to_dtp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_Beg);
            this.panel1.Controls.Add(this.cb_End);
            this.panel1.Location = new System.Drawing.Point(510, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 205);
            this.panel1.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.Lime;
            this.label11.Location = new System.Drawing.Point(66, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 20);
            this.label11.TabIndex = 19;
            this.label11.Text = "+";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(66, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = "+";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.day_dtp);
            this.panel2.Location = new System.Drawing.Point(33, 357);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(444, 105);
            this.panel2.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.Lime;
            this.label12.Location = new System.Drawing.Point(190, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 20);
            this.label12.TabIndex = 20;
            this.label12.Text = "+";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(103, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(221, 25);
            this.label9.TabIndex = 22;
            this.label9.Text = "Select Specific Day";
            // 
            // Revenue_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(872, 477);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.bt_back_mngr);
            this.Controls.Add(this.bt_spec_disp);
            this.Controls.Add(this.bt_disp);
            this.Controls.Add(this.dgv_rev);
            this.Controls.Add(this.label1);
            this.Name = "Revenue_Form";
            this.Text = "Revenue_Form";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rev)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgv_rev;
        private Button bt_disp;
        private Label label2;
        private Label label3;
        private DateTimePicker from_dtp;
        private DateTimePicker to_dtp;
        private Button bt_spec_disp;
        private Label label4;
        private Label lb_total;
        private DateTimePicker day_dtp;
        private Label label5;
        private Label total;
        private Button bt_get_total;
        private ComboBox cb_Beg;
        private ComboBox cb_End;
        private Label label6;
        private Label label7;
        private Button bt_back_mngr;
        private Label label8;
        private Panel panel1;
        private Panel panel2;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label12;
    }
}