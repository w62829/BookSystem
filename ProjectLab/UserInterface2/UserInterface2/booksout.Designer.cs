
namespace UserInterface2
{
    partial class booksout
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
            this.bookDatabaseDataSet = new UserInterface2.BookDatabaseDataSet();
            this.bookDatabaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.bookDatabaseDataSet1 = new UserInterface2.BookDatabaseDataSet1();
            this.booksOutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksOutTableAdapter = new UserInterface2.BookDatabaseDataSet1TableAdapters.BooksOutTableAdapter();
            this.bookIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookAuthorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookRentOutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookBackInDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentCostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.othercopiesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksOutBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIdDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.bookAuthorDataGridViewTextBoxColumn,
            this.purchaseYearDataGridViewTextBoxColumn,
            this.bookRentOutDataGridViewTextBoxColumn,
            this.bookBackInDataGridViewTextBoxColumn,
            this.rentCostDataGridViewTextBoxColumn,
            this.othercopiesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.booksOutBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(33, 153);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 102;
            this.dataGridView1.RowTemplate.Height = 40;
            this.dataGridView1.Size = new System.Drawing.Size(3672, 1658);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookDatabaseDataSet
            // 
            this.bookDatabaseDataSet.DataSetName = "BookDatabaseDataSet";
            this.bookDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookDatabaseDataSetBindingSource
            // 
            this.bookDatabaseDataSetBindingSource.DataSource = this.bookDatabaseDataSet;
            this.bookDatabaseDataSetBindingSource.Position = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(792, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 78);
            this.label1.TabIndex = 1;
            this.label1.Text = "Books Out on Rent";
            // 
            // bookDatabaseDataSet1
            // 
            this.bookDatabaseDataSet1.DataSetName = "BookDatabaseDataSet1";
            this.bookDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // booksOutBindingSource
            // 
            this.booksOutBindingSource.DataMember = "BooksOut";
            this.booksOutBindingSource.DataSource = this.bookDatabaseDataSet1;
            // 
            // booksOutTableAdapter
            // 
            this.booksOutTableAdapter.ClearBeforeFill = true;
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
            // bookRentOutDataGridViewTextBoxColumn
            // 
            this.bookRentOutDataGridViewTextBoxColumn.DataPropertyName = "Book_Rent_Out";
            this.bookRentOutDataGridViewTextBoxColumn.HeaderText = "Book_Rent_Out";
            this.bookRentOutDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.bookRentOutDataGridViewTextBoxColumn.Name = "bookRentOutDataGridViewTextBoxColumn";
            this.bookRentOutDataGridViewTextBoxColumn.Width = 250;
            // 
            // bookBackInDataGridViewTextBoxColumn
            // 
            this.bookBackInDataGridViewTextBoxColumn.DataPropertyName = "Book_Back_In";
            this.bookBackInDataGridViewTextBoxColumn.HeaderText = "Book_Back_In";
            this.bookBackInDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.bookBackInDataGridViewTextBoxColumn.Name = "bookBackInDataGridViewTextBoxColumn";
            this.bookBackInDataGridViewTextBoxColumn.Width = 250;
            // 
            // rentCostDataGridViewTextBoxColumn
            // 
            this.rentCostDataGridViewTextBoxColumn.DataPropertyName = "RentCost";
            this.rentCostDataGridViewTextBoxColumn.HeaderText = "RentCost";
            this.rentCostDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.rentCostDataGridViewTextBoxColumn.Name = "rentCostDataGridViewTextBoxColumn";
            this.rentCostDataGridViewTextBoxColumn.Width = 250;
            // 
            // othercopiesDataGridViewTextBoxColumn
            // 
            this.othercopiesDataGridViewTextBoxColumn.DataPropertyName = "Other_copies";
            this.othercopiesDataGridViewTextBoxColumn.HeaderText = "Other_copies";
            this.othercopiesDataGridViewTextBoxColumn.MinimumWidth = 12;
            this.othercopiesDataGridViewTextBoxColumn.Name = "othercopiesDataGridViewTextBoxColumn";
            this.othercopiesDataGridViewTextBoxColumn.Width = 250;
            // 
            // booksout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2359, 1065);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "booksout";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.booksout_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksOutBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private BookDatabaseDataSet bookDatabaseDataSet;
        private System.Windows.Forms.BindingSource bookDatabaseDataSetBindingSource;
        private System.Windows.Forms.Label label1;
        private BookDatabaseDataSet1 bookDatabaseDataSet1;
        private System.Windows.Forms.BindingSource booksOutBindingSource;
        private BookDatabaseDataSet1TableAdapters.BooksOutTableAdapter booksOutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookAuthorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookRentOutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookBackInDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentCostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn othercopiesDataGridViewTextBoxColumn;
    }
}