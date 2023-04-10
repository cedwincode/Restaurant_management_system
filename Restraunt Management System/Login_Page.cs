using System.Diagnostics;

namespace Restraunt_Management_System
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();

        }

        public void openAfter_cash_login(object obj)
        {
            Application.Run(new After_cash_login());
        }

        public void openAfter_mngr_login(object obj)
        {
            Application.Run(new After_mngr_login());
        }

        private void password_Click(object sender, EventArgs e)
        {

        }

        public void enter_details()
        {
            if ((username_textbox.Text == "cashier") && (password_textbox.Text == "admin"))
            {
                Thread th = new Thread(openAfter_cash_login);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else if ((username_textbox.Text == "manager") && (password_textbox.Text == "admin"))
            {
                Thread th = new Thread(openAfter_mngr_login);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid details try again!");
            }
        }
        private void submit_Click(object sender, EventArgs e)
        {
            enter_details();
        }

        private void username_textbox_TextChanged(object sender, EventArgs e)
        {
            if (username_textbox.Text.Length > 30)
            {
                username_textbox.Text = username_textbox.Text.Substring(0, 30);
                username_textbox.SelectionStart = username_textbox.Text.Length;
                username_textbox.SelectionLength = 0;
            }
        }

        private void password_textbox_TextChanged(object sender, EventArgs e)
        {
            if (password_textbox.Text.Length > 30)
            {
                password_textbox.Text = password_textbox.Text.Substring(0, 30);
                password_textbox.SelectionStart = password_textbox.Text.Length;
                password_textbox.SelectionLength = 0;
            }
        }

        private void username_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                enter_details();
            }
        }

        private void password_textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                enter_details();
            }
        }



        
    }
}