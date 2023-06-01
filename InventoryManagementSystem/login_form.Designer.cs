
namespace InventoryManagementSystem
{
    partial class login_form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.reloadPassword = new System.Windows.Forms.Label();
            this.createAccount = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.log_btn = new System.Windows.Forms.Button();
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ProgramName = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.HeadingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.Controls.Add(this.reloadPassword);
            this.MainPanel.Controls.Add(this.createAccount);
            this.MainPanel.Controls.Add(this.loginLabel);
            this.MainPanel.Controls.Add(this.PasswordText);
            this.MainPanel.Controls.Add(this.loginText);
            this.MainPanel.Controls.Add(this.log_btn);
            this.MainPanel.Controls.Add(this.HeadingPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(414, 451);
            this.MainPanel.TabIndex = 0;
            // 
            // reloadPassword
            // 
            this.reloadPassword.AutoSize = true;
            this.reloadPassword.BackColor = System.Drawing.Color.Transparent;
            this.reloadPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reloadPassword.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.reloadPassword.ForeColor = System.Drawing.Color.LightCyan;
            this.reloadPassword.Location = new System.Drawing.Point(218, 381);
            this.reloadPassword.Name = "reloadPassword";
            this.reloadPassword.Size = new System.Drawing.Size(112, 19);
            this.reloadPassword.TabIndex = 7;
            this.reloadPassword.Text = "Забыли пароль?";
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.BackColor = System.Drawing.Color.Transparent;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccount.ForeColor = System.Drawing.Color.LightCyan;
            this.createAccount.Location = new System.Drawing.Point(102, 381);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(87, 19);
            this.createAccount.TabIndex = 6;
            this.createAccount.Text = "Регистрация";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginLabel.AutoSize = true;
            this.loginLabel.BackColor = System.Drawing.Color.Transparent;
            this.loginLabel.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.loginLabel.Location = new System.Drawing.Point(75, 94);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(204, 36);
            this.loginLabel.TabIndex = 0;
            this.loginLabel.Text = "Авторизация";
            // 
            // PasswordText
            // 
            this.PasswordText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordText.Location = new System.Drawing.Point(75, 227);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(280, 39);
            this.PasswordText.TabIndex = 5;
            this.PasswordText.Enter += new System.EventHandler(this.PasswordText_Enter);
            this.PasswordText.Leave += new System.EventHandler(this.PasswordText_Leave);
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.SystemColors.Window;
            this.loginText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginText.Location = new System.Drawing.Point(75, 148);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(280, 39);
            this.loginText.TabIndex = 1;
            this.loginText.Enter += new System.EventHandler(this.loginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.loginText_Leave);
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.Lavender;
            this.log_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log_btn.Location = new System.Drawing.Point(144, 322);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(144, 36);
            this.log_btn.TabIndex = 3;
            this.log_btn.Text = "Войти";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.log_btn_Click);
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeadingPanel.BackgroundImage")));
            this.HeadingPanel.Controls.Add(this.ProgramName);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(414, 91);
            this.HeadingPanel.TabIndex = 0;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.BackColor = System.Drawing.Color.Transparent;
            this.ProgramName.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramName.ForeColor = System.Drawing.Color.Black;
            this.ProgramName.Location = new System.Drawing.Point(125, 19);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(181, 42);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "InvenTrack";
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 451);
            this.Controls.Add(this.MainPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "login_form";
            this.Text = "InvenTrack";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label loginLabel;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label reloadPassword;
        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label ProgramName;
    }
}

