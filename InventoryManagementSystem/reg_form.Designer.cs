
namespace InventoryManagementSystem
{
    partial class reg_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(reg_form));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.loginText = new System.Windows.Forms.TextBox();
            this.surnameText = new System.Windows.Forms.TextBox();
            this.createAccount = new System.Windows.Forms.Label();
            this.registerLabel = new System.Windows.Forms.Label();
            this.companyName = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
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
            this.MainPanel.Controls.Add(this.passwordText);
            this.MainPanel.Controls.Add(this.loginText);
            this.MainPanel.Controls.Add(this.surnameText);
            this.MainPanel.Controls.Add(this.createAccount);
            this.MainPanel.Controls.Add(this.registerLabel);
            this.MainPanel.Controls.Add(this.companyName);
            this.MainPanel.Controls.Add(this.nameText);
            this.MainPanel.Controls.Add(this.log_btn);
            this.MainPanel.Controls.Add(this.HeadingPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 1;
            // 
            // passwordText
            // 
            this.passwordText.BackColor = System.Drawing.SystemColors.Window;
            this.passwordText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordText.Location = new System.Drawing.Point(263, 339);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(280, 39);
            this.passwordText.TabIndex = 10;
            this.passwordText.Enter += new System.EventHandler(this.passwordText_Enter);
            this.passwordText.Leave += new System.EventHandler(this.passwordText_Leave);
            // 
            // loginText
            // 
            this.loginText.BackColor = System.Drawing.SystemColors.Window;
            this.loginText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.loginText.Location = new System.Drawing.Point(263, 269);
            this.loginText.Name = "loginText";
            this.loginText.Size = new System.Drawing.Size(280, 39);
            this.loginText.TabIndex = 9;
            this.loginText.Enter += new System.EventHandler(this.loginText_Enter);
            this.loginText.Leave += new System.EventHandler(this.loginText_Leave);
            // 
            // surnameText
            // 
            this.surnameText.BackColor = System.Drawing.SystemColors.Window;
            this.surnameText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.surnameText.Location = new System.Drawing.Point(445, 148);
            this.surnameText.Name = "surnameText";
            this.surnameText.Size = new System.Drawing.Size(280, 39);
            this.surnameText.TabIndex = 8;
            this.surnameText.Enter += new System.EventHandler(this.surnameText_Enter);
            this.surnameText.Leave += new System.EventHandler(this.surnameText_Leave);
            // 
            // createAccount
            // 
            this.createAccount.AutoSize = true;
            this.createAccount.BackColor = System.Drawing.Color.Transparent;
            this.createAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAccount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.createAccount.ForeColor = System.Drawing.Color.LightCyan;
            this.createAccount.Location = new System.Drawing.Point(365, 423);
            this.createAccount.Name = "createAccount";
            this.createAccount.Size = new System.Drawing.Size(91, 19);
            this.createAccount.TabIndex = 6;
            this.createAccount.Text = "Авторизация";
            this.createAccount.Click += new System.EventHandler(this.createAccount_Click);
            // 
            // registerLabel
            // 
            this.registerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.registerLabel.AutoSize = true;
            this.registerLabel.BackColor = System.Drawing.Color.Transparent;
            this.registerLabel.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.registerLabel.ForeColor = System.Drawing.Color.LightCyan;
            this.registerLabel.Location = new System.Drawing.Point(313, 94);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(203, 36);
            this.registerLabel.TabIndex = 0;
            this.registerLabel.Text = "Регистрация";
            // 
            // companyName
            // 
            this.companyName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyName.Location = new System.Drawing.Point(263, 203);
            this.companyName.Name = "companyName";
            this.companyName.Size = new System.Drawing.Size(280, 39);
            this.companyName.TabIndex = 5;
            this.companyName.Enter += new System.EventHandler(this.companyName_Enter);
            this.companyName.Leave += new System.EventHandler(this.companyName_Leave);
            // 
            // nameText
            // 
            this.nameText.BackColor = System.Drawing.SystemColors.Window;
            this.nameText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameText.Location = new System.Drawing.Point(75, 148);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(280, 39);
            this.nameText.TabIndex = 1;
            this.nameText.Enter += new System.EventHandler(this.nameText_Enter);
            this.nameText.Leave += new System.EventHandler(this.nameText_Leave);
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.Color.Lavender;
            this.log_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.log_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.log_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log_btn.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.log_btn.Location = new System.Drawing.Point(308, 384);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(208, 36);
            this.log_btn.TabIndex = 3;
            this.log_btn.Text = "Зарегистрироваться";
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
            this.HeadingPanel.Size = new System.Drawing.Size(800, 91);
            this.HeadingPanel.TabIndex = 0;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.BackColor = System.Drawing.Color.Transparent;
            this.ProgramName.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramName.ForeColor = System.Drawing.Color.Black;
            this.ProgramName.Location = new System.Drawing.Point(313, 25);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(181, 42);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "InvenTrack";
            // 
            // reg_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Name = "reg_form";
            this.Text = "InvenTrack Register";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox loginText;
        private System.Windows.Forms.TextBox surnameText;
        private System.Windows.Forms.Label createAccount;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.TextBox companyName;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label ProgramName;
    }
}