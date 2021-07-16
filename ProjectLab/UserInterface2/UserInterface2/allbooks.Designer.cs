
namespace UserInterface2
{
    partial class allbooks
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookinShelfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookDatabaseDataSet = new UserInterface2.BookDatabaseDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.booksTableAdapter = new UserInterface2.BookDatabaseDataSetTableAdapters.BooksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.purchaseYearDataGridViewTextBoxColumn,
            this.bookinShelfDataGridViewTextBoxColumn,
            this.purchaseCostDataGridViewTextBoxColumn,
            this.rentCostDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(23, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(2055, 968);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookIdDataGridViewTextBoxColumn
            // 
            this.bookIdDataGridViewTextBoxColumn.DataPropertyName = "BookId";
            this.bookIdDataGridViewTextBoxColumn.HeaderText = "BookId";
            this.bookIdDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.bookIdDataGridViewTextBoxColumn.Name = "bookIdDataGridViewTextBoxColumn";
            this.bookIdDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookIdDataGridViewTextBoxColumn.Width = 250;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 250;
            // 
            // bookAuthorDataGridViewTextBoxColumn
            // 
            this.bookAuthorDataGridViewTextBoxColumn.DataPropertyName = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.HeaderText = "BookAuthor";
            this.bookAuthorDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.bookAuthorDataGridViewTextBoxColumn.Name = "bookAuthorDataGridViewTextBoxColumn";
            this.bookAuthorDataGridViewTextBoxColumn.Width = 250;
            // 
            // purchaseYearDataGridViewTextBoxColumn
            // 
            this.purchaseYearDataGridViewTextBoxColumn.DataPropertyName = "PurchaseYear";
            this.purchaseYearDataGridViewTextBoxColumn.HeaderText = "PurchaseYear";
            this.purchaseYearDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.purchaseYearDataGridViewTextBoxColumn.Name = "purchaseYearDataGridViewTextBoxColumn";
            this.purchaseYearDataGridViewTextBoxColumn.Width = 250;
            // 
            // bookinShelfDataGridViewTextBoxColumn
            // 
            this.bookinShelfDataGridViewTextBoxColumn.DataPropertyName = "BookinShelf";
            this.bookinShelfDataGridViewTextBoxColumn.HeaderText = "BookinShelf";
            this.bookinShelfDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.bookinShelfDataGridViewTextBoxColumn.Name = "bookinShelfDataGridViewTextBoxColumn";
            this.bookinShelfDataGridViewTextBoxColumn.Width = 250;
            // 
            // purchaseCostDataGridViewTextBoxColumn
            // 
            this.purchaseCostDataGridViewTextBoxColumn.DataPropertyName = "PurchaseCost";
            this.purchaseCostDataGridViewTextBoxColumn.HeaderText = "PurchaseCost";
            this.purchaseCostDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.purchaseCostDataGridViewTextBoxColumn.Name = "purchaseCostDataGridViewTextBoxColumn";
            this.purchaseCostDataGridViewTextBoxColumn.Width = 250;
            // 
            // rentCostDataGridViewTextBoxColumn
            // 
            this.rentCostDataGridViewTextBoxColumn.DataPropertyName = "RentCost";
            this.rentCostDataGridViewTextBoxColumn.HeaderText = "RentCost";
            this.rentCostDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.rentCostDataGridViewTextBoxColumn.Name = "rentCostDataGridViewTextBoxColumn";
            this.rentCostDataGridViewTextBoxColumn.Width = 250;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.bookDatabaseDataSet;
            // 
            // bookDatabaseDataSet
            // 
            this.bookDatabaseDataSet.DataSetName = "BookDatabaseDataSet";
            this.bookDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(411, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(429, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "List of All Available Books";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // allbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1082, 677);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "allbooks";
            this.Text = "allbooks";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.allbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private BookDatabaseDataSet bookDatabaseDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BookDatabaseDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookinShelfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentCostDataGridViewTextBoxColumn;
    }
}