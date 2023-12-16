namespace Parser.View
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ChoseFilePathButton = new Button();
            FilePathLabel = new Label();
            FilesDataGridView = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            CheckButton = new Button();
            buttonSaveSuccessExperiments = new Button();
            ((System.ComponentModel.ISupportInitialize)FilesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ChoseFilePathButton
            // 
            ChoseFilePathButton.Location = new Point(14, 16);
            ChoseFilePathButton.Margin = new Padding(3, 4, 3, 4);
            ChoseFilePathButton.Name = "ChoseFilePathButton";
            ChoseFilePathButton.Size = new Size(114, 67);
            ChoseFilePathButton.TabIndex = 0;
            ChoseFilePathButton.Text = "Choose Folder";
            ChoseFilePathButton.UseVisualStyleBackColor = true;
            ChoseFilePathButton.Click += ChoseFilePathButton_Click;
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(153, 40);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(153, 20);
            FilePathLabel.TabIndex = 1;
            FilePathLabel.Text = "FilePath: not specified";
            // 
            // FilesDataGridView
            // 
            FilesDataGridView.AllowUserToAddRows = false;
            FilesDataGridView.AllowUserToDeleteRows = false;
            FilesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FilesDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            FilesDataGridView.BackgroundColor = SystemColors.Control;
            FilesDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FilesDataGridView.Columns.AddRange(new DataGridViewColumn[] { FileName, Status });
            FilesDataGridView.GridColor = SystemColors.Control;
            FilesDataGridView.Location = new Point(14, 119);
            FilesDataGridView.Margin = new Padding(3, 4, 3, 4);
            FilesDataGridView.Name = "FilesDataGridView";
            FilesDataGridView.ReadOnly = true;
            FilesDataGridView.RowHeadersWidth = 51;
            FilesDataGridView.RowTemplate.Height = 25;
            FilesDataGridView.Size = new Size(256, 236);
            FilesDataGridView.TabIndex = 2;
            FilesDataGridView.CellClick += FilesDataGridView_CellClick;
            // 
            // FileName
            // 
            FileName.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            FileName.Frozen = true;
            FileName.HeaderText = "File name";
            FileName.MinimumWidth = 6;
            FileName.Name = "FileName";
            FileName.ReadOnly = true;
            FileName.Width = 102;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.Width = 78;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(14, 398);
            CheckButton.Margin = new Padding(3, 4, 3, 4);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(256, 31);
            CheckButton.TabIndex = 3;
            CheckButton.Text = "Check";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // buttonSaveSuccessExperiments
            // 
            buttonSaveSuccessExperiments.Enabled = false;
            buttonSaveSuccessExperiments.Location = new Point(14, 362);
            buttonSaveSuccessExperiments.Name = "buttonSaveSuccessExperiments";
            buttonSaveSuccessExperiments.Size = new Size(256, 29);
            buttonSaveSuccessExperiments.TabIndex = 4;
            buttonSaveSuccessExperiments.Text = "Save success experiments";
            buttonSaveSuccessExperiments.UseVisualStyleBackColor = true;
            buttonSaveSuccessExperiments.Click += buttonSaveSuccessExperiments_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 481);
            Controls.Add(buttonSaveSuccessExperiments);
            Controls.Add(CheckButton);
            Controls.Add(FilesDataGridView);
            Controls.Add(FilePathLabel);
            Controls.Add(ChoseFilePathButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)FilesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ChoseFilePathButton;
        private Label FilePathLabel;
        private DataGridView FilesDataGridView;
        private Button CheckButton;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn Status;
        private Button buttonSaveSuccessExperiments;
    }
}