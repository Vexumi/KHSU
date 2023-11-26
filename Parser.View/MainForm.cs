using Parser.Model;

namespace Parser.View
{
    public partial class MainForm : Form
    {
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
                    files = Directory.GetFiles(fbd.SelectedPath);
                    FilePathLabel.Text = $"FilePath: {fbd.SelectedPath}";

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
                Experiment experiment = ExperimentLoader.GetExperiment(files[i]);
                
                if (experiment == null)
                {
                    FilesDataGridView.Rows[i].Cells[1].Value = "Failure";
                    FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Red;
                }
                else
                {
                    FilesDataGridView.Rows[i].Cells[1].Value = "Success";
                    FilesDataGridView.Rows[i].Cells[1].Style.ForeColor = Color.Green;
                }

                await Task.Delay(200);
            }
        }
    }
}
