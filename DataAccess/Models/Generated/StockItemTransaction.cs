
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
    [Table("StockItemTransactions")]
    public partial class StockItemTransaction : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockItemTransaction()
        {
        }
        /// <summary></summary>
		
        [Key] public int StockItemTransactionID { get; set; }
        /// <summary></summary>
		
        public int StockItemID { get; set; }
        /// <summary></summary>
		
        public int TransactionTypeID { get; set; }
        /// <summary></summary>
		
        public int? CustomerID { get; set; }
        /// <summary></summary>
		
        public int? InvoiceID { get; set; }
        /// <summary></summary>
		
        public int? SupplierID { get; set; }
        /// <summary></summary>
		
        public int? PurchaseOrderID { get; set; }
        /// <summary></summary>
		
        public DateTime TransactionOccurredWhen { get; set; }
        /// <summary></summary>
		
        public decimal Quantity { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime LastEditedWhen { get; set; }
    /// <summary></summary>        
        [ForeignKey("TransactionTypeID")]

        public virtual TransactionType TransactionType { get; set; }
    /// <summary></summary>        
        [ForeignKey("PurchaseOrderID")]

        public virtual PurchaseOrder PurchaseOrder { get; set; }
    /// <summary></summary>        
        [ForeignKey("SupplierID")]

        public virtual Supplier Supplier { get; set; }
    /// <summary></summary>        
        [ForeignKey("CustomerID")]

        public virtual Customer Customer { get; set; }
    /// <summary></summary>        
        [ForeignKey("InvoiceID")]

        public virtual Invoice Invoice { get; set; }
    /// <summary></summary>        
        [ForeignKey("StockItemID")]

        public virtual StockItem StockItem { get; set; }
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}
