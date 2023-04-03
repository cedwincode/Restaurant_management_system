namespace Restraunt_Management_System
{
    partial class Login_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Page));
            username = new Label();
            password = new Label();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            submit = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Black;
            username.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Lime;
            username.Location = new Point(260, 187);
            username.Name = "username";
            username.Size = new Size(100, 25);
            username.TabIndex = 0;
            username.Text = "Username";
            username.Click += username_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Cascadia Code", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Lime;
            password.Location = new Point(260, 226);
            password.Name = "password";
            password.Size = new Size(100, 25);
            password.TabIndex = 1;
            password.Text = "Password";
            // 
            // username_textbox
            // 
            username_textbox.BackColor = Color.LightGray;
            username_textbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            username_textbox.Location = new Point(366, 190);
            username_textbox.Name = "username_textbox";
            username_textbox.PlaceholderText = "Enter Username";
            username_textbox.Size = new Size(156, 22);
            username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.LightGray;
            password_textbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.Location = new Point(366, 233);
            password_textbox.Name = "password_textbox";
            password_textbox.PasswordChar = '*';
            password_textbox.PlaceholderText = "Enter Password";
            password_textbox.Size = new Size(156, 22);
            password_textbox.TabIndex = 3;
            // 
            // submit
            // 
            submit.BackColor = Color.Black;
            submit.BackgroundImageLayout = ImageLayout.None;
            submit.FlatStyle = FlatStyle.Flat;
            submit.Font = new Font("Segoe UI Symbol", 9F, FontStyle.Regular, GraphicsUnit.Point);
            submit.Image = (Image)resources.GetObject("submit.Image");
            submit.Location = new Point(366, 275);
            submit.Name = "submit";
            submit.Size = new Size(77, 52);
            submit.TabIndex = 4;
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(136, 42);
            label1.Name = "label1";
            label1.Size = new Size(608, 46);
            label1.TabIndex = 6;
            label1.Text = "Restaurant Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 401);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(35, 31);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(43, 404);
            label2.Name = "label2";
            label2.Size = new Size(210, 16);
            label2.TabIndex = 8;
            label2.Text = "Copyright All Rights Reserved";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(27, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(103, 101);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(294, 394);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 38);
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(338, 404);
            label3.Name = "label3";
            label3.Size = new Size(105, 16);
            label3.TabIndex = 11;
            label3.Text = "ISO 27001:2013";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(471, 404);
            label4.Name = "label4";
            label4.Size = new Size(273, 16);
            label4.TabIndex = 12;
            label4.Text = "Contact : 2104030.stu@dmscollege.ac.in";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(790, 444);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(submit);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Login_Page";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Button submit;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label4;
    }
}