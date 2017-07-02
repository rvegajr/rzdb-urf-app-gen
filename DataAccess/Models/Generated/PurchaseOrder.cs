
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
    [Table("PurchaseOrders")]
    public partial class PurchaseOrder : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PurchaseOrder()
        {
             this.PurchaseOrderLines_PurchaseOrderID = new HashSet<PurchaseOrderLine>();
             this.SupplierTransactions_PurchaseOrderID = new HashSet<SupplierTransaction>();
             this.StockItemTransactions_PurchaseOrderID = new HashSet<StockItemTransaction>();
        }
        /// <summary></summary>
		
        [Key] public int PurchaseOrderID { get; set; }
        /// <summary></summary>
		
        public int SupplierID { get; set; }
        /// <summary></summary>
		
        public DateTime OrderDate { get; set; }
        /// <summary></summary>
		
        public int DeliveryMethodID { get; set; }
        /// <summary></summary>
		
        public int ContactPersonID { get; set; }
        /// <summary></summary>
		
        public DateTime? ExpectedDeliveryDate { get; set; }
        /// <summary></summary>
		
        public string SupplierReference { get; set; }
        /// <summary></summary>
		
        public bool IsOrderFinalized { get; set; }
        /// <summary></summary>
		
        public string Comments { get; set; }
        /// <summary></summary>
		
        public string InternalComments { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime LastEditedWhen { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines_PurchaseOrderID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SupplierTransaction> SupplierTransactions_PurchaseOrderID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemTransaction> StockItemTransactions_PurchaseOrderID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("DeliveryMethodID")]

        public virtual DeliveryMethod DeliveryMethod { get; set; }
    /// <summary></summary>        
        [ForeignKey("SupplierID")]

        public virtual Supplier Supplier { get; set; }
    /// <summary></summary>
        [ForeignKey("LastEditedBy")]

        public virtual Person LastEditedByPerson { get; set; }
    /// <summary></summary>
        [ForeignKey("ContactPersonID")]

        public virtual Person ContactPerson { get; set; }

    }
}
