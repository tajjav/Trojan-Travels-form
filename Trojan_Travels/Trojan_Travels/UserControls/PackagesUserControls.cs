using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Trojan_Travels.Models;

namespace Trojan_Travels.UserControls
{
    public partial class PackagesUserControls : UserControl
    {
        private static PackagesUserControls _instance;
        public static PackagesUserControls Instance
        {
            get
            {
                if(_instance == null )
                    _instance = new PackagesUserControls(); 
                return _instance;
            }
        }
        private TravelExpertsContext dbContext;
        private BindingSource packageBindingSource = new BindingSource();
        private BindingSource ppsBindingSource = new BindingSource();
        private BindingSource psBindingSource = new BindingSource();
        private BindingSource supplierBindingSource = new BindingSource();
        private BindingSource productBindingSource = new BindingSource();

        public PackagesUserControls()
        {
            InitializeComponent();
            LoadData();
           
            //clearButton();
        }
        //private void LoadData()
        private async Task LoadData()
        {
            // retrieve data
            TravelExpertsContext dbContext = new TravelExpertsContext();
            var packages1 = dbContext.Packages.ToList();
            packageBindingSource.DataSource = packages1;
            //var packages = packages1;
            // packageBindingSource.DataSource = packages1;

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

        private TravelExpertsContext GetDbContext()
        {
            return dbContext;
        }


    }
}
