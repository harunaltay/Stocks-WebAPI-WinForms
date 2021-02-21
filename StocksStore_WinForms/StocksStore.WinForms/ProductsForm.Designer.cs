
namespace StocksStore.WinForms
{
    partial class ProductsForm
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
            this.label_ProductID = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_UnitPrice = new System.Windows.Forms.Label();
            this.label_Category = new System.Windows.Forms.Label();
            this.label_Supplier = new System.Windows.Forms.Label();
            this.textBox_ProductID = new System.Windows.Forms.TextBox();
            this.textBox_ProductName = new System.Windows.Forms.TextBox();
            this.textBox_UnitPrice = new System.Windows.Forms.TextBox();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.comboBox_Supplier = new System.Windows.Forms.ComboBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_ClearForm = new System.Windows.Forms.Button();
            this.dataGridView_Products = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).BeginInit();
            this.SuspendLayout();
            // 
            // label_ProductID
            // 
            this.label_ProductID.AutoSize = true;
            this.label_ProductID.Location = new System.Drawing.Point(42, 64);
            this.label_ProductID.Name = "label_ProductID";
            this.label_ProductID.Size = new System.Drawing.Size(74, 17);
            this.label_ProductID.TabIndex = 0;
            this.label_ProductID.Text = "Product ID";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(42, 100);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(98, 17);
            this.label_ProductName.TabIndex = 1;
            this.label_ProductName.Text = "Product Name";
            // 
            // label_UnitPrice
            // 
            this.label_UnitPrice.AutoSize = true;
            this.label_UnitPrice.Location = new System.Drawing.Point(42, 136);
            this.label_UnitPrice.Name = "label_UnitPrice";
            this.label_UnitPrice.Size = new System.Drawing.Size(69, 17);
            this.label_UnitPrice.TabIndex = 2;
            this.label_UnitPrice.Text = "Unit Price";
            // 
            // label_Category
            // 
            this.label_Category.AutoSize = true;
            this.label_Category.Location = new System.Drawing.Point(42, 173);
            this.label_Category.Name = "label_Category";
            this.label_Category.Size = new System.Drawing.Size(65, 17);
            this.label_Category.TabIndex = 3;
            this.label_Category.Text = "Category";
            // 
            // label_Supplier
            // 
            this.label_Supplier.AutoSize = true;
            this.label_Supplier.Location = new System.Drawing.Point(42, 213);
            this.label_Supplier.Name = "label_Supplier";
            this.label_Supplier.Size = new System.Drawing.Size(60, 17);
            this.label_Supplier.TabIndex = 4;
            this.label_Supplier.Text = "Supplier";
            // 
            // textBox_ProductID
            // 
            this.textBox_ProductID.Location = new System.Drawing.Point(150, 64);
            this.textBox_ProductID.Name = "textBox_ProductID";
            this.textBox_ProductID.Size = new System.Drawing.Size(235, 22);
            this.textBox_ProductID.TabIndex = 0;
            // 
            // textBox_ProductName
            // 
            this.textBox_ProductName.Location = new System.Drawing.Point(150, 100);
            this.textBox_ProductName.Name = "textBox_ProductName";
            this.textBox_ProductName.Size = new System.Drawing.Size(235, 22);
            this.textBox_ProductName.TabIndex = 1;
            // 
            // textBox_UnitPrice
            // 
            this.textBox_UnitPrice.Location = new System.Drawing.Point(150, 136);
            this.textBox_UnitPrice.Name = "textBox_UnitPrice";
            this.textBox_UnitPrice.Size = new System.Drawing.Size(235, 22);
            this.textBox_UnitPrice.TabIndex = 2;
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(150, 173);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(235, 24);
            this.comboBox_Category.TabIndex = 3;
            // 
            // comboBox_Supplier
            // 
            this.comboBox_Supplier.FormattingEnabled = true;
            this.comboBox_Supplier.Location = new System.Drawing.Point(150, 213);
            this.comboBox_Supplier.Name = "comboBox_Supplier";
            this.comboBox_Supplier.Size = new System.Drawing.Size(235, 24);
            this.comboBox_Supplier.TabIndex = 4;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(45, 264);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 5;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(142, 264);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 6;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Location = new System.Drawing.Point(264, 264);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 7;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_ClearForm
            // 
            this.btn_ClearForm.Location = new System.Drawing.Point(382, 264);
            this.btn_ClearForm.Name = "btn_ClearForm";
            this.btn_ClearForm.Size = new System.Drawing.Size(105, 23);
            this.btn_ClearForm.TabIndex = 8;
            this.btn_ClearForm.Text = "Clear Form";
            this.btn_ClearForm.UseVisualStyleBackColor = true;
            this.btn_ClearForm.Click += new System.EventHandler(this.btn_ClearForm_Click);
            // 
            // dataGridView_Products
            // 
            this.dataGridView_Products.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_Products.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_Products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Products.Location = new System.Drawing.Point(12, 341);
            this.dataGridView_Products.MultiSelect = false;
            this.dataGridView_Products.Name = "dataGridView_Products";
            this.dataGridView_Products.RowHeadersWidth = 51;
            this.dataGridView_Products.RowTemplate.Height = 24;
            this.dataGridView_Products.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_Products.Size = new System.Drawing.Size(745, 424);
            this.dataGridView_Products.TabIndex = 9;
            this.dataGridView_Products.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_Products_RowEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Welcome to Harun\'s Product Form!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 312);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Product List";
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(771, 777);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView_Products);
            this.Controls.Add(this.btn_ClearForm);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Insert);
            this.Controls.Add(this.comboBox_Supplier);
            this.Controls.Add(this.comboBox_Category);
            this.Controls.Add(this.textBox_UnitPrice);
            this.Controls.Add(this.textBox_ProductName);
            this.Controls.Add(this.textBox_ProductID);
            this.Controls.Add(this.label_Supplier);
            this.Controls.Add(this.label_Category);
            this.Controls.Add(this.label_UnitPrice);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_ProductID);
            this.Name = "ProductsForm";
            this.Text = "Products Form";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Products)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_ProductID;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_UnitPrice;
        private System.Windows.Forms.Label label_Category;
        private System.Windows.Forms.Label label_Supplier;
        private System.Windows.Forms.TextBox textBox_ProductID;
        private System.Windows.Forms.TextBox textBox_ProductName;
        private System.Windows.Forms.TextBox textBox_UnitPrice;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Supplier;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_ClearForm;
        private System.Windows.Forms.DataGridView dataGridView_Products;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

