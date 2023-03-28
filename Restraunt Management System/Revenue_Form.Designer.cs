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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Revenue_Form));
            label1 = new Label();
            dgv_rev = new DataGridView();
            bt_disp = new Button();
            label2 = new Label();
            label3 = new Label();
            from_dtp = new DateTimePicker();
            to_dtp = new DateTimePicker();
            bt_spec_disp = new Button();
            label4 = new Label();
            lb_total = new Label();
            day_dtp = new DateTimePicker();
            label5 = new Label();
            total = new Label();
            bt_get_total = new Button();
            cb_Beg = new ComboBox();
            cb_End = new ComboBox();
            label6 = new Label();
            label7 = new Label();
            bt_back_mngr = new Button();
            label8 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgv_rev).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(130, 65);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 0;
            label1.Text = "Revenue Statement";
            label1.Click += label1_Click;
            // 
            // dgv_rev
            // 
            dgv_rev.AllowUserToAddRows = false;
            dgv_rev.AllowUserToDeleteRows = false;
            dgv_rev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_rev.BackgroundColor = Color.Black;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgv_rev.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgv_rev.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_rev.Location = new Point(27, 95);
            dgv_rev.Margin = new Padding(3, 2, 3, 2);
            dgv_rev.Name = "dgv_rev";
            dgv_rev.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv_rev.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv_rev.RowHeadersWidth = 51;
            dgv_rev.RowTemplate.Height = 29;
            dgv_rev.Size = new Size(376, 154);
            dgv_rev.TabIndex = 1;
            dgv_rev.CellContentClick += dgv_rev_CellContentClick;
            // 
            // bt_disp
            // 
            bt_disp.Location = new Point(446, 325);
            bt_disp.Margin = new Padding(3, 2, 3, 2);
            bt_disp.Name = "bt_disp";
            bt_disp.Size = new Size(82, 22);
            bt_disp.TabIndex = 2;
            bt_disp.Text = "Display All";
            bt_disp.UseVisualStyleBackColor = true;
            bt_disp.Click += bt_disp_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(17, 12);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 3;
            label2.Text = "From";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(17, 53);
            label3.Name = "label3";
            label3.Size = new Size(21, 16);
            label3.TabIndex = 4;
            label3.Text = "To";
            // 
            // from_dtp
            // 
            from_dtp.Location = new Point(114, 7);
            from_dtp.Margin = new Padding(3, 2, 3, 2);
            from_dtp.Name = "from_dtp";
            from_dtp.Size = new Size(156, 23);
            from_dtp.TabIndex = 5;
            from_dtp.ValueChanged += from_dtp_ValueChanged;
            // 
            // to_dtp
            // 
            to_dtp.Location = new Point(114, 48);
            to_dtp.Margin = new Padding(3, 2, 3, 2);
            to_dtp.Name = "to_dtp";
            to_dtp.Size = new Size(156, 23);
            to_dtp.TabIndex = 6;
            // 
            // bt_spec_disp
            // 
            bt_spec_disp.Location = new Point(562, 325);
            bt_spec_disp.Margin = new Padding(3, 2, 3, 2);
            bt_spec_disp.Name = "bt_spec_disp";
            bt_spec_disp.Size = new Size(82, 22);
            bt_spec_disp.TabIndex = 7;
            bt_spec_disp.Text = "Display Filter";
            bt_spec_disp.UseVisualStyleBackColor = true;
            bt_spec_disp.Click += bt_spec_disp_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(3, 51);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 8;
            label4.Text = "Total amount(Day)";
            // 
            // lb_total
            // 
            lb_total.AutoSize = true;
            lb_total.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            lb_total.ForeColor = Color.Lime;
            lb_total.Location = new Point(118, 51);
            lb_total.Name = "lb_total";
            lb_total.Size = new Size(31, 15);
            lb_total.TabIndex = 9;
            lb_total.Text = "None";
            lb_total.Click += lb_total_Click;
            // 
            // day_dtp
            // 
            day_dtp.Location = new Point(155, 45);
            day_dtp.Margin = new Padding(3, 2, 3, 2);
            day_dtp.Name = "day_dtp";
            day_dtp.Size = new Size(194, 23);
            day_dtp.TabIndex = 10;
            day_dtp.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(17, 123);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 11;
            label5.Text = "Total amount";
            // 
            // total
            // 
            total.AutoSize = true;
            total.Font = new Font("Cascadia Code", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            total.ForeColor = Color.Lime;
            total.Location = new Point(114, 123);
            total.Name = "total";
            total.Size = new Size(31, 15);
            total.TabIndex = 12;
            total.Text = "None";
            // 
            // bt_get_total
            // 
            bt_get_total.Location = new Point(183, 119);
            bt_get_total.Margin = new Padding(3, 2, 3, 2);
            bt_get_total.Name = "bt_get_total";
            bt_get_total.Size = new Size(82, 22);
            bt_get_total.TabIndex = 13;
            bt_get_total.Text = "Get Total";
            bt_get_total.UseVisualStyleBackColor = true;
            bt_get_total.Click += bt_get_total_Click;
            // 
            // cb_Beg
            // 
            cb_Beg.FormattingEnabled = true;
            cb_Beg.Items.AddRange(new object[] { "50", "100", "150", "200", "300", "400", "500", "1000", "2000" });
            cb_Beg.Location = new Point(114, 86);
            cb_Beg.Margin = new Padding(3, 2, 3, 2);
            cb_Beg.Name = "cb_Beg";
            cb_Beg.Size = new Size(63, 23);
            cb_Beg.TabIndex = 14;
            cb_Beg.SelectedIndexChanged += cb_Beg_SelectedIndexChanged;
            // 
            // cb_End
            // 
            cb_End.FormattingEnabled = true;
            cb_End.Items.AddRange(new object[] { "50", "100", "150", "200", "300", "400", "500", "1000", "2000" });
            cb_End.Location = new Point(210, 86);
            cb_End.Margin = new Padding(3, 2, 3, 2);
            cb_End.Name = "cb_End";
            cb_End.Size = new Size(63, 23);
            cb_End.TabIndex = 15;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(17, 93);
            label6.Name = "label6";
            label6.Size = new Size(91, 16);
            label6.TabIndex = 16;
            label6.Text = "Amount Range";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(183, 88);
            label7.Name = "label7";
            label7.Size = new Size(21, 16);
            label7.TabIndex = 17;
            label7.Text = "To";
            // 
            // bt_back_mngr
            // 
            bt_back_mngr.FlatStyle = FlatStyle.Flat;
            bt_back_mngr.Image = (Image)resources.GetObject("bt_back_mngr.Image");
            bt_back_mngr.Location = new Point(12, 11);
            bt_back_mngr.Margin = new Padding(3, 2, 3, 2);
            bt_back_mngr.Name = "bt_back_mngr";
            bt_back_mngr.Size = new Size(50, 56);
            bt_back_mngr.TabIndex = 18;
            bt_back_mngr.UseVisualStyleBackColor = true;
            bt_back_mngr.Click += bt_back_man_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Lime;
            label8.Location = new Point(446, 65);
            label8.Name = "label8";
            label8.Size = new Size(84, 28);
            label8.TabIndex = 19;
            label8.Text = "Filter";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(from_dtp);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(bt_get_total);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(total);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(to_dtp);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cb_Beg);
            panel1.Controls.Add(cb_End);
            panel1.Location = new Point(446, 95);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(305, 154);
            panel1.TabIndex = 20;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(lb_total);
            panel2.Controls.Add(day_dtp);
            panel2.Location = new Point(29, 268);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 79);
            panel2.TabIndex = 21;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = Color.Lime;
            label9.Location = new Point(90, 13);
            label9.Name = "label9";
            label9.Size = new Size(180, 20);
            label9.TabIndex = 22;
            label9.Text = "Select Specific Day";
            // 
            // Revenue_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(763, 358);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label8);
            Controls.Add(bt_back_mngr);
            Controls.Add(bt_spec_disp);
            Controls.Add(bt_disp);
            Controls.Add(dgv_rev);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Revenue_Form";
            Text = "Revenue_Form";
            Load += Revenue_Form_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_rev).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
    }
}