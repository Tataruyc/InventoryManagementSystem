
namespace InventoryManagementSystem
{
    partial class graph_form
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
            this.showProductsTable = new System.Windows.Forms.Button();
            this.showSalesTable = new System.Windows.Forms.Button();
            this.showShopTable = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // showProductsTable
            // 
            this.showProductsTable.Location = new System.Drawing.Point(21, 12);
            this.showProductsTable.Name = "showProductsTable";
            this.showProductsTable.Size = new System.Drawing.Size(153, 23);
            this.showProductsTable.TabIndex = 1;
            this.showProductsTable.Text = "График продуктов";
            this.showProductsTable.UseVisualStyleBackColor = true;
            this.showProductsTable.Click += new System.EventHandler(this.showProductsTable_Click);
            // 
            // showSalesTable
            // 
            this.showSalesTable.Location = new System.Drawing.Point(21, 41);
            this.showSalesTable.Name = "showSalesTable";
            this.showSalesTable.Size = new System.Drawing.Size(153, 24);
            this.showSalesTable.TabIndex = 2;
            this.showSalesTable.Text = "График покупок";
            this.showSalesTable.UseVisualStyleBackColor = true;
            this.showSalesTable.Click += new System.EventHandler(this.showSalesTable_Click);
            // 
            // showShopTable
            // 
            this.showShopTable.Location = new System.Drawing.Point(21, 71);
            this.showShopTable.Name = "showShopTable";
            this.showShopTable.Size = new System.Drawing.Size(153, 24);
            this.showShopTable.TabIndex = 3;
            this.showShopTable.Text = "График продаж";
            this.showShopTable.UseVisualStyleBackColor = true;
            this.showShopTable.Click += new System.EventHandler(this.showShopTable_Click);
            // 
            // graph_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showShopTable);
            this.Controls.Add(this.showSalesTable);
            this.Controls.Add(this.showProductsTable);
            this.Name = "graph_form";
            this.Text = "InvenTrack";
            this.ResumeLayout(false);

        }

        #endregion

        private OxyPlot.WindowsForms.PlotView graph;
        private System.Windows.Forms.Button showProductsTable;
        private System.Windows.Forms.Button showSalesTable;
        private System.Windows.Forms.Button showShopTable;
    }
}