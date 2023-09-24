namespace Trojan_Travels.UserControls
{
    partial class ProductsUserControls
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            groupBox1 = new GroupBox();
            txtEditProductId = new TextBox();
            label19 = new Label();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            txtProductName = new TextBox();
            label11 = new Label();
            dataGVProduct = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVProduct).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGVProduct);
            splitContainer1.Size = new Size(1126, 524);
            splitContainer1.SplitterDistance = 375;
            splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(80, 32);
            label3.Name = "label3";
            label3.Size = new Size(174, 25);
            label3.TabIndex = 24;
            label3.Text = "Add a new Product";
            label3.Click += label3_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEditProductId);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnEditProduct);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(3, 138);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(374, 104);
            groupBox1.TabIndex = 23;
            groupBox1.TabStop = false;
            groupBox1.Text = "Product";
            // 
            // txtEditProductId
            // 
            txtEditProductId.Location = new Point(200, 26);
            txtEditProductId.Margin = new Padding(3, 2, 3, 2);
            txtEditProductId.Name = "txtEditProductId";
            txtEditProductId.ReadOnly = true;
            txtEditProductId.Size = new Size(164, 23);
            txtEditProductId.TabIndex = 28;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(17, 26);
            label19.Name = "label19";
            label19.Size = new Size(59, 15);
            label19.TabIndex = 27;
            label19.Text = "ProductId";
            // 
            // btnEditProduct
            // 
            btnEditProduct.Location = new Point(304, 74);
            btnEditProduct.Margin = new Padding(3, 2, 3, 2);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(55, 26);
            btnEditProduct.TabIndex = 24;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(210, 74);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(55, 26);
            btnAddProduct.TabIndex = 21;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(201, 49);
            txtProductName.Margin = new Padding(3, 2, 3, 2);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(164, 23);
            txtProductName.TabIndex = 7;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(17, 54);
            label11.Name = "label11";
            label11.Size = new Size(84, 15);
            label11.TabIndex = 6;
            label11.Text = "Product Name";
            // 
            // dataGVProduct
            // 
            dataGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVProduct.Location = new Point(-5, 0);
            dataGVProduct.Margin = new Padding(3, 2, 3, 2);
            dataGVProduct.Name = "dataGVProduct";
            dataGVProduct.RowHeadersWidth = 51;
            dataGVProduct.RowTemplate.Height = 29;
            dataGVProduct.Size = new Size(749, 522);
            dataGVProduct.TabIndex = 29;
            // 
            // ProductsUserControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProductsUserControls";
            Size = new Size(1126, 524);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVProduct).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGVProduct;
        private GroupBox groupBox1;
        private TextBox txtEditProductId;
        private Label label19;
        private Button btnEditProduct;
        private Button btnAddProduct;
        private TextBox txtProductName;
        private Label label11;
        private Label label3;
    }
}
