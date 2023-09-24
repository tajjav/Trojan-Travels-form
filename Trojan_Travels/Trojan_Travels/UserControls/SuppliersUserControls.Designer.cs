namespace Trojan_Travels.UserControls
{
    partial class SuppliersUserControls
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
            groupBox2 = new GroupBox();
            txtEditSupplierId = new TextBox();
            label5 = new Label();
            btnEditSupplier = new Button();
            btnAddSupplier = new Button();
            txtSupplierName = new TextBox();
            label4 = new Label();
            dataGVSupplier = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVSupplier).BeginInit();
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
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGVSupplier);
            splitContainer1.Size = new Size(1112, 494);
            splitContainer1.SplitterDistance = 370;
            splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(72, 43);
            label3.Name = "label3";
            label3.Size = new Size(177, 25);
            label3.TabIndex = 25;
            label3.Text = "Add a new Supplier";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEditSupplierId);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnEditSupplier);
            groupBox2.Controls.Add(btnAddSupplier);
            groupBox2.Controls.Add(txtSupplierName);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(3, 148);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(375, 124);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Supplier";
            // 
            // txtEditSupplierId
            // 
            txtEditSupplierId.Location = new Point(196, 32);
            txtEditSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtEditSupplierId.Name = "txtEditSupplierId";
            txtEditSupplierId.ReadOnly = true;
            txtEditSupplierId.Size = new Size(164, 23);
            txtEditSupplierId.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 31);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 25;
            label5.Text = "SupplierId";
            // 
            // btnEditSupplier
            // 
            btnEditSupplier.Location = new Point(284, 92);
            btnEditSupplier.Margin = new Padding(3, 2, 3, 2);
            btnEditSupplier.Name = "btnEditSupplier";
            btnEditSupplier.Size = new Size(55, 28);
            btnEditSupplier.TabIndex = 23;
            btnEditSupplier.Text = "Edit";
            btnEditSupplier.UseVisualStyleBackColor = true;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(199, 92);
            btnAddSupplier.Margin = new Padding(3, 2, 3, 2);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(55, 28);
            btnAddSupplier.TabIndex = 21;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            // 
            // txtSupplierName
            // 
            txtSupplierName.Location = new Point(193, 58);
            txtSupplierName.Margin = new Padding(3, 2, 3, 2);
            txtSupplierName.Name = "txtSupplierName";
            txtSupplierName.Size = new Size(164, 23);
            txtSupplierName.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 61);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 4;
            label4.Text = "Supplier Name";
            // 
            // dataGVSupplier
            // 
            dataGVSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVSupplier.Location = new Point(3, 2);
            dataGVSupplier.Margin = new Padding(3, 2, 3, 2);
            dataGVSupplier.Name = "dataGVSupplier";
            dataGVSupplier.RowHeadersWidth = 51;
            dataGVSupplier.RowTemplate.Height = 29;
            dataGVSupplier.Size = new Size(733, 492);
            dataGVSupplier.TabIndex = 28;
            // 
            // SuppliersUserControls
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "SuppliersUserControls";
            Size = new Size(1112, 494);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVSupplier).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGVSupplier;
        private GroupBox groupBox2;
        private TextBox txtEditSupplierId;
        private Label label5;
        private Button btnEditSupplier;
        private Button btnAddSupplier;
        private TextBox txtSupplierName;
        private Label label4;
        private Label label3;
    }
}
