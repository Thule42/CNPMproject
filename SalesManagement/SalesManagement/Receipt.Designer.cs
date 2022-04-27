
namespace SalesManagement
{
    partial class Receipt
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodCompanyDataSet5 = new SalesManagement.FoodCompanyDataSet5();
            this.exportTableAdapter = new SalesManagement.FoodCompanyDataSet5TableAdapters.ExportTableAdapter();
            this.foodCompanyDataSet6 = new SalesManagement.FoodCompanyDataSet6();
            this.exportBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.exportTableAdapter1 = new SalesManagement.FoodCompanyDataSet6TableAdapters.ExportTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.printExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.agentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exportDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.paymentStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(446, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Export Receipt";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.exportIDDataGridViewTextBoxColumn,
            this.productIDDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.agentIDDataGridViewTextBoxColumn,
            this.exportDateDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.totalPriceDataGridViewTextBoxColumn,
            this.deliveryStatusDataGridViewTextBoxColumn,
            this.paymentStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.exportBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(26, 94);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1042, 453);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // exportBindingSource
            // 
            this.exportBindingSource.DataMember = "Export";
            this.exportBindingSource.DataSource = this.foodCompanyDataSet5;
            // 
            // foodCompanyDataSet5
            // 
            this.foodCompanyDataSet5.DataSetName = "FoodCompanyDataSet5";
            this.foodCompanyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exportTableAdapter
            // 
            this.exportTableAdapter.ClearBeforeFill = true;
            // 
            // foodCompanyDataSet6
            // 
            this.foodCompanyDataSet6.DataSetName = "FoodCompanyDataSet6";
            this.foodCompanyDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // exportBindingSource1
            // 
            this.exportBindingSource1.DataMember = "Export";
            this.exportBindingSource1.DataSource = this.foodCompanyDataSet6;
            // 
            // exportTableAdapter1
            // 
            this.exportTableAdapter1.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.printExcelToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1123, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // printExcelToolStripMenuItem
            // 
            this.printExcelToolStripMenuItem.Name = "printExcelToolStripMenuItem";
            this.printExcelToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.printExcelToolStripMenuItem.Text = "Print File Excel";
            this.printExcelToolStripMenuItem.Click += new System.EventHandler(this.printExcelToolStripMenuItem_Click);
            // 
            // exportIDDataGridViewTextBoxColumn
            // 
            this.exportIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.exportIDDataGridViewTextBoxColumn.DataPropertyName = "ExportID";
            this.exportIDDataGridViewTextBoxColumn.HeaderText = "ExportID";
            this.exportIDDataGridViewTextBoxColumn.Name = "exportIDDataGridViewTextBoxColumn";
            this.exportIDDataGridViewTextBoxColumn.Width = 73;
            // 
            // productIDDataGridViewTextBoxColumn
            // 
            this.productIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productIDDataGridViewTextBoxColumn.DataPropertyName = "ProductID";
            this.productIDDataGridViewTextBoxColumn.HeaderText = "ProductID";
            this.productIDDataGridViewTextBoxColumn.Name = "productIDDataGridViewTextBoxColumn";
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            this.productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            // 
            // agentIDDataGridViewTextBoxColumn
            // 
            this.agentIDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.agentIDDataGridViewTextBoxColumn.DataPropertyName = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.HeaderText = "AgentID";
            this.agentIDDataGridViewTextBoxColumn.Name = "agentIDDataGridViewTextBoxColumn";
            // 
            // exportDateDataGridViewTextBoxColumn
            // 
            this.exportDateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.exportDateDataGridViewTextBoxColumn.DataPropertyName = "ExportDate";
            this.exportDateDataGridViewTextBoxColumn.HeaderText = "ExportDate";
            this.exportDateDataGridViewTextBoxColumn.Name = "exportDateDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            this.totalPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            this.totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            // 
            // deliveryStatusDataGridViewTextBoxColumn
            // 
            this.deliveryStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deliveryStatusDataGridViewTextBoxColumn.DataPropertyName = "DeliveryStatus";
            this.deliveryStatusDataGridViewTextBoxColumn.HeaderText = "DeliveryStatus";
            this.deliveryStatusDataGridViewTextBoxColumn.Name = "deliveryStatusDataGridViewTextBoxColumn";
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            this.paymentStatusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            this.paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Receipt";
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exportBindingSource1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FoodCompanyDataSet5 foodCompanyDataSet5;
        private System.Windows.Forms.BindingSource exportBindingSource;
        private FoodCompanyDataSet5TableAdapters.ExportTableAdapter exportTableAdapter;
        private FoodCompanyDataSet6 foodCompanyDataSet6;
        private System.Windows.Forms.BindingSource exportBindingSource1;
        private FoodCompanyDataSet6TableAdapters.ExportTableAdapter exportTableAdapter1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem printExcelToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn agentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn exportDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
    }
}