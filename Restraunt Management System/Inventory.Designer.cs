namespace Restraunt_Management_System
{
    partial class Inventory
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
            label1 = new Label();
            sugar_bar = new ProgressBar();
            buy_all_sugar = new Button();
            label2 = new Label();
            label3 = new Label();
            eggs_bar = new ProgressBar();
            potato_bar = new ProgressBar();
            buy_all_eggs = new Button();
            buy_all_potato = new Button();
            label4 = new Label();
            label5 = new Label();
            tomato_bar = new ProgressBar();
            oil_bar = new ProgressBar();
            buy_all_tomato = new Button();
            buy_all_oil = new Button();
            label6 = new Label();
            sugar_per = new TextBox();
            eggs_per = new TextBox();
            potato_per = new TextBox();
            tomato_per = new TextBox();
            oil_per = new TextBox();
            buy_selected_eggs = new Button();
            buy_selected_potato = new Button();
            buy_selected_totato = new Button();
            buy_selected_oil = new Button();
            buy_selected_sugar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(44, 72);
            label1.Name = "label1";
            label1.Size = new Size(67, 25);
            label1.TabIndex = 0;
            label1.Text = "Sugar";
            // 
            // sugar_bar
            // 
            sugar_bar.BackColor = Color.Black;
            sugar_bar.ForeColor = Color.Lime;
            sugar_bar.Location = new Point(44, 114);
            sugar_bar.Name = "sugar_bar";
            sugar_bar.Size = new Size(287, 32);
            sugar_bar.TabIndex = 1;
            sugar_bar.Value = 25;
            // 
            // buy_all_sugar
            // 
            buy_all_sugar.BackColor = Color.Lime;
            buy_all_sugar.FlatStyle = FlatStyle.Flat;
            buy_all_sugar.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buy_all_sugar.ForeColor = Color.Black;
            buy_all_sugar.Location = new Point(693, 114);
            buy_all_sugar.Name = "buy_all_sugar";
            buy_all_sugar.Size = new Size(94, 32);
            buy_all_sugar.TabIndex = 2;
            buy_all_sugar.Text = "Buy All";
            buy_all_sugar.UseVisualStyleBackColor = false;
            buy_all_sugar.Click += buy_all_sugar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Lime;
            label2.Location = new Point(44, 167);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 3;
            label2.Text = "Eggs";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.Lime;
            label3.Location = new Point(44, 261);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 4;
            label3.Text = "Potato";
            // 
            // eggs_bar
            // 
            eggs_bar.BackColor = Color.Black;
            eggs_bar.ForeColor = Color.Lime;
            eggs_bar.Location = new Point(44, 215);
            eggs_bar.Name = "eggs_bar";
            eggs_bar.Size = new Size(288, 32);
            eggs_bar.TabIndex = 5;
            eggs_bar.Value = 80;
            // 
            // potato_bar
            // 
            potato_bar.Location = new Point(44, 311);
            potato_bar.Name = "potato_bar";
            potato_bar.Size = new Size(288, 32);
            potato_bar.TabIndex = 6;
            potato_bar.Value = 50;
            // 
            // buy_all_eggs
            // 
            buy_all_eggs.BackColor = Color.Lime;
            buy_all_eggs.FlatStyle = FlatStyle.Flat;
            buy_all_eggs.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buy_all_eggs.ForeColor = Color.Black;
            buy_all_eggs.Location = new Point(693, 215);
            buy_all_eggs.Name = "buy_all_eggs";
            buy_all_eggs.Size = new Size(94, 32);
            buy_all_eggs.TabIndex = 7;
            buy_all_eggs.Text = "Buy All";
            buy_all_eggs.UseVisualStyleBackColor = false;
            buy_all_eggs.Click += buy_all_eggs_Click;
            // 
            // buy_all_potato
            // 
            buy_all_potato.BackColor = Color.Lime;
            buy_all_potato.FlatStyle = FlatStyle.Flat;
            buy_all_potato.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buy_all_potato.ForeColor = Color.Black;
            buy_all_potato.Location = new Point(693, 311);
            buy_all_potato.Name = "buy_all_potato";
            buy_all_potato.Size = new Size(94, 32);
            buy_all_potato.TabIndex = 8;
            buy_all_potato.Text = "Buy All";
            buy_all_potato.UseVisualStyleBackColor = false;
            buy_all_potato.Click += buy_all_potato_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(44, 361);
            label4.Name = "label4";
            label4.Size = new Size(78, 25);
            label4.TabIndex = 9;
            label4.Text = "Tomato";
            label4.Click += label4_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.Lime;
            label5.Location = new Point(44, 468);
            label5.Name = "label5";
            label5.Size = new Size(45, 25);
            label5.TabIndex = 10;
            label5.Text = "Oil";
            // 
            // tomato_bar
            // 
            tomato_bar.Location = new Point(44, 416);
            tomato_bar.Name = "tomato_bar";
            tomato_bar.Size = new Size(288, 32);
            tomato_bar.TabIndex = 11;
            tomato_bar.Value = 30;
            // 
            // oil_bar
            // 
            oil_bar.Location = new Point(44, 514);
            oil_bar.Name = "oil_bar";
            oil_bar.Size = new Size(287, 32);
            oil_bar.TabIndex = 12;
            oil_bar.Value = 70;
            // 
            // buy_all_tomato
            // 
            buy_all_tomato.BackColor = Color.Lime;
            buy_all_tomato.FlatStyle = FlatStyle.Flat;
            buy_all_tomato.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buy_all_tomato.ForeColor = Color.Black;
            buy_all_tomato.Location = new Point(693, 416);
            buy_all_tomato.Name = "buy_all_tomato";
            buy_all_tomato.Size = new Size(94, 32);
            buy_all_tomato.TabIndex = 13;
            buy_all_tomato.Text = "Buy All";
            buy_all_tomato.UseVisualStyleBackColor = false;
            buy_all_tomato.Click += buy_all_tomato_Click;
            // 
            // buy_all_oil
            // 
            buy_all_oil.BackColor = Color.Lime;
            buy_all_oil.FlatStyle = FlatStyle.Flat;
            buy_all_oil.Font = new Font("Cascadia Code", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            buy_all_oil.ForeColor = Color.Black;
            buy_all_oil.Location = new Point(693, 514);
            buy_all_oil.Name = "buy_all_oil";
            buy_all_oil.Size = new Size(94, 32);
            buy_all_oil.TabIndex = 14;
            buy_all_oil.Text = "Buy All";
            buy_all_oil.UseVisualStyleBackColor = false;
            buy_all_oil.Click += buy_all_oil_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Cascadia Code", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = Color.Lime;
            label6.Location = new Point(328, 9);
            label6.Name = "label6";
            label6.Size = new Size(159, 35);
            label6.TabIndex = 15;
            label6.Text = "Inventory";
            // 
            // sugar_per
            // 
            sugar_per.BackColor = Color.DarkGray;
            sugar_per.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            sugar_per.ForeColor = Color.Black;
            sugar_per.Location = new Point(455, 114);
            sugar_per.Multiline = true;
            sugar_per.Name = "sugar_per";
            sugar_per.PlaceholderText = "%";
            sugar_per.Size = new Size(49, 34);
            sugar_per.TabIndex = 16;
            sugar_per.TextChanged += textBox1_TextChanged;
            // 
            // eggs_per
            // 
            eggs_per.BackColor = Color.DarkGray;
            eggs_per.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            eggs_per.ForeColor = Color.Black;
            eggs_per.Location = new Point(455, 215);
            eggs_per.Multiline = true;
            eggs_per.Name = "eggs_per";
            eggs_per.PlaceholderText = "%";
            eggs_per.Size = new Size(49, 32);
            eggs_per.TabIndex = 17;
            // 
            // potato_per
            // 
            potato_per.BackColor = Color.DarkGray;
            potato_per.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            potato_per.ForeColor = Color.Black;
            potato_per.Location = new Point(455, 311);
            potato_per.Multiline = true;
            potato_per.Name = "potato_per";
            potato_per.PlaceholderText = "%";
            potato_per.Size = new Size(49, 32);
            potato_per.TabIndex = 18;
            // 
            // tomato_per
            // 
            tomato_per.BackColor = Color.DarkGray;
            tomato_per.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tomato_per.ForeColor = Color.Black;
            tomato_per.Location = new Point(455, 419);
            tomato_per.Multiline = true;
            tomato_per.Name = "tomato_per";
            tomato_per.PlaceholderText = "%";
            tomato_per.Size = new Size(49, 32);
            tomato_per.TabIndex = 19;
            // 
            // oil_per
            // 
            oil_per.BackColor = Color.DarkGray;
            oil_per.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            oil_per.ForeColor = Color.Black;
            oil_per.Location = new Point(455, 514);
            oil_per.Multiline = true;
            oil_per.Name = "oil_per";
            oil_per.PlaceholderText = "%";
            oil_per.Size = new Size(49, 32);
            oil_per.TabIndex = 20;
            // 
            // buy_selected_eggs
            // 
            buy_selected_eggs.BackColor = Color.Lime;
            buy_selected_eggs.FlatStyle = FlatStyle.Flat;
            buy_selected_eggs.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buy_selected_eggs.Location = new Point(521, 215);
            buy_selected_eggs.Name = "buy_selected_eggs";
            buy_selected_eggs.Size = new Size(134, 32);
            buy_selected_eggs.TabIndex = 22;
            buy_selected_eggs.Text = "Buy Selected";
            buy_selected_eggs.UseVisualStyleBackColor = false;
            buy_selected_eggs.Click += buy_selected_eggs_Click;
            // 
            // buy_selected_potato
            // 
            buy_selected_potato.BackColor = Color.Lime;
            buy_selected_potato.FlatStyle = FlatStyle.Flat;
            buy_selected_potato.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buy_selected_potato.Location = new Point(521, 311);
            buy_selected_potato.Name = "buy_selected_potato";
            buy_selected_potato.Size = new Size(134, 32);
            buy_selected_potato.TabIndex = 23;
            buy_selected_potato.Text = "Buy Selected";
            buy_selected_potato.UseVisualStyleBackColor = false;
            buy_selected_potato.Click += buy_selected_potato_Click;
            // 
            // buy_selected_totato
            // 
            buy_selected_totato.BackColor = Color.Lime;
            buy_selected_totato.FlatStyle = FlatStyle.Flat;
            buy_selected_totato.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buy_selected_totato.Location = new Point(521, 416);
            buy_selected_totato.Name = "buy_selected_totato";
            buy_selected_totato.Size = new Size(134, 32);
            buy_selected_totato.TabIndex = 24;
            buy_selected_totato.Text = "Buy Selected";
            buy_selected_totato.UseVisualStyleBackColor = false;
            buy_selected_totato.Click += buy_selected_totato_Click;
            // 
            // buy_selected_oil
            // 
            buy_selected_oil.BackColor = Color.Lime;
            buy_selected_oil.FlatStyle = FlatStyle.Flat;
            buy_selected_oil.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buy_selected_oil.Location = new Point(521, 514);
            buy_selected_oil.Name = "buy_selected_oil";
            buy_selected_oil.Size = new Size(134, 32);
            buy_selected_oil.TabIndex = 25;
            buy_selected_oil.Text = "Buy Selected";
            buy_selected_oil.UseVisualStyleBackColor = false;
            buy_selected_oil.Click += buy_selected_oil_Click;
            // 
            // buy_selected_sugar
            // 
            buy_selected_sugar.BackColor = Color.Lime;
            buy_selected_sugar.FlatStyle = FlatStyle.Flat;
            buy_selected_sugar.Font = new Font("Cascadia Code", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            buy_selected_sugar.ForeColor = Color.Black;
            buy_selected_sugar.Location = new Point(521, 114);
            buy_selected_sugar.Name = "buy_selected_sugar";
            buy_selected_sugar.Size = new Size(134, 32);
            buy_selected_sugar.TabIndex = 26;
            buy_selected_sugar.Text = "Buy Selected";
            buy_selected_sugar.UseVisualStyleBackColor = false;
            buy_selected_sugar.Click += buy_selected_sugar_Click;
            // 
            // Inventory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(819, 630);
            Controls.Add(buy_selected_sugar);
            Controls.Add(buy_selected_oil);
            Controls.Add(buy_selected_totato);
            Controls.Add(buy_selected_potato);
            Controls.Add(buy_selected_eggs);
            Controls.Add(oil_per);
            Controls.Add(tomato_per);
            Controls.Add(potato_per);
            Controls.Add(eggs_per);
            Controls.Add(sugar_per);
            Controls.Add(label6);
            Controls.Add(buy_all_oil);
            Controls.Add(buy_all_tomato);
            Controls.Add(oil_bar);
            Controls.Add(tomato_bar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(buy_all_potato);
            Controls.Add(buy_all_eggs);
            Controls.Add(potato_bar);
            Controls.Add(eggs_bar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(buy_all_sugar);
            Controls.Add(sugar_bar);
            Controls.Add(label1);
            Name = "Inventory";
            Text = "Inventory";
            Load += Inventory_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ProgressBar sugar_bar;
        private Button buy_all_sugar;
        private Label label2;
        private Label label3;
        private ProgressBar eggs_bar;
        private ProgressBar potato_bar;
        private Button buy_all_eggs;
        private Button buy_all_potato;
        private Label label4;
        private Label label5;
        private ProgressBar tomato_bar;
        private ProgressBar oil_bar;
        private Button buy_all_tomato;
        private Button buy_all_oil;
        private Label label6;
        private TextBox sugar_per;
        private TextBox eggs_per;
        private TextBox potato_per;
        private TextBox tomato_per;
        private TextBox oil_per;
        private Button buy_selected_eggs;
        private Button buy_selected_potato;
        private Button buy_selected_totato;
        private Button buy_selected_oil;
        private Button buy_selected_sugar;
    }
}