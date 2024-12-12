namespace ElectronicDiary
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
            this.Exit = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.HelloMessage = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.Admin = new System.Windows.Forms.Button();
            this.JobTitlelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(12, 141);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(75, 23);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(12, 42);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(207, 20);
            this.Login.TabIndex = 2;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(12, 71);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(207, 20);
            this.Password.TabIndex = 3;
            // 
            // HelloMessage
            // 
            this.HelloMessage.AutoSize = true;
            this.HelloMessage.Location = new System.Drawing.Point(12, 13);
            this.HelloMessage.Name = "HelloMessage";
            this.HelloMessage.Size = new System.Drawing.Size(0, 13);
            this.HelloMessage.TabIndex = 4;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(213, 97);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click_1);
            // 
            // Admin
            // 
            this.Admin.Location = new System.Drawing.Point(213, 141);
            this.Admin.Name = "Admin";
            this.Admin.Size = new System.Drawing.Size(75, 23);
            this.Admin.TabIndex = 6;
            this.Admin.Text = "Admin";
            this.Admin.UseVisualStyleBackColor = true;
            this.Admin.Click += new System.EventHandler(this.Admin_Click);
            // 
            // JobTitlelabel
            // 
            this.JobTitlelabel.AutoSize = true;
            this.JobTitlelabel.Location = new System.Drawing.Point(288, 9);
            this.JobTitlelabel.Name = "JobTitlelabel";
            this.JobTitlelabel.Size = new System.Drawing.Size(0, 13);
            this.JobTitlelabel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 176);
            this.Controls.Add(this.JobTitlelabel);
            this.Controls.Add(this.Admin);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.HelloMessage);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.Exit);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label HelloMessage;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button Admin;
        private System.Windows.Forms.Label JobTitlelabel;
    }
}