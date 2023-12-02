namespace Parser.View
{
    public partial class MainForm : Form
    {
        string path;
        string[] files;

        public MainForm()
        {
            InitializeComponent();
        }

        private void ChoseFilePathButton_Click(object sender, EventArgs e)
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
                    FilesDataGridView.Rows[i].Cells[1].Value = "Failure";
                    FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    FilesDataGridView.Rows[i].Cells[1].Value = "Success";
                    FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                }

                await Task.Delay(500);
            }
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
    }
}
