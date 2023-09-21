using System.Windows.Forms;
using Trojan_Travels.Models;
using Trojan_Travels.UserControls;

namespace Trojan_Travels
{
    public partial class Form1 : Form
    {

        private TravelExpertsContext dbContext;
        private BindingSource packageBindingSource = new BindingSource();
        private BindingSource ppsBindingSource = new BindingSource();
        private BindingSource psBindingSource = new BindingSource();
        private BindingSource supplierBindingSource = new BindingSource();
        private BindingSource productBindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            dbContext = new TravelExpertsContext();

            dataGVPackage.DataSource = packageBindingSource;
            dataGVPS.DataSource = ppsBindingSource;
            dataGVPS.DataSource = psBindingSource;
            dataGVProduct.DataSource = productBindingSource;
            dataGVSupplier.DataSource = supplierBindingSource;

            LoadData();
            clearButton();
        }

        private void LoadData()
        {
            // retrieve data
            var packages = dbContext.Packages.ToList();
            packageBindingSource.DataSource = packages;

            var packageProductsSuppliers = dbContext.PackagesProductsSuppliers.ToList();
            ppsBindingSource.DataSource = packageProductsSuppliers;


            // Retrieve data for PackagesProductsSupplier
            var productsSuppliers = dbContext.ProductsSuppliers.ToList();
            psBindingSource.DataSource = productsSuppliers;

            // Retrieve data for PackagesProductsSupplier
            var products = dbContext.Products.ToList();
            productBindingSource.DataSource = products;

            // Retrieve data for PackagesProductsSupplier
            var suppliers = dbContext.Suppliers.ToList();
            supplierBindingSource.DataSource = suppliers;
        }

