using Parser.Model;

namespace Parser.View
{
    public partial class NewUserForm : Form
    {
        private readonly ApplicationContext _context;
        private UserModel _user;
        private string username, password, role;

        public NewUserForm(ApplicationContext context, UserModel user)
        {
            _context = context;
            _user = user;
            InitializeComponent();
        }

        private async void buttonAdd_Click(object sender, EventArgs e)
        {
            username = textBoxUsername.Text;
            password = textBoxPassword.Text;
            role = comboBoxUserRole.SelectedText;

            await RepositoryHelper.AddUser(_context, username, password, role);

            this.Close();
        }
    }
}
