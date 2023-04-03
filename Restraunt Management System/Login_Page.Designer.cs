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
            button1 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Black;
            username.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Lime;
            username.Location = new Point(238, 174);
            username.Name = "username";
            username.Size = new Size(82, 21);
            username.TabIndex = 0;
            username.Text = "Username";
            username.Click += username_Click;
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Lime;
            password.Location = new Point(238, 213);
            password.Name = "password";
            password.Size = new Size(82, 21);
            password.TabIndex = 1;
            password.Text = "Password";
            // 
            // username_textbox
            // 
            username_textbox.BackColor = Color.LightGray;
            username_textbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            username_textbox.Location = new Point(341, 177);
            username_textbox.Name = "username_textbox";
            username_textbox.PlaceholderText = "Enter Username";
            username_textbox.Size = new Size(156, 22);
            username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.LightGray;
            password_textbox.Font = new Font("Cambria", 9F, FontStyle.Regular, GraphicsUnit.Point);
            password_textbox.Location = new Point(341, 216);
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
            submit.Location = new Point(341, 253);
            submit.Name = "submit";
            submit.Size = new Size(77, 52);
            submit.TabIndex = 4;
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(135, 112);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cascadia Code", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.Lime;
            label1.Location = new Point(153, 49);
            label1.Name = "label1";
            label1.Size = new Size(551, 43);
            label1.TabIndex = 6;
            label1.Text = "Restaurant Management System";
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(790, 444);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(submit);
            Controls.Add(password_textbox);
            Controls.Add(username_textbox);
            Controls.Add(password);
            Controls.Add(username);
            Name = "Login_Page";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label username;
        private Label password;
        private TextBox username_textbox;
        private TextBox password_textbox;
        private Button submit;
        private Button button1;
        private Label label1;
    }
}