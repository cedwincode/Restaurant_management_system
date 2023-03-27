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
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rev)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Revenue Statement";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgv_rev
            // 
            this.dgv_rev.AllowUserToAddRows = false;
            this.dgv_rev.AllowUserToDeleteRows = false;
            this.dgv_rev.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_rev.BackgroundColor = System.Drawing.Color.SandyBrown;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_rev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_rev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rev.Location = new System.Drawing.Point(12, 40);
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
            this.dgv_rev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_rev_CellContentClick);
            // 
            // bt_disp
            // 
            this.bt_disp.Location = new System.Drawing.Point(620, 371);
            this.bt_disp.Name = "bt_disp";
            this.bt_disp.Size = new System.Drawing.Size(94, 29);
            this.bt_disp.TabIndex = 2;
            this.bt_disp.Text = "Display";
            this.bt_disp.UseVisualStyleBackColor = true;
            this.bt_disp.Click += new System.EventHandler(this.bt_disp_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "To";
            // 
            // from_dtp
            // 
            this.from_dtp.Location = new System.Drawing.Point(133, 3);
            this.from_dtp.Name = "from_dtp";
            this.from_dtp.Size = new System.Drawing.Size(178, 27);
            this.from_dtp.TabIndex = 5;
            this.from_dtp.ValueChanged += new System.EventHandler(this.from_dtp_ValueChanged);
            // 
            // to_dtp
            // 
            this.to_dtp.Location = new System.Drawing.Point(133, 42);
            this.to_dtp.Name = "to_dtp";
            this.to_dtp.Size = new System.Drawing.Size(178, 27);
            this.to_dtp.TabIndex = 6;
            // 
            // bt_spec_disp
            // 
            this.bt_spec_disp.Location = new System.Drawing.Point(734, 371);
            this.bt_spec_disp.Name = "bt_spec_disp";
            this.bt_spec_disp.Size = new System.Drawing.Size(94, 29);
            this.bt_spec_disp.TabIndex = 7;
            this.bt_spec_disp.Text = "S Display";
            this.bt_spec_disp.UseVisualStyleBackColor = true;
            this.bt_spec_disp.Click += new System.EventHandler(this.bt_spec_disp_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(13, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Total amount(Day)";
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_total.ForeColor = System.Drawing.Color.Black;
            this.lb_total.Location = new System.Drawing.Point(161, 22);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(45, 20);
            this.lb_total.TabIndex = 9;
            this.lb_total.Text = "None";
            // 
            // day_dtp
            // 
            this.day_dtp.Location = new System.Drawing.Point(223, 17);
            this.day_dtp.Name = "day_dtp";
            this.day_dtp.Size = new System.Drawing.Size(178, 27);
            this.day_dtp.TabIndex = 10;
            this.day_dtp.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(13, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Total amount";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.total.ForeColor = System.Drawing.Color.Black;
            this.total.Location = new System.Drawing.Point(161, 65);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(45, 20);
            this.total.TabIndex = 12;
            this.total.Text = "None";
            // 
            // bt_get_total
            // 
            this.bt_get_total.Location = new System.Drawing.Point(223, 61);
            this.bt_get_total.Name = "bt_get_total";
            this.bt_get_total.Size = new System.Drawing.Size(94, 29);
            this.bt_get_total.TabIndex = 13;
            this.bt_get_total.Text = "Get Total";
            this.bt_get_total.UseVisualStyleBackColor = true;
            this.bt_get_total.Click += new System.EventHandler(this.bt_get_total_Click);
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
            this.cb_Beg.Location = new System.Drawing.Point(133, 85);
            this.cb_Beg.Name = "cb_Beg";
            this.cb_Beg.Size = new System.Drawing.Size(71, 28);
            this.cb_Beg.TabIndex = 14;
            this.cb_Beg.SelectedIndexChanged += new System.EventHandler(this.cb_Beg_SelectedIndexChanged);
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
            this.cb_End.Location = new System.Drawing.Point(240, 85);
            this.cb_End.Name = "cb_End";
            this.cb_End.Size = new System.Drawing.Size(71, 28);
            this.cb_End.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "Amount Range";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(209, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "To";
            // 
            // bt_back_mngr
            // 
            this.bt_back_mngr.Location = new System.Drawing.Point(778, -1);
            this.bt_back_mngr.Name = "bt_back_mngr";
            this.bt_back_mngr.Size = new System.Drawing.Size(94, 29);
            this.bt_back_mngr.TabIndex = 18;
            this.bt_back_mngr.Text = "Back";
            this.bt_back_mngr.UseVisualStyleBackColor = true;
            this.bt_back_mngr.Click += new System.EventHandler(this.bt_back_man_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(773, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 25);
            this.label8.TabIndex = 19;
            this.label8.Text = "Filter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SandyBrown;
            this.panel1.Controls.Add(this.from_dtp);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.to_dtp);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cb_Beg);
            this.panel1.Controls.Add(this.cb_End);
            this.panel1.Location = new System.Drawing.Point(510, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(318, 125);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SandyBrown;
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lb_total);
            this.panel2.Controls.Add(this.day_dtp);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.bt_get_total);
            this.panel2.Controls.Add(this.total);
            this.panel2.Location = new System.Drawing.Point(12, 275);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(430, 125);
            this.panel2.TabIndex = 21;
            // 
            // Revenue_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 478);
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
            this.Load += new System.EventHandler(this.Revenue_Form_Load);
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
    }
}