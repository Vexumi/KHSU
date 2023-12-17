namespace Parser.View
{
    public partial class LoginForm : Form
    {
        private string username, password;
        private readonly ApplicationContext _context;

        public MainForm mainForm;

        public LoginForm(ApplicationContext context)
        {
            _context = context;
            InitializeComponent();
        }

        private async void buttonLogin_Click(object sender, EventArgs e)
        {
            username = textBoxMail.Text;
            password = textBoxPassword.Text;

            var user = await RepositoryHelper.GetUser(_context, username, password);

            if (user != null)
            {
                mainForm = new MainForm(_context, user);
                mainForm.loginForm = this;

                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uncorrect data", "Wrong authorize", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