        private void btnAddPackage_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new package.
                Package newPackage = new Package
                {
                    PkgName = txtPackageName.Text,
                    PkgStartDate = dateTimePickerStartDate.Value,
                    PkgEndDate = dateTimePickerEndDate.Value,
                    PkgDesc = txtPackageDescription.Text,
                    PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text),
                    PkgAgencyCommission = Convert.ToDecimal(txtPackageCommission.Text)
                };


                dbContext.Packages.Add(newPackage);

                // Save changes to the database
                dbContext.SaveChanges();


                // Create a new package product supplier.
                if (!string.IsNullOrEmpty(txtProductSupplierId.Text))
                {
                    int productSupplierId = Convert.ToInt32(txtProductSupplierId.Text);
                    PackagesProductsSupplier newPackageProductsSupplier = new PackagesProductsSupplier
                    {
                        PackageId = newPackage.PackageId,
                        ProductSupplierId = productSupplierId,
                    };

                    dbContext.PackagesProductsSuppliers.Add(newPackageProductsSupplier);
                    dbContext.SaveChanges();
                }

                LoadData();
                //clearPackageEntry();

                MessageBox.Show("Package added successfully!");

                clearPackageEntry();
            }
            catch (Exception ex)
            {
                // Handle exceptions
                MessageBox.Show("An error occurred while adding the package: " + ex.Message);

                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                }
            }

        }


        private void btnEditPackage_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected package from the DataGridView
                if (dataGVPackage.SelectedRows.Count > 0)
                {

                    //int lnc = dataGridViewPackages.SelectedRows[0].Index;
                    int packageId = Convert.ToInt32(dataGVPackage.SelectedRows[0].Cells[0].Value);
                    Package selectedPackage = dbContext.Packages.Find(packageId);

                    // Update the selected package with the edited values
                    selectedPackage.PkgName = txtPackageName.Text;
                    selectedPackage.PkgStartDate = dateTimePickerStartDate.Value;
                    selectedPackage.PkgEndDate = dateTimePickerEndDate.Value;
                    selectedPackage.PkgDesc = txtPackageDescription.Text;
                    selectedPackage.PkgBasePrice = Convert.ToDecimal(txtPackageBasePrice.Text);
                    selectedPackage.PkgAgencyCommission = Convert.ToDecimal(txtPackageCommission.Text);

                    // Save changes to the database
                    dbContext.SaveChanges();

                    // Create a new package product supplier.
                    if (!string.IsNullOrEmpty(txtProductSupplierId.Text))
                    {
                        int productSupplierId = Convert.ToInt32(txtProductSupplierId.Text);

                        // Check if the combination of PackageId and ProductSupplierId already exists
                        bool exists = dbContext.PackagesProductsSuppliers
                            .Any(pps => pps.PackageId == packageId && pps.ProductSupplierId == productSupplierId);

                        if (!exists)
                        {
                            // If the combination doesn't exist, create a new entry
                            PackagesProductsSupplier newPackageProductsSupplier = new PackagesProductsSupplier
                            {
                                PackageId = packageId,
                                ProductSupplierId = productSupplierId,
                            };

                            dbContext.PackagesProductsSuppliers.Add(newPackageProductsSupplier);
                            dbContext.SaveChanges();
                        }
                        else
                        {
                            // Handle the case where the combination already exists
                            MessageBox.Show("The combination of PackageId and ProductSupplierId already exists.");
                        }
                    }

                    LoadData();
                    //clearPackageEntry();

                    MessageBox.Show("Package edited successfully!");
                }
                else
                {
                    MessageBox.Show("Please select a package to edit.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                MessageBox.Show("An error occurred while editing the package: " + ex.Message);

                if (ex.InnerException != null)
                {
                    MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                }
            }

        }

        private void dataGVPS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked cell is in the "ProductSupplierId" column
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                try
                {
                    // Get the selected ProductSupplierId from the clicked cell
                    int productSupplierId = Convert.ToInt32(dataGVPS.Rows[e.RowIndex].Cells["ProductSupplierId"].Value);

                    // Display debugging messages
                    MessageBox.Show("Cell clicked. ProductSupplierId: " + productSupplierId);

                    // Set the value of txtProductSupplierId TextBox
                    txtProductSupplierId.Text = productSupplierId.ToString();
                }
                catch (Exception ex)
                {
                    // Handle exceptions
                    MessageBox.Show("An error occurred: " + ex.Message);

                    if (ex.InnerException != null)
                    {
                        MessageBox.Show("Inner Exception: " + ex.InnerException.Message);
                    }
                }
            }

        }



        private void btnAddSupplierProduct_Click(object sender, EventArgs e)
        {
            int supplierId = -1; // Initialize with an invalid value
            int productId = -1;  // Initialize with an invalid value

            if (dataGVSupplier.SelectedRows.Count > 0)
            {
                supplierId = Convert.ToInt32(dataGVSupplier.SelectedRows[0].Cells[0].Value);
            }

            if (dataGVProduct.SelectedRows.Count > 0)
            {
                productId = Convert.ToInt32(dataGVProduct.SelectedRows[0].Cells[0].Value);
            }

            if (supplierId != -1 && productId != -1)
            {
                ProductsSupplier newProductsSupplier = new ProductsSupplier
                {
                    ProductId = productId,
                    SupplierId = supplierId
                };

                dbContext.ProductsSuppliers.Add(newProductsSupplier);

                // Save changes to the database
                dbContext.SaveChanges();

                LoadData();

                MessageBox.Show("Product-Supplier relationship added successfully!");
            }
            else
            {
                MessageBox.Show("Please select both a product and a supplier to create the relationship.");
            }

        }

        private void btnEditSupplierProduct_Click(object sender, EventArgs e)
        {
            if (dataGVPS.SelectedRows.Count > 0)
            {
                int productSupplierId = Convert.ToInt32(dataGVPS.SelectedRows[0].Cells[0].Value);
                ProductsSupplier selectedProductsSupplier = dbContext.ProductsSuppliers.Find(productSupplierId);

                txtPSProductSupplierId.Text = Convert.ToString(productSupplierId);

                if (selectedProductsSupplier != null)
                {
                    int supplierId = -1; // Initialize with an invalid value
                    int productId = -1;  // Initialize with an invalid value

                    if (dataGVSupplier.SelectedRows.Count > 0)
                    {
                        supplierId = Convert.ToInt32(dataGVSupplier.SelectedRows[0].Cells[0].Value);
                    }

                    if (dataGVProduct.SelectedRows.Count > 0)
                    {
                        productId = Convert.ToInt32(dataGVProduct.SelectedRows[0].Cells[0].Value);
                    }

                    if (supplierId != -1 && productId != -1)
                    {
                        // Update the selected ProductsSupplier with the edited values
                        selectedProductsSupplier.ProductId = productId;
                        selectedProductsSupplier.SupplierId = supplierId;

                        txtPSSupplierId.Text = Convert.ToString(supplierId);
                        txtPSProductId.Text = Convert.ToString(productId);

                        // Save changes to the database
                        dbContext.SaveChanges();

                        LoadData();

                        MessageBox.Show("Product_Supplier edited successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Please select both a product and a supplier to update the Product_Supplier.");
                    }
                }
                else
                {
                    MessageBox.Show("Unable to find the selected Product_Supplier.");
                }

                clearProductSupplierEntry();
            }
            else
            {
                MessageBox.Show("Please select a Product_Supplier row to edit.");
            }
        }

        private void btnAddSupplier_Click(object sender, EventArgs e)
        {
            Supplier newSupplier = new Supplier
            {
                SupName = txtSupplierName.Text,
            };

            dbContext.Suppliers.Add(newSupplier);

            // Save changes to the database
            dbContext.SaveChanges();

            LoadData();

        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            if (dataGVSupplier.SelectedRows.Count > 0)
            {
                int supplierId = Convert.ToInt32(dataGVSupplier.SelectedRows[0].Cells[0].Value);
                Supplier selectedSupplier = dbContext.Suppliers.Find(supplierId);

                // Update the selected package with the edited values
                selectedSupplier.SupName = txtSupplierName.Text;
                txtEditSupplierId.Text = supplierId.ToString();

                // Save changes to the database
                dbContext.SaveChanges();

                LoadData();
                //clearPackageEntry();

                MessageBox.Show("Supplier edited successfully!");

                clearSupplierEntry();
            }
            else
            {
                MessageBox.Show("Please select a supplier to edit.");
            }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            Product newProduct = new Product
            {
                ProdName = txtProductName.Text,
            };

            dbContext.Products.Add(newProduct);

            // Save changes to the database
            dbContext.SaveChanges();

            LoadData();
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGVProduct.SelectedRows.Count > 0)
            {
                int productId = Convert.ToInt32(dataGVProduct.SelectedRows[0].Cells[0].Value);
                Product selectedProduct = dbContext.Products.Find(productId);

                // Update the selected package with the edited values
                selectedProduct.ProdName = txtProductName.Text;
                txtEditProductId.Text = productId.ToString();

                // Save changes to the database
                dbContext.SaveChanges();

                LoadData();
                //clearPackageEntry();

                MessageBox.Show("Product edited successfully!");

                clearProductEntry();
            }
            else
            {
                MessageBox.Show("Please select a product to edit.");
            }

        }

        public void clearPackageEntry()
        {
            txtPackageName.Text = "";
            txtProductSupplierId.Text = "";
            dateTimePickerStartDate.Value = DateTime.Now;
            dateTimePickerEndDate.Value = DateTime.Now;
            txtPackageBasePrice.Text = "";
            txtPackageCommission.Text = "";
            txtPackageName.Focus();
        }

        public void clearSupplierEntry()
        {
            txtSupplierName.Text = "";
            txtEditSupplierId.Text = "";

            txtSupplierName.Focus();
        }

        public void clearProductEntry()
        {
            txtProductName.Text = "";
            txtEditProductId.Text = "";

            txtProductName.Focus();
        }

        public void clearProductSupplierEntry()
        {
            txtPSProductSupplierId.Text = "";
            txtPSSupplierId.Text = "";
            txtPSProductId.Text = "";
        }

        private void clearButton()
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;
        }

        private void btnMgPackages_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = true;
            btnAddPackage.Enabled = true;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;
        }

        private void btnMgPS_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = true;
            btnEditSupplierProduct.Enabled = true;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;

        }

        private void btnMgSuppliers_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = true;
            btnAddSupplier.Enabled = true;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnAddProduct.Enabled = false;

        }

        private void btnManageProducts_Click(object sender, EventArgs e)
        {
            btnEditSupplier.Enabled = false;
            btnAddSupplier.Enabled = false;
            btnEditPackage.Enabled = false;
            btnAddPackage.Enabled = false;
            btnAddSupplierProduct.Enabled = false;
            btnEditSupplierProduct.Enabled = false;
            btnEditProduct.Enabled = true;
            btnAddProduct.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnPackagesUserControl_Click(object sender, EventArgs e)
        {
            //if (!Control.ControlCollection.Contains(PackagesUserControls.Instance))
            //{
            //    Panel.ControlCollection.Add(PackagesUserControls.Instance);
            //    PackagesUserControls.Instance.Dock = DockStyle.Fill;
            //    PackagesUserControls.Instance.BringToFront();
            //}
            //else
            //    PackagesUserControls.Instance.BringToFront();
        }
    }
}