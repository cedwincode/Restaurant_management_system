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
            this.label1 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.Res_dgv = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bt_back_resr_form = new System.Windows.Forms.Button();
            this.bt_ch_reserv = new System.Windows.Forms.Button();
            this.bt_show_all = new System.Windows.Forms.Button();
            this.tb_r_id = new System.Windows.Forms.TextBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_res = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Res_dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(355, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reservation";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(167, 125);
            this.dtp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(228, 27);
            this.dtp.TabIndex = 1;
            this.dtp.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtp_KeyPress);
            // 
            // Res_dgv
            // 
            this.Res_dgv.AllowUserToAddRows = false;
            this.Res_dgv.AllowUserToDeleteRows = false;
            this.Res_dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Res_dgv.BackgroundColor = System.Drawing.Color.White;
            this.Res_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Res_dgv.Location = new System.Drawing.Point(40, 205);
            this.Res_dgv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Res_dgv.Name = "Res_dgv";
            this.Res_dgv.ReadOnly = true;
            this.Res_dgv.RowHeadersWidth = 51;
            this.Res_dgv.RowTemplate.Height = 25;
            this.Res_dgv.Size = new System.Drawing.Size(849, 277);
            this.Res_dgv.TabIndex = 2;
            this.Res_dgv.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.Res_dgv_CellFormatting);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Lime;
            this.label2.Location = new System.Drawing.Point(41, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select Date";
            // 
            // bt_back_resr_form
            // 
            this.bt_back_resr_form.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt_back_resr_form.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_back_resr_form.Image = ((System.Drawing.Image)(resources.GetObject("bt_back_resr_form.Image")));
            this.bt_back_resr_form.Location = new System.Drawing.Point(14, 16);
            this.bt_back_resr_form.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bt_back_resr_form.Name = "bt_back_resr_form";
            this.bt_back_resr_form.Size = new System.Drawing.Size(56, 69);
            this.bt_back_resr_form.TabIndex = 4;
            this.bt_back_resr_form.UseVisualStyleBackColor = true;
            this.bt_back_resr_form.Click += new System.EventHandler(this.bt_back_resr_form_Click);
            // 
            // bt_ch_reserv
            // 
            this.bt_ch_reserv.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_ch_reserv.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_ch_reserv.FlatAppearance.BorderSize = 2;
            this.bt_ch_reserv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_ch_reserv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_ch_reserv.ForeColor = System.Drawing.Color.Black;
            this.bt_ch_reserv.Location = new System.Drawing.Point(401, 123);
            this.bt_ch_reserv.Name = "bt_ch_reserv";
            this.bt_ch_reserv.Size = new System.Drawing.Size(130, 29);
            this.bt_ch_reserv.TabIndex = 5;
            this.bt_ch_reserv.Text = "Check All (Day)";
            this.bt_ch_reserv.UseVisualStyleBackColor = false;
            this.bt_ch_reserv.Click += new System.EventHandler(this.bt_ch_reserv_Click);
            this.bt_ch_reserv.MouseEnter += new System.EventHandler(this.bt_ch_reserv_MouseEnter);
            this.bt_ch_reserv.MouseLeave += new System.EventHandler(this.bt_ch_reserv_MouseLeave);
            // 
            // bt_show_all
            // 
            this.bt_show_all.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_show_all.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_show_all.FlatAppearance.BorderSize = 2;
            this.bt_show_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_show_all.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_show_all.Location = new System.Drawing.Point(790, 123);
            this.bt_show_all.Name = "bt_show_all";
            this.bt_show_all.Size = new System.Drawing.Size(99, 29);
            this.bt_show_all.TabIndex = 6;
            this.bt_show_all.Text = "Display all";
            this.bt_show_all.UseVisualStyleBackColor = false;
            this.bt_show_all.Click += new System.EventHandler(this.bt_show_all_Click);
            this.bt_show_all.MouseEnter += new System.EventHandler(this.bt_show_all_MouseEnter);
            this.bt_show_all.MouseLeave += new System.EventHandler(this.bt_show_all_MouseLeave);
            // 
            // tb_r_id
            // 
            this.tb_r_id.Location = new System.Drawing.Point(136, 171);
            this.tb_r_id.Name = "tb_r_id";
            this.tb_r_id.Size = new System.Drawing.Size(125, 27);
            this.tb_r_id.TabIndex = 7;
            this.tb_r_id.TextChanged += new System.EventHandler(this.tb_r_id_TextChanged);
            this.tb_r_id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_r_id_KeyPress);
            // 
            // bt_cancel
            // 
            this.bt_cancel.BackColor = System.Drawing.Color.DarkRed;
            this.bt_cancel.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.bt_cancel.FlatAppearance.BorderSize = 2;
            this.bt_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_cancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_cancel.ForeColor = System.Drawing.Color.Black;
            this.bt_cancel.Location = new System.Drawing.Point(267, 171);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(87, 29);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = false;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            this.bt_cancel.MouseEnter += new System.EventHandler(this.bt_cancel_MouseEnter);
            this.bt_cancel.MouseLeave += new System.EventHandler(this.bt_cancel_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Lime;
            this.label3.Location = new System.Drawing.Point(40, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Enter Id";
            // 
            // bt_res
            // 
            this.bt_res.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bt_res.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bt_res.FlatAppearance.BorderSize = 2;
            this.bt_res.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_res.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bt_res.Location = new System.Drawing.Point(748, 159);
            this.bt_res.Name = "bt_res";
            this.bt_res.Size = new System.Drawing.Size(141, 36);
            this.bt_res.TabIndex = 10;
            this.bt_res.Text = "Reservation only";
            this.bt_res.UseVisualStyleBackColor = false;
            this.bt_res.Click += new System.EventHandler(this.bt_res_Click);
            this.bt_res.MouseEnter += new System.EventHandler(this.bt_res_MouseEnter);
            this.bt_res.MouseLeave += new System.EventHandler(this.bt_res_MouseLeave);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(914, 530);
            this.Controls.Add(this.bt_res);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.tb_r_id);
            this.Controls.Add(this.bt_show_all);
            this.Controls.Add(this.bt_ch_reserv);
            this.Controls.Add(this.bt_back_resr_form);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Res_dgv);
            this.Controls.Add(this.dtp);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.Res_dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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