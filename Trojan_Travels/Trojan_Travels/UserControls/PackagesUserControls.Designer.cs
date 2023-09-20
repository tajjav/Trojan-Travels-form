namespace Trojan_Travels.UserControls
{
    partial class PackagesUserControls
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
            components = new System.ComponentModel.Container();
            splitContainer1 = new SplitContainer();
            label3 = new Label();
            groupBox3 = new GroupBox();
            txtProductSupplierId = new TextBox();
            btnEditPackage = new Button();
            btnAddPackage = new Button();
            dateTimePickerEndDate = new DateTimePicker();
            dateTimePickerStartDate = new DateTimePicker();
            label1 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtPackageCommission = new TextBox();
            label6 = new Label();
            txtPackageBasePrice = new TextBox();
            label7 = new Label();
            txtPackageDescription = new TextBox();
            label8 = new Label();
            txtPackageName = new TextBox();
            label2 = new Label();
            dataGVPackage = new DataGridView();
            bindingSource1 = new BindingSource(components);
            bindingSource2 = new BindingSource(components);
            packageIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgStartDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgEndDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgDescDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgBasePriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            pkgAgencyCommissionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            bookingsDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            packagesProductsSuppliersDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPackage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3);
            splitContainer1.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dataGVPackage);
            splitContainer1.Size = new Size(1451, 701);
            splitContainer1.SplitterDistance = 483;
            splitContainer1.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(127, 27);
            label3.Name = "label3";
            label3.Size = new Size(214, 31);
            label3.TabIndex = 3;
            label3.Text = "Add a new Package";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtProductSupplierId);
            groupBox3.Controls.Add(btnEditPackage);
            groupBox3.Controls.Add(btnAddPackage);
            groupBox3.Controls.Add(dateTimePickerEndDate);
            groupBox3.Controls.Add(dateTimePickerStartDate);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(txtPackageCommission);
            groupBox3.Controls.Add(label6);
            groupBox3.Controls.Add(txtPackageBasePrice);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(txtPackageDescription);
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(txtPackageName);
            groupBox3.Controls.Add(label2);
            groupBox3.Location = new Point(20, 110);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(436, 392);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Packages";
            // 
            // txtProductSupplierId
            // 
            txtProductSupplierId.Location = new Point(222, 102);
            txtProductSupplierId.Name = "txtProductSupplierId";
            txtProductSupplierId.ReadOnly = true;
            txtProductSupplierId.Size = new Size(187, 27);
            txtProductSupplierId.TabIndex = 22;
            // 
            // btnEditPackage
            // 
            btnEditPackage.Location = new Point(332, 346);
            btnEditPackage.Name = "btnEditPackage";
            btnEditPackage.Size = new Size(63, 24);
            btnEditPackage.TabIndex = 21;
            btnEditPackage.Text = "Edit";
            btnEditPackage.UseVisualStyleBackColor = true;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Location = new Point(234, 346);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(63, 24);
            btnAddPackage.TabIndex = 20;
            btnAddPackage.Text = "Add";
            btnAddPackage.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(224, 173);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(185, 27);
            dateTimePickerEndDate.TabIndex = 19;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(222, 140);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(185, 27);
            dateTimePickerStartDate.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 101);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 17;
            label1.Text = "PrpductSupplierId";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(13, 257);
            label12.Name = "label12";
            label12.Size = new Size(134, 20);
            label12.TabIndex = 15;
            label12.Text = "Package Base Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(13, 212);
            label13.Name = "label13";
            label13.Size = new Size(143, 20);
            label13.TabIndex = 14;
            label13.Text = "Package Description";
            // 
            // txtPackageCommission
            // 
            txtPackageCommission.Location = new Point(222, 297);
            txtPackageCommission.Name = "txtPackageCommission";
            txtPackageCommission.Size = new Size(187, 27);
            txtPackageCommission.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 300);
            label6.Name = "label6";
            label6.Size = new Size(201, 20);
            label6.TabIndex = 12;
            label6.Text = "Package Agency Commission";
            // 
            // txtPackageBasePrice
            // 
            txtPackageBasePrice.Location = new Point(224, 250);
            txtPackageBasePrice.Name = "txtPackageBasePrice";
            txtPackageBasePrice.Size = new Size(187, 27);
            txtPackageBasePrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 178);
            label7.Name = "label7";
            label7.Size = new Size(128, 20);
            label7.TabIndex = 10;
            label7.Text = "Package End Date";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(224, 209);
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(187, 27);
            txtPackageDescription.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 140);
            label8.Name = "label8";
            label8.Size = new Size(134, 20);
            label8.TabIndex = 8;
            label8.Text = "Package Start Date";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(224, 55);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(187, 27);
            txtPackageName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 55);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 0;
            label2.Text = "Package Name";
            // 
            // dataGVPackage
            // 
            dataGVPackage.AutoGenerateColumns = false;
            dataGVPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVPackage.Columns.AddRange(new DataGridViewColumn[] { packageIdDataGridViewTextBoxColumn, pkgNameDataGridViewTextBoxColumn, pkgStartDateDataGridViewTextBoxColumn, pkgEndDateDataGridViewTextBoxColumn, pkgDescDataGridViewTextBoxColumn, pkgBasePriceDataGridViewTextBoxColumn, pkgAgencyCommissionDataGridViewTextBoxColumn, bookingsDataGridViewTextBoxColumn, packagesProductsSuppliersDataGridViewTextBoxColumn });
            dataGVPackage.DataBindings.Add(new Binding("DataContext", bindingSource2, "PackageId", true));
            dataGVPackage.DataSource = bindingSource1;
            dataGVPackage.Location = new Point(0, 3);
            dataGVPackage.Name = "dataGVPackage";
            dataGVPackage.RowHeadersWidth = 51;
            dataGVPackage.RowTemplate.Height = 29;
            dataGVPackage.Size = new Size(961, 698);
            dataGVPackage.TabIndex = 25;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Models.Package);
            // 
            // bindingSource2
            // 
            bindingSource2.DataSource = typeof(Models.Package);
            // 
            // packageIdDataGridViewTextBoxColumn
            // 
            packageIdDataGridViewTextBoxColumn.DataPropertyName = "PackageId";
            packageIdDataGridViewTextBoxColumn.HeaderText = "PackageId";
            packageIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            packageIdDataGridViewTextBoxColumn.Name = "packageIdDataGridViewTextBoxColumn";
            packageIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgNameDataGridViewTextBoxColumn
            // 
            pkgNameDataGridViewTextBoxColumn.DataPropertyName = "PkgName";
            pkgNameDataGridViewTextBoxColumn.HeaderText = "PkgName";
            pkgNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            pkgNameDataGridViewTextBoxColumn.Name = "pkgNameDataGridViewTextBoxColumn";
            pkgNameDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgStartDateDataGridViewTextBoxColumn
            // 
            pkgStartDateDataGridViewTextBoxColumn.DataPropertyName = "PkgStartDate";
            pkgStartDateDataGridViewTextBoxColumn.HeaderText = "PkgStartDate";
            pkgStartDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            pkgStartDateDataGridViewTextBoxColumn.Name = "pkgStartDateDataGridViewTextBoxColumn";
            pkgStartDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgEndDateDataGridViewTextBoxColumn
            // 
            pkgEndDateDataGridViewTextBoxColumn.DataPropertyName = "PkgEndDate";
            pkgEndDateDataGridViewTextBoxColumn.HeaderText = "PkgEndDate";
            pkgEndDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            pkgEndDateDataGridViewTextBoxColumn.Name = "pkgEndDateDataGridViewTextBoxColumn";
            pkgEndDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgDescDataGridViewTextBoxColumn
            // 
            pkgDescDataGridViewTextBoxColumn.DataPropertyName = "PkgDesc";
            pkgDescDataGridViewTextBoxColumn.HeaderText = "PkgDesc";
            pkgDescDataGridViewTextBoxColumn.MinimumWidth = 6;
            pkgDescDataGridViewTextBoxColumn.Name = "pkgDescDataGridViewTextBoxColumn";
            pkgDescDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgBasePriceDataGridViewTextBoxColumn
            // 
            pkgBasePriceDataGridViewTextBoxColumn.DataPropertyName = "PkgBasePrice";
            pkgBasePriceDataGridViewTextBoxColumn.HeaderText = "PkgBasePrice";
            pkgBasePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            pkgBasePriceDataGridViewTextBoxColumn.Name = "pkgBasePriceDataGridViewTextBoxColumn";
            pkgBasePriceDataGridViewTextBoxColumn.Width = 125;
            // 
            // pkgAgencyCommissionDataGridViewTextBoxColumn
            // 
            pkgAgencyCommissionDataGridViewTextBoxColumn.DataPropertyName = "PkgAgencyCommission";
            pkgAgencyCommissionDataGridViewTextBoxColumn.HeaderText = "PkgAgencyCommission";
            pkgAgencyCommissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            pkgAgencyCommissionDataGridViewTextBoxColumn.Name = "pkgAgencyCommissionDataGridViewTextBoxColumn";
            pkgAgencyCommissionDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookingsDataGridViewTextBoxColumn
            // 
            bookingsDataGridViewTextBoxColumn.DataPropertyName = "Bookings";
            bookingsDataGridViewTextBoxColumn.HeaderText = "Bookings";
            bookingsDataGridViewTextBoxColumn.MinimumWidth = 6;
            bookingsDataGridViewTextBoxColumn.Name = "bookingsDataGridViewTextBoxColumn";
            bookingsDataGridViewTextBoxColumn.Width = 125;
            // 
            // packagesProductsSuppliersDataGridViewTextBoxColumn
            // 
            packagesProductsSuppliersDataGridViewTextBoxColumn.DataPropertyName = "PackagesProductsSuppliers";
            packagesProductsSuppliersDataGridViewTextBoxColumn.HeaderText = "PackagesProductsSuppliers";
            packagesProductsSuppliersDataGridViewTextBoxColumn.MinimumWidth = 6;
            packagesProductsSuppliersDataGridViewTextBoxColumn.Name = "packagesProductsSuppliersDataGridViewTextBoxColumn";
            packagesProductsSuppliersDataGridViewTextBoxColumn.Width = 125;
            // 
            // PackagesUserControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "PackagesUserControls";
            Size = new Size(1451, 701);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPackage).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private DataGridView dataGVPackage;
        private GroupBox groupBox3;
        private TextBox txtProductSupplierId;
        private Button btnEditPackage;
        private Button btnAddPackage;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private Label label1;
        private Label label12;
        private Label label13;
        private TextBox txtPackageCommission;
        private Label label6;
        private TextBox txtPackageBasePrice;
        private Label label7;
        private TextBox txtPackageDescription;
        private Label label8;
        private TextBox txtPackageName;
        private Label label2;
        private Label label3;
        private DataGridViewTextBoxColumn packageIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgStartDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgEndDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgDescDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgBasePriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn pkgAgencyCommissionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn bookingsDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn packagesProductsSuppliersDataGridViewTextBoxColumn;
        private BindingSource bindingSource2;
        private BindingSource bindingSource1;
    }
}
