
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
    [Table("Customers", Schema = "Sales")]
    public partial class Customer : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
             this.CustomerTransactions_CustomerID = new HashSet<CustomerTransaction>();
             this.Invoices_CustomerID = new HashSet<Invoice>();
             this.Orders_CustomerID = new HashSet<Order>();
             this.SpecialDeals_CustomerID = new HashSet<SpecialDeal>();
             this.StockItemTransactions_CustomerID = new HashSet<StockItemTransaction>();
             this.Customers_BillToCustomerID = new HashSet<Customer>();
             this.Invoices_BillToCustomerID = new HashSet<Invoice>();
        }
        /// <summary></summary>
		
        [Key] public int CustomerID { get; set; }
        /// <summary></summary>
		
        public string CustomerName { get; set; }
        /// <summary></summary>
		
        public int BillToCustomerID { get; set; }
        /// <summary></summary>
		
        public int CustomerCategoryID { get; set; }
        /// <summary></summary>
		
        public int? BuyingGroupID { get; set; }
        /// <summary></summary>
		
        public int PrimaryContactPersonID { get; set; }
        /// <summary></summary>
		
        public int? AlternateContactPersonID { get; set; }
        /// <summary></summary>
		
        public int DeliveryMethodID { get; set; }
        /// <summary></summary>
		
        public int DeliveryCityID { get; set; }
        /// <summary></summary>
		
        public int PostalCityID { get; set; }
        /// <summary></summary>
		
        public decimal? CreditLimit { get; set; }
        /// <summary></summary>
		
        public DateTime AccountOpenedDate { get; set; }
        /// <summary></summary>
		
        public decimal StandardDiscountPercentage { get; set; }
        /// <summary></summary>
		
        public bool IsStatementSent { get; set; }
        /// <summary></summary>
		
        public bool IsOnCreditHold { get; set; }
        /// <summary></summary>
		
        public int PaymentDays { get; set; }
        /// <summary></summary>
		
        public string PhoneNumber { get; set; }
        /// <summary></summary>
		
        public string FaxNumber { get; set; }
        /// <summary></summary>
		
        public string DeliveryRun { get; set; }
        /// <summary></summary>
		
        public string RunPosition { get; set; }
        /// <summary></summary>
		
        public string WebsiteURL { get; set; }
        /// <summary></summary>
		
        public string DeliveryAddressLine1 { get; set; }
        /// <summary></summary>
		
        public string DeliveryAddressLine2 { get; set; }
        /// <summary></summary>
		
        public string DeliveryPostalCode { get; set; }
        /// <summary></summary>
		
        public DbGeography DeliveryLocation { get; set; }
        /// <summary></summary>
		
        public string PostalAddressLine1 { get; set; }
        /// <summary></summary>
		
        public string PostalAddressLine2 { get; set; }
        /// <summary></summary>
		
        public string PostalPostalCode { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime ValidFrom { get; set; }
        /// <summary></summary>
		
        public DateTime ValidTo { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<CustomerTransaction> CustomerTransactions_CustomerID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("Customer")]
         public virtual ICollection<Invoice> Invoices_CustomerID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Order> Orders_CustomerID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SpecialDeal> SpecialDeals_CustomerID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemTransaction> StockItemTransactions_CustomerID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Customer> Customers_BillToCustomerID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("BillToCustomer")]
         public virtual ICollection<Invoice> Invoices_BillToCustomerID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("DeliveryMethodID")]

        public virtual DeliveryMethod DeliveryMethod { get; set; }
    /// <summary></summary>        
        [ForeignKey("BuyingGroupID")]

        public virtual BuyingGroup BuyingGroup { get; set; }
    /// <summary></summary>        
        [ForeignKey("CustomerCategoryID")]

        public virtual CustomerCategory CustomerCategory { get; set; }
    /// <summary></summary>
        [ForeignKey("DeliveryCityID")]

        public virtual City DeliveryCity { get; set; }
    /// <summary></summary>
        [ForeignKey("PostalCityID")]

        public virtual City PostalCity { get; set; }
    /// <summary></summary>
        [ForeignKey("AlternateContactPersonID")]

        public virtual Person AlternateContactPerson { get; set; }
    /// <summary></summary>
        [ForeignKey("LastEditedBy")]

        public virtual Person LastEditedByPerson { get; set; }
    /// <summary></summary>
        [ForeignKey("PrimaryContactPersonID")]

        public virtual Person PrimaryContactPerson { get; set; }
    /// <summary></summary>
        [ForeignKey("BillToCustomerID")]

        public virtual Customer BillToCustomer { get; set; }

    }
}
