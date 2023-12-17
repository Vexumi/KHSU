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
            buttonAddUser = new Button();
            buttonLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)FilesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ChoseFilePathButton
            // 
            ChoseFilePathButton.Location = new Point(12, 12);
            ChoseFilePathButton.Name = "ChoseFilePathButton";
            ChoseFilePathButton.Size = new Size(100, 50);
            ChoseFilePathButton.TabIndex = 0;
            ChoseFilePathButton.Text = "Choose Folder";
            ChoseFilePathButton.UseVisualStyleBackColor = true;
            ChoseFilePathButton.Click += ChooseFilePathButton_Click;
            // 
            // FilePathLabel
            // 
            FilePathLabel.AutoSize = true;
            FilePathLabel.Location = new Point(134, 30);
            FilePathLabel.Name = "FilePathLabel";
            FilePathLabel.Size = new Size(123, 15);
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
            FilesDataGridView.Location = new Point(12, 89);
            FilesDataGridView.Name = "FilesDataGridView";
            FilesDataGridView.ReadOnly = true;
            FilesDataGridView.RowHeadersWidth = 51;
            FilesDataGridView.RowTemplate.Height = 25;
            FilesDataGridView.Size = new Size(224, 177);
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
            FileName.Width = 83;
            // 
            // Status
            // 
            Status.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            Status.ReadOnly = true;
            Status.Resizable = DataGridViewTriState.False;
            Status.Width = 64;
            // 
            // CheckButton
            // 
            CheckButton.Location = new Point(12, 272);
            CheckButton.Name = "CheckButton";
            CheckButton.Size = new Size(224, 23);
            CheckButton.TabIndex = 3;
            CheckButton.Text = "Check";
            CheckButton.UseVisualStyleBackColor = true;
            CheckButton.Click += CheckButton_Click;
            // 
            // buttonSaveSuccessExperiments
            // 
            buttonSaveSuccessExperiments.Enabled = false;
            buttonSaveSuccessExperiments.Location = new Point(12, 300);
            buttonSaveSuccessExperiments.Margin = new Padding(3, 2, 3, 2);
            buttonSaveSuccessExperiments.Name = "buttonSaveSuccessExperiments";
            buttonSaveSuccessExperiments.Size = new Size(224, 22);
            buttonSaveSuccessExperiments.TabIndex = 4;
            buttonSaveSuccessExperiments.Text = "Save success experiments";
            buttonSaveSuccessExperiments.UseVisualStyleBackColor = true;
            buttonSaveSuccessExperiments.Click += buttonSaveSuccessExperiments_Click;
            // 
            // buttonAddUser
            // 
            buttonAddUser.Location = new Point(397, 12);
            buttonAddUser.Name = "buttonAddUser";
            buttonAddUser.Size = new Size(75, 23);
            buttonAddUser.TabIndex = 5;
            buttonAddUser.Text = "Add user";
            buttonAddUser.UseVisualStyleBackColor = true;
            buttonAddUser.Click += buttonAddUser_Click;
            // 
            // buttonLogout
            // 
            buttonLogout.BackColor = Color.Red;
            buttonLogout.FlatAppearance.BorderColor = Color.IndianRed;
            buttonLogout.FlatAppearance.BorderSize = 0;
            buttonLogout.FlatStyle = FlatStyle.Popup;
            buttonLogout.ForeColor = Color.White;
            buttonLogout.Location = new Point(397, 298);
            buttonLogout.Name = "buttonLogout";
            buttonLogout.Size = new Size(75, 23);
            buttonLogout.TabIndex = 6;
            buttonLogout.Text = "Logout";
            buttonLogout.UseVisualStyleBackColor = false;
            buttonLogout.Click += buttonLogout_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(buttonLogout);
            Controls.Add(buttonAddUser);
            Controls.Add(buttonSaveSuccessExperiments);
            Controls.Add(CheckButton);
            Controls.Add(FilesDataGridView);
            Controls.Add(FilePathLabel);
            Controls.Add(ChoseFilePathButton);
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
        private Button buttonAddUser;
        private Button buttonLogout;
    }
}