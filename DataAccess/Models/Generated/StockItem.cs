
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
    [Table("StockItems")]
    public partial class StockItem : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockItem()
        {
             this.PurchaseOrderLines_StockItemID = new HashSet<PurchaseOrderLine>();
             this.InvoiceLines_StockItemID = new HashSet<InvoiceLine>();
             this.OrderLines_StockItemID = new HashSet<OrderLine>();
             this.SpecialDeals_StockItemID = new HashSet<SpecialDeal>();
             this.StockItemStockGroups_StockItemID = new HashSet<StockItemStockGroup>();
             this.StockItemTransactions_StockItemID = new HashSet<StockItemTransaction>();
        }
        /// <summary></summary>
		
        [Key] public int StockItemID { get; set; }
        /// <summary></summary>
		
        public string StockItemName { get; set; }
        /// <summary></summary>
		
        public int SupplierID { get; set; }
        /// <summary></summary>
		
        public int? ColorID { get; set; }
        /// <summary></summary>
		
        public int UnitPackageID { get; set; }
        /// <summary></summary>
		
        public int OuterPackageID { get; set; }
        /// <summary></summary>
		
        public string Brand { get; set; }
        /// <summary></summary>
		
        public string Size { get; set; }
        /// <summary></summary>
		
        public int LeadTimeDays { get; set; }
        /// <summary></summary>
		
        public int QuantityPerOuter { get; set; }
        /// <summary></summary>
		
        public bool IsChillerStock { get; set; }
        /// <summary></summary>
		
        public string Barcode { get; set; }
        /// <summary></summary>
		
        public decimal TaxRate { get; set; }
        /// <summary></summary>
		
        public decimal UnitPrice { get; set; }
        /// <summary></summary>
		
        public decimal? RecommendedRetailPrice { get; set; }
        /// <summary></summary>
		
        public decimal TypicalWeightPerUnit { get; set; }
        /// <summary></summary>
		
        public string MarketingComments { get; set; }
        /// <summary></summary>
		
        public string InternalComments { get; set; }
        /// <summary></summary>
		
        public Byte[] Photo { get; set; }
        /// <summary></summary>
		
        public string CustomFields { get; set; }
        /// <summary></summary>
		
        public string Tags { get; set; }
        /// <summary></summary>
		
        public string SearchDetails { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime ValidFrom { get; set; }
        /// <summary></summary>
		
        public DateTime ValidTo { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines_StockItemID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<InvoiceLine> InvoiceLines_StockItemID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<OrderLine> OrderLines_StockItemID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SpecialDeal> SpecialDeals_StockItemID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemStockGroup> StockItemStockGroups_StockItemID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemTransaction> StockItemTransactions_StockItemID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("SupplierID")]

        public virtual Supplier Supplier { get; set; }
    /// <summary></summary>        
        [ForeignKey("ColorID")]

        public virtual Color Color { get; set; }
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }
    /// <summary></summary>
        [ForeignKey("OuterPackageID")]

        public virtual PackageType OuterPackage { get; set; }
    /// <summary></summary>
        [ForeignKey("UnitPackageID")]

        public virtual PackageType UnitPackage { get; set; }

    }
}