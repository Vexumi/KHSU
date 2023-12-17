namespace Parser.View
{
    partial class LoginForm
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
            buttonLogin = new Button();
            labelMail = new Label();
            textBoxPassword = new TextBox();
            textBoxMail = new TextBox();
            labelWelcome = new Label();
            SuspendLayout();
            // 
            // labelPassword
            // 
            labelPassword.AutoSize = true;
            labelPassword.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPassword.Location = new Point(75, 348);
            labelPassword.Name = "labelPassword";
            labelPassword.Size = new Size(74, 23);
            labelPassword.TabIndex = 13;
            labelPassword.Text = "Pasword:";
            // 
            // buttonLogin
            // 
            buttonLogin.BackColor = Color.FromArgb(146, 208, 80);
            buttonLogin.FlatStyle = FlatStyle.Popup;
            buttonLogin.Font = new Font("Comic Sans MS", 16F, FontStyle.Regular, GraphicsUnit.Point);
            buttonLogin.Location = new Point(150, 466);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(200, 75);
            buttonLogin.TabIndex = 14;
            buttonLogin.Text = "Sign In";
            buttonLogin.UseVisualStyleBackColor = false;
            buttonLogin.Click += buttonLogin_Click;
            // 
            // labelMail
            // 
            labelMail.AutoSize = true;
            labelMail.Font = new Font("Comic Sans MS", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelMail.Location = new Point(75, 231);
            labelMail.Name = "labelMail";
            labelMail.Size = new Size(85, 23);
            labelMail.TabIndex = 12;
            labelMail.Text = "Username:";
            // 
            // textBoxPassword
            // 
            textBoxPassword.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPassword.Location = new Point(75, 374);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(350, 41);
            textBoxPassword.TabIndex = 11;
            // 
            // textBoxMail
            // 
            textBoxMail.Font = new Font("Comic Sans MS", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxMail.Location = new Point(75, 257);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(350, 41);
            textBoxMail.TabIndex = 10;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Comic Sans MS", 32F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(132, 137);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(218, 60);
            labelWelcome.TabIndex = 9;
            labelWelcome.Text = "Welcome!";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 661);
            Controls.Add(labelPassword);
            Controls.Add(buttonLogin);
            Controls.Add(labelMail);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxMail);
            Controls.Add(labelWelcome);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            FormClosing += LoginForm_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelPassword;
        private Button buttonLogin;
        private Label labelMail;
        private TextBox textBoxPassword;
        private TextBox textBoxMail;
        private Label labelWelcome;
    }
}