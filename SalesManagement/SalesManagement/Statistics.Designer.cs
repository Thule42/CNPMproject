
namespace SalesManagement
{
    partial class Statistics
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
            this.foodCompanyDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodCompanyDataSet5 = new SalesManagement.FoodCompanyDataSet5();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btxImport = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btxRevenue = new System.Windows.Forms.Button();
            this.numericUpDownMonth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistics";
            // 
            // foodCompanyDataSet5BindingSource
            // 
            this.foodCompanyDataSet5BindingSource.DataSource = this.foodCompanyDataSet5;
            this.foodCompanyDataSet5BindingSource.Position = 0;
            // 
            // foodCompanyDataSet5
            // 
            this.foodCompanyDataSet5.DataSetName = "FoodCompanyDataSet5";
            this.foodCompanyDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(52, 70);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(835, 341);
            this.dataGridView1.TabIndex = 1;
            // 
            // btxImport
            // 
            this.btxImport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxImport.Location = new System.Drawing.Point(149, 443);
            this.btxImport.Name = "btxImport";
            this.btxImport.Size = new System.Drawing.Size(146, 55);
            this.btxImport.TabIndex = 2;
            this.btxImport.Text = "Import History";
            this.btxImport.UseVisualStyleBackColor = true;
            this.btxImport.Click += new System.EventHandler(this.btxImport_Click);
            // 
            // btnExport
            // 
            this.btnExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExport.Location = new System.Drawing.Point(349, 443);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(146, 55);
            this.btnExport.TabIndex = 3;
            this.btnExport.Text = "Export History";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btxRevenue
            // 
            this.btxRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btxRevenue.Location = new System.Drawing.Point(565, 443);
            this.btxRevenue.Name = "btxRevenue";
            this.btxRevenue.Size = new System.Drawing.Size(146, 55);
            this.btxRevenue.TabIndex = 4;
            this.btxRevenue.Text = "Revenue";
            this.btxRevenue.UseVisualStyleBackColor = true;
            this.btxRevenue.Click += new System.EventHandler(this.btxRevenue_Click);
            // 
            // numericUpDownMonth
            // 
            this.numericUpDownMonth.Location = new System.Drawing.Point(956, 204);
            this.numericUpDownMonth.Name = "numericUpDownMonth";
            this.numericUpDownMonth.Size = new System.Drawing.Size(112, 20);
            this.numericUpDownMonth.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(966, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Month";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 530);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownMonth);
            this.Controls.Add(this.btxRevenue);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btxImport);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "Statistics";
            this.Text = "   ";
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodCompanyDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource foodCompanyDataSet5BindingSource;
        private FoodCompanyDataSet5 foodCompanyDataSet5;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btxImport;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btxRevenue;
        private System.Windows.Forms.NumericUpDown numericUpDownMonth;
        private System.Windows.Forms.Label label2;
    }
}