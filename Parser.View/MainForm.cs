using Microsoft.VisualBasic.ApplicationServices;
using Parser.Model;

namespace Parser.View
{
    public partial class MainForm : Form
    {
        private class FileStatus
        {
            public static string Success = "Success";
            public static string Error = "Error";
        }

        private string path;
        private string[] files;
        private List<Experiment> experiments = new();
        private readonly ApplicationContext _context;
        private UserModel _user;

        public LoginForm loginForm;

        public MainForm(ApplicationContext context, UserModel user)
        {
            _context = context;
            _user = user;
            InitializeComponent();

            buttonAddUser.Visible = _user.Role == UserRole.Administrator;
            buttonSaveSuccessExperiments.Visible =
                _user.Role == UserRole.Administrator || _user.Role == UserRole.Employee;
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            this.Enabled = false;

            using (NewUserForm newUserForm = new NewUserForm(_context, _user))
            {
                newUserForm.ShowDialog();
            }

            this.Enabled = true;
        }

        private void ChooseFilePathButton_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    FilesDataGridView.Rows.Clear();

                    path = fbd.SelectedPath;
                    files = Directory.GetFiles(fbd.SelectedPath);

                    FilePathLabel.Text = $"FilePath: {path}";

                    for (int i = 0; i < files.Length; i++)
                    {
                        FilesDataGridView.Rows.Add(Path.GetFileName(files[i]), "Not checked");
                        FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Gray;
                    }
                }
            }
        }

        private async void CheckButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < files.Length; i++)
            {
                var experiment = ExperimentLoader.GetExperiment(files[i]);

                if (experiment.GetType() == typeof(string))
                {
                    FilesDataGridView.Rows[i].Cells[1].Value = FileStatus.Error;
                    FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    FilesDataGridView.Rows[i].Cells[1].Value = FileStatus.Success;
                    FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                    experiments.Add(experiment);
                }

                await Task.Delay(500);
            }

            buttonSaveSuccessExperiments.Enabled = true;
        }

        private void FilesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FilesDataGridView.CurrentCell.ColumnIndex.Equals(0))
            {
                var file = FilesDataGridView.CurrentCell.Value.ToString();

                var experiment = ExperimentLoader.GetExperiment($"{path}\\{file}");

                if (experiment.GetType() == typeof(string))
                    MessageBox.Show(experiment);
            }
        }

        private async void buttonSaveSuccessExperiments_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < experiments.Count(); i++)
            {
                if (FilesDataGridView.Rows[i].Cells[1].Value == FileStatus.Success)
                {
                    await RepositoryHelper.SaveExperiment(_context, experiments[i]);
                }
            }

            buttonSaveSuccessExperiments.Enabled = false;
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            loginForm = new LoginForm(_context);
            loginForm.mainForm = this;

            loginForm.Show();
            this.Close();
        }
    }
}
