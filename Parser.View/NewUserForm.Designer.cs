namespace Parser.View
{
    partial class NewUserForm
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
            labelPassword = new Label();
            buttonAdd = new Button();
            labelUsername = new Label();
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            labelNewUser = new Label();
            buttonBack = new Button();
            labelUserRole = new Label();
            comboBoxUserRole = new ComboBox();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(69, 246);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(74, 23);
            labelPassword.TabIndex = 19;
            labelPassword.Text = "Pasword:";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.FromArgb(146, 208, 80);
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonAdd.Location = new Point(151, 445);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(200, 75);
            buttonAdd.TabIndex = 20;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUsername.Location = new Point(69, 129);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(85, 23);
            labelUsername.TabIndex = 18;
            labelUsername.Text = "Username:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(69, 272);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(350, 41);
            textBoxPassword.TabIndex = 17;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxUsername.Location = new Point(69, 155);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(350, 41);
            textBoxUsername.TabIndex = 16;
            // 
            // labelNewUser
            // 
            labelNewUser.AutoSize = true;
            labelNewUser.Font = new Font("Comic Sans MS", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelNewUser.Location = new Point(126, 35);
            labelNewUser.Name = "labelNewUser";
            labelNewUser.Size = new Size(225, 60);
            labelNewUser.TabIndex = 15;
            labelNewUser.Text = "New User";
            // 
            // buttonBack
            // 
            buttonBack.BackColor = Color.FromArgb(146, 208, 80);
            buttonBack.FlatStyle = FlatStyle.Popup;
            buttonBack.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonBack.Location = new Point(12, 612);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(100, 37);
            buttonBack.TabIndex = 21;
            buttonBack.Text = "Back";
            buttonBack.UseVisualStyleBackColor = false;
            // 
            // labelUserRole
            // 
            labelUserRole.AutoSize = true;
            labelUserRole.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelUserRole.Location = new Point(69, 359);
            labelUserRole.Name = "labelUserRole";
            labelUserRole.Size = new Size(87, 23);
            labelUserRole.TabIndex = 22;
            labelUserRole.Text = "User Role:";
            // 
            // comboBoxUserRole
            // 
            comboBoxUserRole.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            comboBoxUserRole.FormattingEnabled = true;
            comboBoxUserRole.Items.AddRange(new object[] { "Administator", "Employee", "Auditor" });
            comboBoxUserRole.Location = new Point(69, 385);
            comboBoxUserRole.Name = "comboBoxUserRole";
            comboBoxUserRole.Size = new Size(350, 41);
            comboBoxUserRole.TabIndex = 23;
            // 
            // NewUserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 661);
            Controls.Add(comboBoxUserRole);
            Controls.Add(labelUserRole);
            Controls.Add(buttonBack);
            Controls.Add(labelPassword);
            Controls.Add(buttonAdd);
            Controls.Add(labelUsername);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(labelNewUser);
            Name = "NewUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "New User";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private Button buttonAdd;
        private Label labelUsername;
        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label labelNewUser;
        private Button buttonBack;
        private Label labelUserRole;
        private ComboBox comboBoxUserRole;
    }
}