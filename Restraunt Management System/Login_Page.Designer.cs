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
            username = new Label();
            password = new Label();
            username_textbox = new TextBox();
            password_textbox = new TextBox();
            submit = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.AutoSize = true;
            username.BackColor = Color.Black;
            username.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            username.ForeColor = Color.Lime;
            username.Location = new Point(153, 139);
            username.Name = "username";
            username.Size = new Size(82, 21);
            username.TabIndex = 0;
            username.Text = "Username";
            // 
            // password
            // 
            password.AutoSize = true;
            password.Font = new Font("Cascadia Code", 12F, FontStyle.Regular, GraphicsUnit.Point);
            password.ForeColor = Color.Lime;
            password.Location = new Point(153, 177);
            password.Name = "password";
            password.Size = new Size(82, 21);
            password.TabIndex = 1;
            password.Text = "Password";
            password.Click += password_Click;
            // 
            // username_textbox
            // 
            username_textbox.BackColor = Color.LightGray;
            username_textbox.Location = new Point(244, 139);
            username_textbox.Name = "username_textbox";
            username_textbox.Size = new Size(156, 23);
            username_textbox.TabIndex = 2;
            // 
            // password_textbox
            // 
            password_textbox.BackColor = Color.LightGray;
            password_textbox.Location = new Point(244, 179);
            password_textbox.Name = "password_textbox";
            password_textbox.Size = new Size(156, 23);
            password_textbox.TabIndex = 3;
            // 
            // submit
            // 
            submit.BackColor = Color.Transparent;
            submit.Location = new Point(244, 246);
            submit.Name = "submit";
            submit.Size = new Size(75, 23);
            submit.TabIndex = 4;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            // 
            // Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(800, 450);
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
    }
}