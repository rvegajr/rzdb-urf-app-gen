using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using Repository.Pattern.Ef6;
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace DataAccess.Models
{
    /// <summary></summary>
    public partial class WideWorldImportersEntities : DataContext
    {
        /// <summary></summary>
        public WideWorldImportersEntities() : base("name=WideWorldImportersEntities"){
            //Disable initializer
            Database.SetInitializer<WideWorldImportersEntities>(null);
        }

        /// <summary></summary>
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        /// <summary></summary>
        public virtual DbSet<City> Cities { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Country> Countries { get; set; } 
        /// <summary></summary>
        public virtual DbSet<DeliveryMethod> DeliveryMethods { get; set; } 
        /// <summary></summary>
        public virtual DbSet<PaymentMethod> PaymentMethods { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Person> People { get; set; } 
        /// <summary></summary>
        public virtual DbSet<StateProvince> StateProvinces { get; set; } 
        /// <summary></summary>
        public virtual DbSet<SystemParameter> SystemParameters { get; set; } 
        /// <summary></summary>
        public virtual DbSet<TransactionType> TransactionTypes { get; set; } 
        /// <summary></summary>
        public virtual DbSet<PurchaseOrderLine> PurchaseOrderLines { get; set; } 
        /// <summary></summary>
        public virtual DbSet<PurchaseOrder> PurchaseOrders { get; set; } 
        /// <summary></summary>
        public virtual DbSet<SupplierCategory> SupplierCategories { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Supplier> Suppliers { get; set; } 
        /// <summary></summary>
        public virtual DbSet<SupplierTransaction> SupplierTransactions { get; set; } 
        /// <summary></summary>
        public virtual DbSet<BuyingGroup> BuyingGroups { get; set; } 
        /// <summary></summary>
        public virtual DbSet<CustomerCategory> CustomerCategories { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Customer> Customers { get; set; } 
        /// <summary></summary>
        public virtual DbSet<CustomerTransaction> CustomerTransactions { get; set; } 
        /// <summary></summary>
        public virtual DbSet<InvoiceLine> InvoiceLines { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Invoice> Invoices { get; set; } 
        /// <summary></summary>
        public virtual DbSet<OrderLine> OrderLines { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Order> Orders { get; set; } 
        /// <summary></summary>
        public virtual DbSet<SpecialDeal> SpecialDeals { get; set; } 
        /// <summary></summary>
        public virtual DbSet<ColdRoomTemperature> ColdRoomTemperatures { get; set; } 
        /// <summary></summary>
        public virtual DbSet<Color> Colors { get; set; } 
        /// <summary></summary>
        public virtual DbSet<PackageType> PackageTypes { get; set; } 
        /// <summary></summary>
        public virtual DbSet<StockGroup> StockGroups { get; set; } 
        /// <summary></summary>
        public virtual DbSet<StockItemHolding> StockItemHoldings { get; set; } 
        /// <summary></summary>
        public virtual DbSet<StockItem> StockItems { get; set; } 
        /// <summary></summary>
        public virtual DbSet<StockItemStockGroup> StockItemStockGroups { get; set; } 
        /// <summary></summary>
        public virtual DbSet<StockItemTransaction> StockItemTransactions { get; set; } 
        /// <summary></summary>
        public virtual DbSet<VehicleTemperature> VehicleTemperatures { get; set; }     }
}

