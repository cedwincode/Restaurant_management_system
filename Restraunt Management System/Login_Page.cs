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

        private void submit_Click(object sender, EventArgs e)
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

        private void username_Click(object sender, EventArgs e)
        {

        }
    }
}