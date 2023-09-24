namespace Trojan_Travels
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            txtEditSupplierId = new TextBox();
            label5 = new Label();
            btnEditSupplier = new Button();
            btnAddSupplier = new Button();
            txtSupplierName = new TextBox();
            label4 = new Label();
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
            groupBox4 = new GroupBox();
            btnAddSupplierProduct = new Button();
            txtPSProductSupplierId = new TextBox();
            label3 = new Label();
            btnEditSupplierProduct = new Button();
            txtPSSupplierId = new TextBox();
            label9 = new Label();
            txtPSProductId = new TextBox();
            label10 = new Label();
            dataGVPackage = new DataGridView();
            dataGVPS = new DataGridView();
            dataGVSupplier = new DataGridView();
            dataGVProduct = new DataGridView();
            label14 = new Label();
            label15 = new Label();
            label17 = new Label();
            label18 = new Label();
            groupBox1 = new GroupBox();
            txtEditProductId = new TextBox();
            label19 = new Label();
            btnEditProduct = new Button();
            btnAddProduct = new Button();
            txtProductName = new TextBox();
            label11 = new Label();
            btnMgPackages = new Button();
            btnMgPS = new Button();
            btnMgSuppliers = new Button();
            btnManageProducts = new Button();
            pictureBox1 = new PictureBox();
            BtnPackagesUserControl = new Button();
            BtnProductsUserControl = new Button();
            BtnSupplierUserControl = new Button();
            panel = new Panel();
            packagesUserControls1 = new UserControls.PackagesUserControls();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPackage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVPS).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVSupplier).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGVProduct).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(txtEditSupplierId);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(btnEditSupplier);
            groupBox2.Controls.Add(btnAddSupplier);
            groupBox2.Controls.Add(txtSupplierName);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(1153, 805);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(387, 124);
            groupBox2.TabIndex = 1;
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
            btnEditSupplier.Size = new Size(55, 18);
            btnEditSupplier.TabIndex = 23;
            btnEditSupplier.Text = "Edit";
            btnEditSupplier.UseVisualStyleBackColor = true;
            btnEditSupplier.Click += btnEditSupplier_Click;
            // 
            // btnAddSupplier
            // 
            btnAddSupplier.Location = new Point(199, 92);
            btnAddSupplier.Margin = new Padding(3, 2, 3, 2);
            btnAddSupplier.Name = "btnAddSupplier";
            btnAddSupplier.Size = new Size(55, 18);
            btnAddSupplier.TabIndex = 21;
            btnAddSupplier.Text = "Add";
            btnAddSupplier.UseVisualStyleBackColor = true;
            btnAddSupplier.Click += btnAddSupplier_Click;
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
            groupBox3.Location = new Point(102, 614);
            groupBox3.Margin = new Padding(3, 2, 3, 2);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 2, 3, 2);
            groupBox3.Size = new Size(382, 294);
            groupBox3.TabIndex = 1;
            groupBox3.TabStop = false;
            groupBox3.Text = "Packages";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // txtProductSupplierId
            // 
            txtProductSupplierId.Location = new Point(194, 76);
            txtProductSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtProductSupplierId.Name = "txtProductSupplierId";
            txtProductSupplierId.ReadOnly = true;
            txtProductSupplierId.Size = new Size(164, 23);
            txtProductSupplierId.TabIndex = 22;
            // 
            // btnEditPackage
            // 
            btnEditPackage.Location = new Point(290, 260);
            btnEditPackage.Margin = new Padding(3, 2, 3, 2);
            btnEditPackage.Name = "btnEditPackage";
            btnEditPackage.Size = new Size(55, 18);
            btnEditPackage.TabIndex = 21;
            btnEditPackage.Text = "Edit";
            btnEditPackage.UseVisualStyleBackColor = true;
            btnEditPackage.Click += btnEditPackage_Click;
            // 
            // btnAddPackage
            // 
            btnAddPackage.Location = new Point(205, 260);
            btnAddPackage.Margin = new Padding(3, 2, 3, 2);
            btnAddPackage.Name = "btnAddPackage";
            btnAddPackage.Size = new Size(55, 18);
            btnAddPackage.TabIndex = 20;
            btnAddPackage.Text = "Add";
            btnAddPackage.UseVisualStyleBackColor = true;
            btnAddPackage.Click += btnAddPackage_Click;
            // 
            // dateTimePickerEndDate
            // 
            dateTimePickerEndDate.Location = new Point(196, 130);
            dateTimePickerEndDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            dateTimePickerEndDate.Size = new Size(162, 23);
            dateTimePickerEndDate.TabIndex = 19;
            // 
            // dateTimePickerStartDate
            // 
            dateTimePickerStartDate.Location = new Point(194, 105);
            dateTimePickerStartDate.Margin = new Padding(3, 2, 3, 2);
            dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            dateTimePickerStartDate.Size = new Size(162, 23);
            dateTimePickerStartDate.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 76);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 17;
            label1.Text = "PrpductSupplierId";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(11, 193);
            label12.Name = "label12";
            label12.Size = new Size(107, 15);
            label12.TabIndex = 15;
            label12.Text = "Package Base Price";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(11, 159);
            label13.Name = "label13";
            label13.Size = new Size(114, 15);
            label13.TabIndex = 14;
            label13.Text = "Package Description";
            // 
            // txtPackageCommission
            // 
            txtPackageCommission.Location = new Point(194, 223);
            txtPackageCommission.Margin = new Padding(3, 2, 3, 2);
            txtPackageCommission.Name = "txtPackageCommission";
            txtPackageCommission.Size = new Size(164, 23);
            txtPackageCommission.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(11, 225);
            label6.Name = "label6";
            label6.Size = new Size(164, 15);
            label6.TabIndex = 12;
            label6.Text = "Package Agency Commission";
            // 
            // txtPackageBasePrice
            // 
            txtPackageBasePrice.Location = new Point(196, 188);
            txtPackageBasePrice.Margin = new Padding(3, 2, 3, 2);
            txtPackageBasePrice.Name = "txtPackageBasePrice";
            txtPackageBasePrice.Size = new Size(164, 23);
            txtPackageBasePrice.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 134);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 10;
            label7.Text = "Package End Date";
            // 
            // txtPackageDescription
            // 
            txtPackageDescription.Location = new Point(196, 157);
            txtPackageDescription.Margin = new Padding(3, 2, 3, 2);
            txtPackageDescription.Name = "txtPackageDescription";
            txtPackageDescription.Size = new Size(164, 23);
            txtPackageDescription.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(11, 105);
            label8.Name = "label8";
            label8.Size = new Size(105, 15);
            label8.TabIndex = 8;
            label8.Text = "Package Start Date";
            // 
            // txtPackageName
            // 
            txtPackageName.Location = new Point(196, 41);
            txtPackageName.Margin = new Padding(3, 2, 3, 2);
            txtPackageName.Name = "txtPackageName";
            txtPackageName.Size = new Size(164, 23);
            txtPackageName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 41);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Package Name";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnAddSupplierProduct);
            groupBox4.Controls.Add(txtPSProductSupplierId);
            groupBox4.Controls.Add(label3);
            groupBox4.Controls.Add(btnEditSupplierProduct);
            groupBox4.Controls.Add(txtPSSupplierId);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(txtPSProductId);
            groupBox4.Controls.Add(label10);
            groupBox4.Location = new Point(728, 677);
            groupBox4.Margin = new Padding(3, 2, 3, 2);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(3, 2, 3, 2);
            groupBox4.Size = new Size(374, 194);
            groupBox4.TabIndex = 2;
            groupBox4.TabStop = false;
            groupBox4.Text = "Suppliers and Products";
            // 
            // btnAddSupplierProduct
            // 
            btnAddSupplierProduct.Location = new Point(205, 163);
            btnAddSupplierProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddSupplierProduct.Name = "btnAddSupplierProduct";
            btnAddSupplierProduct.Size = new Size(55, 18);
            btnAddSupplierProduct.TabIndex = 25;
            btnAddSupplierProduct.Text = "Add";
            btnAddSupplierProduct.UseVisualStyleBackColor = true;
            btnAddSupplierProduct.Click += btnAddSupplierProduct_Click;
            // 
            // txtPSProductSupplierId
            // 
            txtPSProductSupplierId.Location = new Point(194, 40);
            txtPSProductSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtPSProductSupplierId.Name = "txtPSProductSupplierId";
            txtPSProductSupplierId.ReadOnly = true;
            txtPSProductSupplierId.Size = new Size(164, 23);
            txtPSProductSupplierId.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 40);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 23;
            label3.Text = "PrpductSupplierId";
            // 
            // btnEditSupplierProduct
            // 
            btnEditSupplierProduct.Location = new Point(290, 163);
            btnEditSupplierProduct.Margin = new Padding(3, 2, 3, 2);
            btnEditSupplierProduct.Name = "btnEditSupplierProduct";
            btnEditSupplierProduct.Size = new Size(55, 18);
            btnEditSupplierProduct.TabIndex = 22;
            btnEditSupplierProduct.Text = "Edit";
            btnEditSupplierProduct.UseVisualStyleBackColor = true;
            btnEditSupplierProduct.Click += btnEditSupplierProduct_Click;
            // 
            // txtPSSupplierId
            // 
            txtPSSupplierId.Location = new Point(194, 87);
            txtPSSupplierId.Margin = new Padding(3, 2, 3, 2);
            txtPSSupplierId.Name = "txtPSSupplierId";
            txtPSSupplierId.ReadOnly = true;
            txtPSSupplierId.Size = new Size(164, 23);
            txtPSSupplierId.TabIndex = 7;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 87);
            label9.Name = "label9";
            label9.Size = new Size(60, 15);
            label9.TabIndex = 6;
            label9.Text = "SupplierId";
            // 
            // txtPSProductId
            // 
            txtPSProductId.Location = new Point(194, 130);
            txtPSProductId.Margin = new Padding(3, 2, 3, 2);
            txtPSProductId.Name = "txtPSProductId";
            txtPSProductId.ReadOnly = true;
            txtPSProductId.Size = new Size(164, 23);
            txtPSProductId.TabIndex = 5;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 130);
            label10.Name = "label10";
            label10.Size = new Size(59, 15);
            label10.TabIndex = 4;
            label10.Text = "ProductId";
            // 
            // dataGVPackage
            // 
            dataGVPackage.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVPackage.Location = new Point(16, 966);
            dataGVPackage.Margin = new Padding(3, 2, 3, 2);
            dataGVPackage.Name = "dataGVPackage";
            dataGVPackage.RowHeadersWidth = 51;
            dataGVPackage.RowTemplate.Height = 29;
            dataGVPackage.Size = new Size(734, 117);
            dataGVPackage.TabIndex = 24;
            // 
            // dataGVPS
            // 
            dataGVPS.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVPS.Location = new Point(768, 966);
            dataGVPS.Margin = new Padding(3, 2, 3, 2);
            dataGVPS.Name = "dataGVPS";
            dataGVPS.RowHeadersWidth = 51;
            dataGVPS.RowTemplate.Height = 29;
            dataGVPS.Size = new Size(317, 117);
            dataGVPS.TabIndex = 25;
            dataGVPS.CellContentClick += dataGVPS_CellContentClick;
            // 
            // dataGVSupplier
            // 
            dataGVSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVSupplier.Location = new Point(1214, 966);
            dataGVSupplier.Margin = new Padding(3, 2, 3, 2);
            dataGVSupplier.Name = "dataGVSupplier";
            dataGVSupplier.RowHeadersWidth = 51;
            dataGVSupplier.RowTemplate.Height = 29;
            dataGVSupplier.Size = new Size(311, 117);
            dataGVSupplier.TabIndex = 27;
            // 
            // dataGVProduct
            // 
            dataGVProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGVProduct.Location = new Point(1694, 966);
            dataGVProduct.Margin = new Padding(3, 2, 3, 2);
            dataGVProduct.Name = "dataGVProduct";
            dataGVProduct.RowHeadersWidth = 51;
            dataGVProduct.RowTemplate.Height = 29;
            dataGVProduct.Size = new Size(288, 116);
            dataGVProduct.TabIndex = 28;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(302, 922);
            label14.Name = "label14";
            label14.Size = new Size(51, 15);
            label14.TabIndex = 29;
            label14.Text = "Package";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(868, 932);
            label15.Name = "label15";
            label15.Size = new Size(97, 15);
            label15.TabIndex = 30;
            label15.Text = "Product_Supplier";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1355, 932);
            label17.Name = "label17";
            label17.Size = new Size(50, 15);
            label17.TabIndex = 32;
            label17.Text = "Supplier";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(1816, 932);
            label18.Name = "label18";
            label18.Size = new Size(49, 15);
            label18.TabIndex = 33;
            label18.Text = "Product";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtEditProductId);
            groupBox1.Controls.Add(label19);
            groupBox1.Controls.Add(btnEditProduct);
            groupBox1.Controls.Add(btnAddProduct);
            groupBox1.Controls.Add(txtProductName);
            groupBox1.Controls.Add(label11);
            groupBox1.Location = new Point(1607, 826);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(374, 104);
            groupBox1.TabIndex = 22;
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
            btnEditProduct.Size = new Size(55, 18);
            btnEditProduct.TabIndex = 24;
            btnEditProduct.Text = "Edit";
            btnEditProduct.UseVisualStyleBackColor = true;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(210, 74);
            btnAddProduct.Margin = new Padding(3, 2, 3, 2);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(55, 18);
            btnAddProduct.TabIndex = 21;
            btnAddProduct.Text = "Add";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
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
            // btnMgPackages
            // 
            btnMgPackages.Location = new Point(114, 912);
            btnMgPackages.Margin = new Padding(3, 2, 3, 2);
            btnMgPackages.Name = "btnMgPackages";
            btnMgPackages.Size = new Size(134, 38);
            btnMgPackages.TabIndex = 34;
            btnMgPackages.Text = "Manage Packages";
            btnMgPackages.UseVisualStyleBackColor = true;
            btnMgPackages.Click += btnMgPackages_Click;
            // 
            // btnMgPS
            // 
            btnMgPS.Location = new Point(845, 876);
            btnMgPS.Margin = new Padding(3, 2, 3, 2);
            btnMgPS.Name = "btnMgPS";
            btnMgPS.Size = new Size(145, 38);
            btnMgPS.TabIndex = 35;
            btnMgPS.Text = "Manage Products_Suppliers";
            btnMgPS.UseVisualStyleBackColor = true;
            btnMgPS.Click += btnMgPS_Click;
            // 
            // btnMgSuppliers
            // 
            btnMgSuppliers.Location = new Point(1197, 912);
            btnMgSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnMgSuppliers.Name = "btnMgSuppliers";
            btnMgSuppliers.Size = new Size(133, 38);
            btnMgSuppliers.TabIndex = 36;
            btnMgSuppliers.Text = "Manage Suppliers";
            btnMgSuppliers.UseVisualStyleBackColor = true;
            btnMgSuppliers.Click += btnMgSuppliers_Click;
            // 
            // btnManageProducts
            // 
            btnManageProducts.Location = new Point(1693, 926);
            btnManageProducts.Margin = new Padding(3, 2, 3, 2);
            btnManageProducts.Name = "btnManageProducts";
            btnManageProducts.Size = new Size(118, 36);
            btnManageProducts.TabIndex = 37;
            btnManageProducts.Text = "Manage Products";
            btnManageProducts.UseVisualStyleBackColor = true;
            btnManageProducts.Click += btnManageProducts_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.TravelExpertLogo;
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(238, 203);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // BtnPackagesUserControl
            // 
            BtnPackagesUserControl.Location = new Point(432, 126);
            BtnPackagesUserControl.Margin = new Padding(3, 2, 3, 2);
            BtnPackagesUserControl.Name = "BtnPackagesUserControl";
            BtnPackagesUserControl.Size = new Size(277, 51);
            BtnPackagesUserControl.TabIndex = 39;
            BtnPackagesUserControl.Text = "Packages";
            BtnPackagesUserControl.UseVisualStyleBackColor = true;
            BtnPackagesUserControl.Click += BtnPackagesUserControl_Click;
            // 
            // BtnProductsUserControl
            // 
            BtnProductsUserControl.Location = new Point(845, 126);
            BtnProductsUserControl.Margin = new Padding(3, 2, 3, 2);
            BtnProductsUserControl.Name = "BtnProductsUserControl";
            BtnProductsUserControl.Size = new Size(277, 51);
            BtnProductsUserControl.TabIndex = 40;
            BtnProductsUserControl.Text = "Products";
            BtnProductsUserControl.UseVisualStyleBackColor = true;
            // 
            // BtnSupplierUserControl
            // 
            BtnSupplierUserControl.Location = new Point(1274, 126);
            BtnSupplierUserControl.Margin = new Padding(3, 2, 3, 2);
            BtnSupplierUserControl.Name = "BtnSupplierUserControl";
            BtnSupplierUserControl.Size = new Size(277, 51);
            BtnSupplierUserControl.TabIndex = 41;
            BtnSupplierUserControl.Text = "Suppliers";
            BtnSupplierUserControl.UseVisualStyleBackColor = true;
            // 
            // panel
            // 
            panel.Controls.Add(packagesUserControls1);
            panel.Location = new Point(432, 185);
            panel.Margin = new Padding(3, 2, 3, 2);
            panel.Name = "panel";
            panel.Size = new Size(1119, 424);
            panel.TabIndex = 42;
            // 
            // packagesUserControls1
            // 
            packagesUserControls1.Location = new Point(3, 2);
            packagesUserControls1.Margin = new Padding(3, 2, 3, 2);
            packagesUserControls1.Name = "packagesUserControls1";
            packagesUserControls1.Size = new Size(1487, 648);
            packagesUserControls1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 791);
            Controls.Add(panel);
            Controls.Add(BtnSupplierUserControl);
            Controls.Add(BtnProductsUserControl);
            Controls.Add(BtnPackagesUserControl);
            Controls.Add(pictureBox1);
            Controls.Add(btnManageProducts);
            Controls.Add(btnMgSuppliers);
            Controls.Add(btnMgPS);
            Controls.Add(btnMgPackages);
            Controls.Add(groupBox1);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(dataGVProduct);
            Controls.Add(dataGVSupplier);
            Controls.Add(dataGVPS);
            Controls.Add(dataGVPackage);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Travel Experts";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGVPackage).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVPS).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVSupplier).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGVProduct).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox3;
        private Label label2;
        private GroupBox groupBox2;
        private TextBox txtPackageCommission;
        private Label label6;
        private TextBox txtPackageBasePrice;
        private Label label7;
        private TextBox txtPackageDescription;
        private Label label8;
        private TextBox txtPackageName;
        private TextBox txtSupplierName;
        private Label label4;
        private GroupBox groupBox4;
        private TextBox txtPSSupplierId;
        private Label label9;
        private TextBox txtPSProductId;
        private Label label10;
        private DateTimePicker dateTimePickerEndDate;
        private DateTimePicker dateTimePickerStartDate;
        private Label label1;
        private Label label12;
        private Label label13;
        private Button btnEditPackage;
        private Button btnAddPackage;
        private Button btnAddSupplier;
        private Button btnEditSupplierProduct;
        private DataGridView dataGVPackage;
        private TextBox txtProductSupplierId;
        private DataGridView dataGVPS;
        private DataGridView dataGVSupplier;
        private DataGridView dataGVProduct;
        private Label label14;
        private Label label15;
        private Label label17;
        private Label label18;
        private TextBox txtPSProductSupplierId;
        private Label label3;
        private Button btnEditSupplier;
        private Button btnAddSupplierProduct;
        private GroupBox groupBox1;
        private Button btnAddProduct;
        private TextBox txtProductName;
        private Label label11;
        private TextBox txtEditSupplierId;
        private Label label5;
        private TextBox txtEditProductId;
        private Label label19;
        private Button btnEditProduct;
        private Button btnMgPackages;
        private Button btnMgPS;
        private Button btnMgSuppliers;
        private Button btnManageProducts;
        private PictureBox pictureBox1;
        private Button BtnPackagesUserControl;
        private Button BtnProductsUserControl;
        private Button BtnSupplierUserControl;
        private Panel panel;
        private UserControls.PackagesUserControls packagesUserControls1;
    }
}