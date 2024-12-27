namespace BF_Client
{
    public partial class LoginForm : Form
    {
        private  User _user;
        public User GetUser()
        {
            return _user;
        }

        public LoginForm()
        {
            InitializeComponent();

        }

        private async void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_user != null)
                return;

            if (e.CloseReason == CloseReason.ApplicationExitCall)
                return;


            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();
            else
            {
                //В нашем случей нажата клавиша OK
                UserLogin login = new()
                {
                    Name = textBoxLogin.Text,
                    Password = textBoxPassword.Text
                };
                e.Cancel = true;//иначе окно закроется как только мы нажмем клавишу ок

                Rest.SetURL(textBoxURL.Text);
                
                List<User> res = await Rest.RestPost<List<User>>("/api/Login", login);
                
                if (res.Count == 1)
                {
                    _user = new User
                    {
                        Name = res[0].Name,
                        Rule = res[0].Rule
                    };
                    Close();
                }
                else
                    MessageBox.Show("Access denied", "Login",
                        MessageBoxButtons.OK, MessageBoxIcon.Hand);

                if (_user == null)
                    Application.Exit();
            }
        }

        private void TextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                GetNextControl((TextBox)sender, true).Focus();
        }
    }
}
