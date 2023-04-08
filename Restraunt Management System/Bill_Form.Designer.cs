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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_b_id = new System.Windows.Forms.TextBox();
            this.cb_ftype = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_fqty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_dtype = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_dqty = new System.Windows.Forms.ComboBox();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.rb_member = new System.Windows.Forms.RadioButton();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_disp = new System.Windows.Forms.Button();
            this.bill_dgv = new System.Windows.Forms.DataGridView();
            this.bt_back_cash = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_display = new System.Windows.Forms.Button();
            this.tb_search_bill = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.tb_date = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bill_dgv)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(18, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill Id";
            // 
            // tb_b_id
            // 
            this.tb_b_id.BackColor = System.Drawing.Color.LightGray;
            this.tb_b_id.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_b_id.Location = new System.Drawing.Point(107, 19);
            this.tb_b_id.Name = "tb_b_id";
            this.tb_b_id.Size = new System.Drawing.Size(151, 25);
            this.tb_b_id.TabIndex = 1;
            this.tb_b_id.TextChanged += new System.EventHandler(this.tb_b_id_TextChanged_1);
            this.tb_b_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_b_id_KeyPress);
            // 
            // cb_ftype
            // 
            this.cb_ftype.BackColor = System.Drawing.Color.LightGray;
            this.cb_ftype.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_ftype.FormattingEnabled = true;
            this.cb_ftype.Items.AddRange(new object[] {
            "Sorpotel Rs120",
            "Pork Vindaloo Rs120",
            "Bebinca Rs80",
            "Dodol Rs80",
            "Ros omlet Rs25",
            "Cupcake Rs10",
            "Fried Rice Rs60",
            "Dosa Rs35"});
            this.cb_ftype.Location = new System.Drawing.Point(107, 75);
            this.cb_ftype.Name = "cb_ftype";
            this.cb_ftype.Size = new System.Drawing.Size(151, 25);
            this.cb_ftype.TabIndex = 2;
            this.cb_ftype.TextChanged += new System.EventHandler(this.cb_ftype_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(-2, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Food Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Food Qty";
            // 
            // cb_fqty
            // 
            this.cb_fqty.BackColor = System.Drawing.Color.LightGray;
            this.cb_fqty.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_fqty.FormattingEnabled = true;
            this.cb_fqty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_fqty.Location = new System.Drawing.Point(107, 140);
            this.cb_fqty.Name = "cb_fqty";
            this.cb_fqty.Size = new System.Drawing.Size(151, 25);
            this.cb_fqty.TabIndex = 5;
            this.cb_fqty.TextChanged += new System.EventHandler(this.cb_fqty_TextChanged);
            this.cb_fqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_fqty_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Lime;
            this.label4.Location = new System.Drawing.Point(283, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Drink Type";
            // 
            // cb_dtype
            // 
            this.cb_dtype.BackColor = System.Drawing.Color.LightGray;
            this.cb_dtype.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_dtype.FormattingEnabled = true;
            this.cb_dtype.Items.AddRange(new object[] {
            "Tea Rs10",
            "Coffee Rs15",
            "Sprite 200ml Rs15",
            "Pepsi 200ml Rs15",
            "Maaza 200ml Rs25",
            "Lassi Rs15",
            "Coke 200ml Rs20"});
            this.cb_dtype.Location = new System.Drawing.Point(424, 24);
            this.cb_dtype.Name = "cb_dtype";
            this.cb_dtype.Size = new System.Drawing.Size(151, 25);
            this.cb_dtype.TabIndex = 7;
            this.cb_dtype.TextChanged += new System.EventHandler(this.cb_dtype_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(283, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Drink Qty";
            // 
            // cb_dqty
            // 
            this.cb_dqty.BackColor = System.Drawing.Color.LightGray;
            this.cb_dqty.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb_dqty.FormattingEnabled = true;
            this.cb_dqty.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cb_dqty.Location = new System.Drawing.Point(424, 77);
            this.cb_dqty.Name = "cb_dqty";
            this.cb_dqty.Size = new System.Drawing.Size(151, 25);
            this.cb_dqty.TabIndex = 9;
            this.cb_dqty.TextChanged += new System.EventHandler(this.cb_dqty_TextChanged);
            this.cb_dqty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cb_dqty_KeyPress);
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.BackColor = System.Drawing.Color.Black;
            this.rb_none.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.rb_none.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_none.ForeColor = System.Drawing.Color.Lime;
            this.rb_none.Location = new System.Drawing.Point(421, 139);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(66, 24);
            this.rb_none.TabIndex = 10;
            this.rb_none.TabStop = true;
            this.rb_none.Text = "None";
            this.rb_none.UseVisualStyleBackColor = false;
            // 
            // rb_member
            // 
            this.rb_member.AutoSize = true;
            this.rb_member.FlatAppearance.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.rb_member.Font = new System.Drawing.Font("Cascadia Code", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb_member.ForeColor = System.Drawing.Color.Lime;
            this.rb_member.Location = new System.Drawing.Point(491, 139);
            this.rb_member.Name = "rb_member";
            this.rb_member.Size = new System.Drawing.Size(84, 24);
            this.rb_member.TabIndex = 11;
            this.rb_member.TabStop = true;
            this.rb_member.Text = "Member";
            this.rb_member.UseVisualStyleBackColor = true;
            // 
            // bt_add
            // 
            this.bt_add.BackColor = System.Drawing.Color.LightGray;
            this.bt_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_add.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_add.ForeColor = System.Drawing.Color.Black;
            this.bt_add.Location = new System.Drawing.Point(622, 13);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(94, 45);
            this.bt_add.TabIndex = 12;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = false;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            this.bt_add.MouseEnter += new System.EventHandler(this.bt_add_MouseEnter);
            this.bt_add.MouseLeave += new System.EventHandler(this.bt_add_MouseLeave);
            // 
            // bt_del
            // 
            this.bt_del.BackColor = System.Drawing.Color.LightGray;
            this.bt_del.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_del.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_del.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_del.ForeColor = System.Drawing.Color.Black;
            this.bt_del.Location = new System.Drawing.Point(622, 69);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(94, 45);
            this.bt_del.TabIndex = 13;
            this.bt_del.Text = "Delete";
            this.bt_del.UseVisualStyleBackColor = false;
            this.bt_del.Click += new System.EventHandler(this.button2_Click);
            this.bt_del.MouseEnter += new System.EventHandler(this.bt_del_MouseEnter);
            this.bt_del.MouseLeave += new System.EventHandler(this.bt_del_MouseLeave);
            // 
            // bt_disp
            // 
            this.bt_disp.BackColor = System.Drawing.Color.LightGray;
            this.bt_disp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_disp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_disp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_disp.ForeColor = System.Drawing.Color.Black;
            this.bt_disp.Location = new System.Drawing.Point(818, 119);
            this.bt_disp.Name = "bt_disp";
            this.bt_disp.Size = new System.Drawing.Size(94, 45);
            this.bt_disp.TabIndex = 15;
            this.bt_disp.Text = "Search Bill";
            this.bt_disp.UseVisualStyleBackColor = false;
            this.bt_disp.Click += new System.EventHandler(this.bt_search_bill_Click);
            this.bt_disp.MouseEnter += new System.EventHandler(this.bt_disp_MouseEnter);
            this.bt_disp.MouseLeave += new System.EventHandler(this.bt_disp_MouseLeave);
            // 
            // bill_dgv
            // 
            this.bill_dgv.AllowUserToAddRows = false;
            this.bill_dgv.AllowUserToDeleteRows = false;
            this.bill_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bill_dgv.BackgroundColor = System.Drawing.Color.Black;
            this.bill_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bill_dgv.GridColor = System.Drawing.Color.Black;
            this.bill_dgv.Location = new System.Drawing.Point(11, 275);
            this.bill_dgv.Name = "bill_dgv";
            this.bill_dgv.ReadOnly = true;
            this.bill_dgv.RowHeadersWidth = 51;
            this.bill_dgv.RowTemplate.Height = 29;
            this.bill_dgv.Size = new System.Drawing.Size(926, 283);
            this.bill_dgv.TabIndex = 16;
            this.bill_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.bill_dgv_CellFormatting);
            // 
            // bt_back_cash
            // 
            this.bt_back_cash.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_back_cash.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back_cash.Image = ((System.Drawing.Image)(resources.GetObject("bt_back_cash.Image")));
            this.bt_back_cash.Location = new System.Drawing.Point(11, 12);
            this.bt_back_cash.Name = "bt_back_cash";
            this.bt_back_cash.Size = new System.Drawing.Size(51, 57);
            this.bt_back_cash.TabIndex = 17;
            this.bt_back_cash.UseVisualStyleBackColor = true;
            this.bt_back_cash.Click += new System.EventHandler(this.bt_back_cash_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Lime;
            this.label6.Location = new System.Drawing.Point(101, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 22);
            this.label6.TabIndex = 18;
            this.label6.Text = "Date";
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(354, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 40);
            this.label7.TabIndex = 21;
            this.label7.Text = "Bill Generator";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.bt_display);
            this.panel1.Controls.Add(this.tb_search_bill);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tb_b_id);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cb_ftype);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cb_fqty);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.bt_disp);
            this.panel1.Controls.Add(this.cb_dtype);
            this.panel1.Controls.Add(this.bt_del);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bt_add);
            this.panel1.Controls.Add(this.cb_dqty);
            this.panel1.Controls.Add(this.rb_member);
            this.panel1.Controls.Add(this.rb_none);
            this.panel1.Location = new System.Drawing.Point(14, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(927, 189);
            this.panel1.TabIndex = 22;
            // 
            // bt_display
            // 
            this.bt_display.BackColor = System.Drawing.Color.LightGray;
            this.bt_display.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_display.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_display.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_display.ForeColor = System.Drawing.Color.Black;
            this.bt_display.Location = new System.Drawing.Point(622, 124);
            this.bt_display.Name = "bt_display";
            this.bt_display.Size = new System.Drawing.Size(94, 45);
            this.bt_display.TabIndex = 23;
            this.bt_display.Text = "Display";
            this.bt_display.UseVisualStyleBackColor = false;
            this.bt_display.Click += new System.EventHandler(this.bt_display_Click);
            this.bt_display.MouseEnter += new System.EventHandler(this.bt_display_MouseEnter);
            this.bt_display.MouseLeave += new System.EventHandler(this.bt_display_MouseLeave);
            // 
            // tb_search_bill
            // 
            this.tb_search_bill.BackColor = System.Drawing.Color.LightGray;
            this.tb_search_bill.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_search_bill.Location = new System.Drawing.Point(818, 77);
            this.tb_search_bill.Name = "tb_search_bill";
            this.tb_search_bill.Size = new System.Drawing.Size(93, 25);
            this.tb_search_bill.TabIndex = 22;
            this.tb_search_bill.TextChanged += new System.EventHandler(this.tb_search_bill_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(283, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 27);
            this.label8.TabIndex = 21;
            this.label8.Text = "Membership";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(611, 23);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(177, 27);
            this.dtp.TabIndex = 20;
            this.dtp.Visible = false;
            // 
            // tb_date
            // 
            this.tb_date.BackColor = System.Drawing.Color.LightGray;
            this.tb_date.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_date.Location = new System.Drawing.Point(169, 25);
            this.tb_date.Name = "tb_date";
            this.tb_date.Size = new System.Drawing.Size(151, 25);
            this.tb_date.TabIndex = 19;
            this.tb_date.Visible = false;
            // 
            // Bill_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(954, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bt_back_cash);
            this.Controls.Add(this.bill_dgv);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.tb_date);
            this.Name = "Bill_Form";
            this.Text = "Bill_Form";
            ((System.ComponentModel.ISupportInitialize)(this.bill_dgv)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox tb_b_id;
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
        private Label label7;
        private Panel panel1;
        private Label label8;
        private TextBox tb_search_bill;
        private Button bt_display;
        private DateTimePicker dtp;
        private TextBox tb_date;
    }
}