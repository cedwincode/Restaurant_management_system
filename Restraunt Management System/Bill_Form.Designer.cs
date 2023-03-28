namespace Restraunt_Management_System
{
    partial class Bill_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bill_Form));
            label1 = new Label();
            tb_id = new TextBox();
            cb_ftype = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            cb_fqty = new ComboBox();
            label4 = new Label();
            cb_dtype = new ComboBox();
            label5 = new Label();
            cb_dqty = new ComboBox();
            rb_none = new RadioButton();
            rb_member = new RadioButton();
            bt_add = new Button();
            bt_del = new Button();
            bt_disp = new Button();
            bill_dgv = new DataGridView();
            bt_back_cash = new Button();
            label6 = new Label();
            tb_date = new TextBox();
            dtp = new DateTimePicker();
            label7 = new Label();
            panel1 = new Panel();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)bill_dgv).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(14, 14);
            label1.Name = "label1";
            label1.Size = new Size(24, 17);
            label1.TabIndex = 0;
            label1.Text = "Id";
            label1.Click += label1_Click;
            // 
            // tb_id
            // 
            tb_id.BackColor = Color.LightGray;
            tb_id.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_id.Location = new Point(94, 14);
            tb_id.Margin = new Padding(3, 2, 3, 2);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(133, 22);
            tb_id.TabIndex = 1;
            tb_id.TextChanged += tb_id_TextChanged;
            // 
            // cb_ftype
            // 
            cb_ftype.BackColor = Color.LightGray;
            cb_ftype.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_ftype.FormattingEnabled = true;
            cb_ftype.Items.AddRange(new object[] { "Ros omlet Rs25", "Cupcake Rs10", "Fried Rice Rs60", "Pork Roast Rs120", "Dosa Rs35" });
            cb_ftype.Location = new Point(94, 56);
            cb_ftype.Margin = new Padding(3, 2, 3, 2);
            cb_ftype.Name = "cb_ftype";
            cb_ftype.Size = new Size(133, 22);
            cb_ftype.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(14, 58);
            label2.Name = "label2";
            label2.Size = new Size(80, 17);
            label2.TabIndex = 3;
            label2.Text = "Food Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(14, 106);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 4;
            label3.Text = "Food Qty";
            // 
            // cb_fqty
            // 
            cb_fqty.BackColor = Color.LightGray;
            cb_fqty.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_fqty.FormattingEnabled = true;
            cb_fqty.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cb_fqty.Location = new Point(94, 104);
            cb_fqty.Margin = new Padding(3, 2, 3, 2);
            cb_fqty.Name = "cb_fqty";
            cb_fqty.Size = new Size(133, 22);
            cb_fqty.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(238, 62);
            label4.Name = "label4";
            label4.Size = new Size(88, 17);
            label4.TabIndex = 6;
            label4.Text = "Drink Type";
            // 
            // cb_dtype
            // 
            cb_dtype.BackColor = Color.LightGray;
            cb_dtype.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_dtype.FormattingEnabled = true;
            cb_dtype.Items.AddRange(new object[] { "Sprite 200ml Rs15", "Pepsi 200ml Rs15", "Maaza 200ml Rs25", "Lassi Rs15", "Coke 200ml Rs20" });
            cb_dtype.Location = new Point(329, 56);
            cb_dtype.Margin = new Padding(3, 2, 3, 2);
            cb_dtype.Name = "cb_dtype";
            cb_dtype.Size = new Size(133, 22);
            cb_dtype.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(238, 106);
            label5.Name = "label5";
            label5.Size = new Size(80, 17);
            label5.TabIndex = 8;
            label5.Text = "Drink Qty";
            // 
            // cb_dqty
            // 
            cb_dqty.BackColor = Color.LightGray;
            cb_dqty.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            cb_dqty.FormattingEnabled = true;
            cb_dqty.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            cb_dqty.Location = new Point(329, 104);
            cb_dqty.Margin = new Padding(3, 2, 3, 2);
            cb_dqty.Name = "cb_dqty";
            cb_dqty.Size = new Size(133, 22);
            cb_dqty.TabIndex = 9;
            // 
            // rb_none
            // 
            rb_none.AutoSize = true;
            rb_none.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rb_none.ForeColor = Color.Lime;
            rb_none.Location = new Point(484, 79);
            rb_none.Margin = new Padding(3, 2, 3, 2);
            rb_none.Name = "rb_none";
            rb_none.Size = new Size(53, 20);
            rb_none.TabIndex = 10;
            rb_none.TabStop = true;
            rb_none.Text = "None";
            rb_none.UseVisualStyleBackColor = true;
            // 
            // rb_member
            // 
            rb_member.AutoSize = true;
            rb_member.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            rb_member.ForeColor = Color.Lime;
            rb_member.Location = new Point(484, 103);
            rb_member.Margin = new Padding(3, 2, 3, 2);
            rb_member.Name = "rb_member";
            rb_member.Size = new Size(67, 20);
            rb_member.TabIndex = 11;
            rb_member.TabStop = true;
            rb_member.Text = "Member";
            rb_member.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            bt_add.Location = new Point(726, 12);
            bt_add.Margin = new Padding(3, 2, 3, 2);
            bt_add.Name = "bt_add";
            bt_add.Size = new Size(82, 22);
            bt_add.TabIndex = 12;
            bt_add.Text = "Add";
            bt_add.UseVisualStyleBackColor = true;
            bt_add.Click += bt_add_Click;
            bt_add.MouseEnter += bt_add_MouseEnter;
            bt_add.MouseLeave += bt_add_MouseLeave;
            // 
            // bt_del
            // 
            bt_del.Location = new Point(726, 55);
            bt_del.Margin = new Padding(3, 2, 3, 2);
            bt_del.Name = "bt_del";
            bt_del.Size = new Size(82, 22);
            bt_del.TabIndex = 13;
            bt_del.Text = "Delete";
            bt_del.UseVisualStyleBackColor = true;
            bt_del.Click += button2_Click;
            bt_del.MouseEnter += bt_del_MouseEnter;
            bt_del.MouseLeave += bt_del_MouseLeave;
            // 
            // bt_disp
            // 
            bt_disp.Location = new Point(726, 100);
            bt_disp.Margin = new Padding(3, 2, 3, 2);
            bt_disp.Name = "bt_disp";
            bt_disp.Size = new Size(82, 22);
            bt_disp.TabIndex = 15;
            bt_disp.Text = "Display";
            bt_disp.UseVisualStyleBackColor = true;
            bt_disp.Click += bt_disp_Click;
            // 
            // bill_dgv
            // 
            bill_dgv.AllowUserToAddRows = false;
            bill_dgv.AllowUserToDeleteRows = false;
            bill_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            bill_dgv.BackgroundColor = Color.Black;
            bill_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bill_dgv.Location = new Point(10, 206);
            bill_dgv.Margin = new Padding(3, 2, 3, 2);
            bill_dgv.Name = "bill_dgv";
            bill_dgv.ReadOnly = true;
            bill_dgv.RowHeadersWidth = 51;
            bill_dgv.RowTemplate.Height = 29;
            bill_dgv.Size = new Size(810, 212);
            bill_dgv.TabIndex = 16;
            bill_dgv.CellContentClick += bill_dgv_CellContentClick;
            // 
            // bt_back_cash
            // 
            bt_back_cash.FlatStyle = FlatStyle.Flat;
            bt_back_cash.Image = (Image)resources.GetObject("bt_back_cash.Image");
            bt_back_cash.Location = new Point(10, 9);
            bt_back_cash.Margin = new Padding(3, 2, 3, 2);
            bt_back_cash.Name = "bt_back_cash";
            bt_back_cash.Size = new Size(45, 43);
            bt_back_cash.TabIndex = 17;
            bt_back_cash.UseVisualStyleBackColor = true;
            bt_back_cash.Click += bt_back_cash_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(238, 15);
            label6.Name = "label6";
            label6.Size = new Size(40, 17);
            label6.TabIndex = 18;
            label6.Text = "Date";
            // 
            // tb_date
            // 
            tb_date.BackColor = Color.LightGray;
            tb_date.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            tb_date.Location = new Point(329, 12);
            tb_date.Margin = new Padding(3, 2, 3, 2);
            tb_date.Name = "tb_date";
            tb_date.Size = new Size(133, 22);
            tb_date.TabIndex = 19;
            // 
            // dtp
            // 
            dtp.Location = new Point(484, 12);
            dtp.Margin = new Padding(3, 2, 3, 2);
            dtp.Name = "dtp";
            dtp.Size = new Size(155, 23);
            dtp.TabIndex = 20;
            dtp.ValueChanged += dtp_ValueChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Cascadia Code", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Lime;
            label7.Location = new Point(310, 9);
            label7.Name = "label7";
            label7.Size = new Size(210, 32);
            label7.TabIndex = 21;
            label7.Text = "Bill Generator";
            label7.Click += label7_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(label8);
            panel1.Controls.Add(tb_id);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(dtp);
            panel1.Controls.Add(cb_ftype);
            panel1.Controls.Add(tb_date);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(cb_fqty);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(bt_disp);
            panel1.Controls.Add(cb_dtype);
            panel1.Controls.Add(bt_del);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(bt_add);
            panel1.Controls.Add(cb_dqty);
            panel1.Controls.Add(rb_member);
            panel1.Controls.Add(rb_none);
            panel1.Location = new Point(12, 60);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(811, 135);
            panel1.TabIndex = 22;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = Color.Lime;
            label8.Location = new Point(484, 55);
            label8.Name = "label8";
            label8.Size = new Size(99, 20);
            label8.TabIndex = 21;
            label8.Text = "Membership";
            // 
            // Bill_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(835, 426);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(bt_back_cash);
            Controls.Add(bill_dgv);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Bill_Form";
            Text = "Bill_Form";
            ((System.ComponentModel.ISupportInitialize)bill_dgv).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_id;
        private ComboBox cb_ftype;
        private Label label2;
        private Label label3;
        private ComboBox cb_fqty;
        private Label label4;
        private ComboBox cb_dtype;
        private Label label5;
        private ComboBox cb_dqty;
        private RadioButton rb_none;
        private RadioButton rb_member;
        private Button bt_add;
        private Button bt_del;
        private Button bt_disp;
        private DataGridView bill_dgv;
        private Button bt_back_cash;
        private Label label6;
        private TextBox tb_date;
        private DateTimePicker dtp;
        private Label label7;
        private Panel panel1;
        private Label label8;
    }
}