namespace Restraunt_Management_System
{
    partial class Reservation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reservation));
            label1 = new Label();
            dtp = new DateTimePicker();
            Res_dgv = new DataGridView();
            label2 = new Label();
            bt_back_resr_form = new Button();
            bt_ch_reserv = new Button();
            bt_show_all = new Button();
            tb_r_id = new TextBox();
            bt_cancel = new Button();
            label3 = new Label();
            bt_res = new Button();
            ((System.ComponentModel.ISupportInitialize)Res_dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(311, 12);
            label1.Name = "label1";
            label1.Size = new Size(204, 39);
            label1.TabIndex = 0;
            label1.Text = "Reservation";
            // 
            // dtp
            // 
            dtp.Location = new Point(146, 94);
            dtp.Name = "dtp";
            dtp.Size = new Size(200, 23);
            dtp.TabIndex = 1;
            dtp.KeyPress += dtp_KeyPress;
            // 
            // Res_dgv
            // 
            Res_dgv.AllowUserToAddRows = false;
            Res_dgv.AllowUserToDeleteRows = false;
            Res_dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Res_dgv.BackgroundColor = Color.White;
            Res_dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Res_dgv.Location = new Point(35, 154);
            Res_dgv.Name = "Res_dgv";
            Res_dgv.ReadOnly = true;
            Res_dgv.RowHeadersWidth = 51;
            Res_dgv.RowTemplate.Height = 25;
            Res_dgv.Size = new Size(743, 208);
            Res_dgv.TabIndex = 2;
            Res_dgv.CellFormatting += Res_dgv_CellFormatting;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(36, 98);
            label2.Name = "label2";
            label2.Size = new Size(96, 17);
            label2.TabIndex = 3;
            label2.Text = "Select Date";
            // 
            // bt_back_resr_form
            // 
            bt_back_resr_form.Cursor = Cursors.Hand;
            bt_back_resr_form.FlatStyle = FlatStyle.Flat;
            bt_back_resr_form.Image = (Image)resources.GetObject("bt_back_resr_form.Image");
            bt_back_resr_form.Location = new Point(12, 12);
            bt_back_resr_form.Name = "bt_back_resr_form";
            bt_back_resr_form.Size = new Size(49, 52);
            bt_back_resr_form.TabIndex = 4;
            bt_back_resr_form.UseVisualStyleBackColor = true;
            bt_back_resr_form.Click += bt_back_resr_form_Click;
            // 
            // bt_ch_reserv
            // 
            bt_ch_reserv.BackColor = Color.WhiteSmoke;
            bt_ch_reserv.FlatAppearance.BorderColor = Color.Black;
            bt_ch_reserv.FlatAppearance.BorderSize = 2;
            bt_ch_reserv.FlatStyle = FlatStyle.Flat;
            bt_ch_reserv.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_ch_reserv.ForeColor = Color.Black;
            bt_ch_reserv.Location = new Point(351, 92);
            bt_ch_reserv.Margin = new Padding(3, 2, 3, 2);
            bt_ch_reserv.Name = "bt_ch_reserv";
            bt_ch_reserv.Size = new Size(114, 25);
            bt_ch_reserv.TabIndex = 5;
            bt_ch_reserv.Text = "Check All (Day)";
            bt_ch_reserv.UseVisualStyleBackColor = false;
            bt_ch_reserv.Click += bt_ch_reserv_Click;
            bt_ch_reserv.MouseEnter += bt_ch_reserv_MouseEnter;
            bt_ch_reserv.MouseLeave += bt_ch_reserv_MouseLeave;
            // 
            // bt_show_all
            // 
            bt_show_all.BackColor = Color.WhiteSmoke;
            bt_show_all.FlatAppearance.BorderColor = Color.Black;
            bt_show_all.FlatAppearance.BorderSize = 2;
            bt_show_all.FlatStyle = FlatStyle.Flat;
            bt_show_all.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_show_all.Location = new Point(691, 92);
            bt_show_all.Margin = new Padding(3, 2, 3, 2);
            bt_show_all.Name = "bt_show_all";
            bt_show_all.Size = new Size(87, 25);
            bt_show_all.TabIndex = 6;
            bt_show_all.Text = "Display all";
            bt_show_all.UseVisualStyleBackColor = false;
            bt_show_all.Click += bt_show_all_Click;
            bt_show_all.MouseEnter += bt_show_all_MouseEnter;
            bt_show_all.MouseLeave += bt_show_all_MouseLeave;
            // 
            // tb_r_id
            // 
            tb_r_id.Location = new Point(119, 128);
            tb_r_id.Margin = new Padding(3, 2, 3, 2);
            tb_r_id.Name = "tb_r_id";
            tb_r_id.Size = new Size(110, 23);
            tb_r_id.TabIndex = 7;
            tb_r_id.TextChanged += tb_r_id_TextChanged;
            tb_r_id.KeyPress += tb_r_id_KeyPress;
            // 
            // bt_cancel
            // 
            bt_cancel.BackColor = Color.DarkRed;
            bt_cancel.FlatAppearance.BorderColor = Color.Maroon;
            bt_cancel.FlatAppearance.BorderSize = 2;
            bt_cancel.FlatStyle = FlatStyle.Flat;
            bt_cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_cancel.ForeColor = Color.Black;
            bt_cancel.Location = new Point(234, 128);
            bt_cancel.Margin = new Padding(3, 2, 3, 2);
            bt_cancel.Name = "bt_cancel";
            bt_cancel.Size = new Size(76, 22);
            bt_cancel.TabIndex = 8;
            bt_cancel.Text = "Cancel";
            bt_cancel.UseVisualStyleBackColor = false;
            bt_cancel.Click += bt_cancel_Click;
            bt_cancel.MouseEnter += bt_cancel_MouseEnter;
            bt_cancel.MouseLeave += bt_cancel_MouseLeave;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(35, 130);
            label3.Name = "label3";
            label3.Size = new Size(72, 17);
            label3.TabIndex = 9;
            label3.Text = "Enter Id";
            // 
            // bt_res
            // 
            bt_res.BackColor = Color.WhiteSmoke;
            bt_res.FlatAppearance.BorderColor = Color.Black;
            bt_res.FlatAppearance.BorderSize = 2;
            bt_res.FlatStyle = FlatStyle.Flat;
            bt_res.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bt_res.Location = new Point(654, 119);
            bt_res.Margin = new Padding(3, 2, 3, 2);
            bt_res.Name = "bt_res";
            bt_res.Size = new Size(123, 27);
            bt_res.TabIndex = 10;
            bt_res.Text = "Reservation only";
            bt_res.UseVisualStyleBackColor = false;
            bt_res.Click += bt_res_Click;
            bt_res.MouseEnter += bt_res_MouseEnter;
            bt_res.MouseLeave += bt_res_MouseLeave;
            // 
            // Reservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 398);
            Controls.Add(bt_res);
            Controls.Add(label3);
            Controls.Add(bt_cancel);
            Controls.Add(tb_r_id);
            Controls.Add(bt_show_all);
            Controls.Add(bt_ch_reserv);
            Controls.Add(bt_back_resr_form);
            Controls.Add(label2);
            Controls.Add(Res_dgv);
            Controls.Add(dtp);
            Controls.Add(label1);
            Name = "Reservation";
            Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)Res_dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dtp;
        private DataGridView Res_dgv;
        private Label label2;
        private Button bt_back_resr_form;
        private Button bt_ch_reserv;
        private Button bt_show_all;
        private TextBox tb_r_id;
        private Button bt_cancel;
        private Label label3;
        private Button bt_res;
    }
}