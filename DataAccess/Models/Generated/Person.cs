
using System;
using System.Collections.Generic;
using Repository.Pattern.Ef6;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;
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
    [Table("People")]
    public partial class Person : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Person()
        {
             this.Cities_LastEditedBy = new HashSet<City>();
             this.Countries_LastEditedBy = new HashSet<Country>();
             this.DeliveryMethods_LastEditedBy = new HashSet<DeliveryMethod>();
             this.PaymentMethods_LastEditedBy = new HashSet<PaymentMethod>();
             this.People_LastEditedBy = new HashSet<Person>();
             this.StateProvinces_LastEditedBy = new HashSet<StateProvince>();
             this.SystemParameters_LastEditedBy = new HashSet<SystemParameter>();
             this.TransactionTypes_LastEditedBy = new HashSet<TransactionType>();
             this.PurchaseOrderLines_LastEditedBy = new HashSet<PurchaseOrderLine>();
             this.PurchaseOrders_LastEditedBy = new HashSet<PurchaseOrder>();
             this.PurchaseOrders_ContactPersonID = new HashSet<PurchaseOrder>();
             this.SupplierCategories_LastEditedBy = new HashSet<SupplierCategory>();
             this.Suppliers_AlternateContactPersonID = new HashSet<Supplier>();
             this.Suppliers_LastEditedBy = new HashSet<Supplier>();
             this.Suppliers_PrimaryContactPersonID = new HashSet<Supplier>();
             this.SupplierTransactions_LastEditedBy = new HashSet<SupplierTransaction>();
             this.BuyingGroups_LastEditedBy = new HashSet<BuyingGroup>();
             this.CustomerCategories_LastEditedBy = new HashSet<CustomerCategory>();
             this.Customers_AlternateContactPersonID = new HashSet<Customer>();
             this.Customers_LastEditedBy = new HashSet<Customer>();
             this.Customers_PrimaryContactPersonID = new HashSet<Customer>();
             this.CustomerTransactions_LastEditedBy = new HashSet<CustomerTransaction>();
             this.InvoiceLines_LastEditedBy = new HashSet<InvoiceLine>();
             this.Invoices_AccountsPersonID = new HashSet<Invoice>();
             this.Invoices_LastEditedBy = new HashSet<Invoice>();
             this.Invoices_ContactPersonID = new HashSet<Invoice>();
             this.Invoices_PackedByPersonID = new HashSet<Invoice>();
             this.Invoices_SalespersonPersonID = new HashSet<Invoice>();
             this.OrderLines_LastEditedBy = new HashSet<OrderLine>();
             this.Orders_LastEditedBy = new HashSet<Order>();
             this.Orders_ContactPersonID = new HashSet<Order>();
             this.Orders_PickedByPersonID = new HashSet<Order>();
             this.Orders_SalespersonPersonID = new HashSet<Order>();
             this.SpecialDeals_LastEditedBy = new HashSet<SpecialDeal>();
             this.Colors_LastEditedBy = new HashSet<Color>();
             this.PackageTypes_LastEditedBy = new HashSet<PackageType>();
             this.StockGroups_LastEditedBy = new HashSet<StockGroup>();
             this.StockItemHoldings_LastEditedBy = new HashSet<StockItemHolding>();
             this.StockItems_LastEditedBy = new HashSet<StockItem>();
             this.StockItemStockGroups_LastEditedBy = new HashSet<StockItemStockGroup>();
             this.StockItemTransactions_LastEditedBy = new HashSet<StockItemTransaction>();
        }
        /// <summary></summary>
		
        [Key] public int PersonID { get; set; }
        /// <summary></summary>
		
        public string FullName { get; set; }
        /// <summary></summary>
		
        public string PreferredName { get; set; }
        /// <summary></summary>
		
        public string SearchName { get; set; }
        /// <summary></summary>
		
        public bool IsPermittedToLogon { get; set; }
        /// <summary></summary>
		
        public string LogonName { get; set; }
        /// <summary></summary>
		
        public bool IsExternalLogonProvider { get; set; }
        /// <summary></summary>
		
        public Byte[] HashedPassword { get; set; }
        /// <summary></summary>
		
        public bool IsSystemUser { get; set; }
        /// <summary></summary>
		
        public bool IsEmployee { get; set; }
        /// <summary></summary>
		
        public bool IsSalesperson { get; set; }
        /// <summary></summary>
		
        public string UserPreferences { get; set; }
        /// <summary></summary>
		
        public string PhoneNumber { get; set; }
        /// <summary></summary>
		
        public string FaxNumber { get; set; }
        /// <summary></summary>
		
        public string EmailAddress { get; set; }
        /// <summary></summary>
		
        public Byte[] Photo { get; set; }
        /// <summary></summary>
		
        public string CustomFields { get; set; }
        /// <summary></summary>
		
        public string OtherLanguages { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime ValidFrom { get; set; }
        /// <summary></summary>
		
        public DateTime ValidTo { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<City> Cities_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Country> Countries_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<DeliveryMethod> DeliveryMethods_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<PaymentMethod> PaymentMethods_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Person> People_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StateProvince> StateProvinces_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SystemParameter> SystemParameters_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<TransactionType> TransactionTypes_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("LastEditedBy")]
         public virtual ICollection<PurchaseOrder> PurchaseOrders_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("ContactPerson")]
         public virtual ICollection<PurchaseOrder> PurchaseOrders_ContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SupplierCategory> SupplierCategories_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("AlternateContactPerson")]
         public virtual ICollection<Supplier> Suppliers_AlternateContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("LastEditedBy")]
         public virtual ICollection<Supplier> Suppliers_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PrimaryContactPerson")]
         public virtual ICollection<Supplier> Suppliers_PrimaryContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SupplierTransaction> SupplierTransactions_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<BuyingGroup> BuyingGroups_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<CustomerCategory> CustomerCategories_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("AlternateContactPerson")]
         public virtual ICollection<Customer> Customers_AlternateContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("LastEditedBy")]
         public virtual ICollection<Customer> Customers_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PrimaryContactPerson")]
         public virtual ICollection<Customer> Customers_PrimaryContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<CustomerTransaction> CustomerTransactions_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<InvoiceLine> InvoiceLines_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("AccountsPerson")]
         public virtual ICollection<Invoice> Invoices_AccountsPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("LastEditedBy")]
         public virtual ICollection<Invoice> Invoices_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("ContactPerson")]
         public virtual ICollection<Invoice> Invoices_ContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PackedByPerson")]
         public virtual ICollection<Invoice> Invoices_PackedByPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("SalespersonPerson")]
         public virtual ICollection<Invoice> Invoices_SalespersonPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<OrderLine> OrderLines_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("LastEditedBy")]
         public virtual ICollection<Order> Orders_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("ContactPerson")]
         public virtual ICollection<Order> Orders_ContactPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PickedByPerson")]
         public virtual ICollection<Order> Orders_PickedByPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("SalespersonPerson")]
         public virtual ICollection<Order> Orders_SalespersonPersonID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SpecialDeal> SpecialDeals_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Color> Colors_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<PackageType> PackageTypes_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockGroup> StockGroups_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemHolding> StockItemHoldings_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItem> StockItems_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemStockGroup> StockItemStockGroups_LastEditedBy { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemTransaction> StockItemTransactions_LastEditedBy { get; set; }
            
    /// <summary></summary>
        [ForeignKey("LastEditedBy")]

        public virtual Person LastEditedByPerson { get; set; }

    }
}