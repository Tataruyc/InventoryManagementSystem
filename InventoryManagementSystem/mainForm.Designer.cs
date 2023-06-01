
namespace InventoryManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.HeadingPanel = new System.Windows.Forms.Panel();
            this.ProgramName = new System.Windows.Forms.Label();
            this.companyLabel = new System.Windows.Forms.Label();
            this.usersCompany = new System.Windows.Forms.Label();
            this.user = new System.Windows.Forms.Label();
            this.usersName = new System.Windows.Forms.Label();
            this.userSurname = new System.Windows.Forms.Label();
            this.productManagmentBtn = new System.Windows.Forms.Button();
            this.traidingInfoBtn = new System.Windows.Forms.Button();
            this.purchaseManagmentBtn = new System.Windows.Forms.Button();
            this.information = new System.Windows.Forms.DataGridView();
            this.changeBtnPanel = new System.Windows.Forms.Panel();
            this.graphBuildBtn = new System.Windows.Forms.Button();
            this.updateTableBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.HeadingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.information)).BeginInit();
            this.changeBtnPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeadingPanel
            // 
            this.HeadingPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HeadingPanel.BackgroundImage")));
            this.HeadingPanel.Controls.Add(this.ProgramName);
            this.HeadingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeadingPanel.Location = new System.Drawing.Point(0, 0);
            this.HeadingPanel.Name = "HeadingPanel";
            this.HeadingPanel.Size = new System.Drawing.Size(800, 58);
            this.HeadingPanel.TabIndex = 1;
            // 
            // ProgramName
            // 
            this.ProgramName.AutoSize = true;
            this.ProgramName.BackColor = System.Drawing.Color.Transparent;
            this.ProgramName.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProgramName.ForeColor = System.Drawing.Color.Black;
            this.ProgramName.Location = new System.Drawing.Point(312, 9);
            this.ProgramName.Name = "ProgramName";
            this.ProgramName.Size = new System.Drawing.Size(181, 42);
            this.ProgramName.TabIndex = 4;
            this.ProgramName.Text = "InvenTrack";
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyLabel.Location = new System.Drawing.Point(55, 61);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(120, 30);
            this.companyLabel.TabIndex = 2;
            this.companyLabel.Text = "Компания:";
            // 
            // usersCompany
            // 
            this.usersCompany.AutoSize = true;
            this.usersCompany.BackColor = System.Drawing.Color.Transparent;
            this.usersCompany.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersCompany.Location = new System.Drawing.Point(181, 63);
            this.usersCompany.Name = "usersCompany";
            this.usersCompany.Size = new System.Drawing.Size(102, 30);
            this.usersCompany.TabIndex = 3;
            this.usersCompany.Text = "company";
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.BackColor = System.Drawing.Color.Transparent;
            this.user.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.user.Location = new System.Drawing.Point(55, 93);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(160, 30);
            this.user.TabIndex = 4;
            this.user.Text = "Пользователь:";
            // 
            // usersName
            // 
            this.usersName.AutoSize = true;
            this.usersName.BackColor = System.Drawing.Color.Transparent;
            this.usersName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersName.Location = new System.Drawing.Point(221, 93);
            this.usersName.Name = "usersName";
            this.usersName.Size = new System.Drawing.Size(67, 30);
            this.usersName.TabIndex = 5;
            this.usersName.Text = "name";
            // 
            // userSurname
            // 
            this.userSurname.AutoSize = true;
            this.userSurname.BackColor = System.Drawing.Color.Transparent;
            this.userSurname.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.userSurname.Location = new System.Drawing.Point(298, 93);
            this.userSurname.Name = "userSurname";
            this.userSurname.Size = new System.Drawing.Size(96, 30);
            this.userSurname.TabIndex = 6;
            this.userSurname.Text = "surname";
            // 
            // productManagmentBtn
            // 
            this.productManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.productManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.productManagmentBtn.Location = new System.Drawing.Point(55, 140);
            this.productManagmentBtn.Name = "productManagmentBtn";
            this.productManagmentBtn.Size = new System.Drawing.Size(195, 43);
            this.productManagmentBtn.TabIndex = 7;
            this.productManagmentBtn.Text = "Управление продуктом";
            this.productManagmentBtn.UseVisualStyleBackColor = true;
            this.productManagmentBtn.Click += new System.EventHandler(this.productManagmentBtn_Click);
            // 
            // traidingInfoBtn
            // 
            this.traidingInfoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.traidingInfoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.traidingInfoBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.traidingInfoBtn.Location = new System.Drawing.Point(312, 140);
            this.traidingInfoBtn.Name = "traidingInfoBtn";
            this.traidingInfoBtn.Size = new System.Drawing.Size(195, 43);
            this.traidingInfoBtn.TabIndex = 8;
            this.traidingInfoBtn.Text = "Управление продажами";
            this.traidingInfoBtn.UseVisualStyleBackColor = true;
            this.traidingInfoBtn.Click += new System.EventHandler(this.tradingInfoBtn_Click);
            // 
            // purchaseManagmentBtn
            // 
            this.purchaseManagmentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseManagmentBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.purchaseManagmentBtn.Location = new System.Drawing.Point(567, 140);
            this.purchaseManagmentBtn.Name = "purchaseManagmentBtn";
            this.purchaseManagmentBtn.Size = new System.Drawing.Size(195, 43);
            this.purchaseManagmentBtn.TabIndex = 9;
            this.purchaseManagmentBtn.Text = "Управление покупками";
            this.purchaseManagmentBtn.UseVisualStyleBackColor = true;
            this.purchaseManagmentBtn.Click += new System.EventHandler(this.purchaseManagmentBtn_Click);
            // 
            // information
            // 
            this.information.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.information.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.information.Location = new System.Drawing.Point(55, 198);
            this.information.Name = "information";
            this.information.RowTemplate.Height = 25;
            this.information.Size = new System.Drawing.Size(707, 182);
            this.information.TabIndex = 10;
            this.information.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.information_DefaultValuesNeeded);
            // 
            // changeBtnPanel
            // 
            this.changeBtnPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("changeBtnPanel.BackgroundImage")));
            this.changeBtnPanel.Controls.Add(this.graphBuildBtn);
            this.changeBtnPanel.Controls.Add(this.updateTableBtn);
            this.changeBtnPanel.Controls.Add(this.saveBtn);
            this.changeBtnPanel.Controls.Add(this.deleteBtn);
            this.changeBtnPanel.Controls.Add(this.editBtn);
            this.changeBtnPanel.Location = new System.Drawing.Point(0, 386);
            this.changeBtnPanel.Name = "changeBtnPanel";
            this.changeBtnPanel.Size = new System.Drawing.Size(800, 65);
            this.changeBtnPanel.TabIndex = 11;
            // 
            // graphBuildBtn
            // 
            this.graphBuildBtn.Location = new System.Drawing.Point(55, 29);
            this.graphBuildBtn.Name = "graphBuildBtn";
            this.graphBuildBtn.Size = new System.Drawing.Size(148, 23);
            this.graphBuildBtn.TabIndex = 4;
            this.graphBuildBtn.Text = "Построить график";
            this.graphBuildBtn.UseVisualStyleBackColor = true;
            this.graphBuildBtn.Click += new System.EventHandler(this.graphBuildBtn_Click);
            // 
            // updateTableBtn
            // 
            this.updateTableBtn.Location = new System.Drawing.Point(55, -1);
            this.updateTableBtn.Name = "updateTableBtn";
            this.updateTableBtn.Size = new System.Drawing.Size(75, 23);
            this.updateTableBtn.TabIndex = 3;
            this.updateTableBtn.Text = "Обновить";
            this.updateTableBtn.UseVisualStyleBackColor = true;
            this.updateTableBtn.Click += new System.EventHandler(this.updateTableBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(527, 0);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(75, 23);
            this.saveBtn.TabIndex = 0;
            this.saveBtn.Text = "Добавить";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(689, 0);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Удалить";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(608, 0);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Изменить";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.changeBtnPanel);
            this.Controls.Add(this.information);
            this.Controls.Add(this.purchaseManagmentBtn);
            this.Controls.Add(this.traidingInfoBtn);
            this.Controls.Add(this.productManagmentBtn);
            this.Controls.Add(this.userSurname);
            this.Controls.Add(this.usersName);
            this.Controls.Add(this.user);
            this.Controls.Add(this.usersCompany);
            this.Controls.Add(this.companyLabel);
            this.Controls.Add(this.HeadingPanel);
            this.Name = "MainForm";
            this.Text = "InvenTrack";
            this.HeadingPanel.ResumeLayout(false);
            this.HeadingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.information)).EndInit();
            this.changeBtnPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel HeadingPanel;
        private System.Windows.Forms.Label ProgramName;
        private System.Windows.Forms.Label companyLabel;
        private System.Windows.Forms.Label usersCompany;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label usersName;
        private System.Windows.Forms.Label userSurname;
        private System.Windows.Forms.Button productManagmentBtn;
        private System.Windows.Forms.Button traidingInfoBtn;
        private System.Windows.Forms.Button purchaseManagmentBtn;
        private System.Windows.Forms.DataGridView information;
        private System.Windows.Forms.Panel changeBtnPanel;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button updateTableBtn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.Button graphBuildBtn;
    }
}