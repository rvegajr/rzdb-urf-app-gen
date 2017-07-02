
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
    [Table("DeliveryMethods")]
    public partial class DeliveryMethod : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DeliveryMethod()
        {
             this.PurchaseOrders_DeliveryMethodID = new HashSet<PurchaseOrder>();
             this.Suppliers_DeliveryMethodID = new HashSet<Supplier>();
             this.Customers_DeliveryMethodID = new HashSet<Customer>();
             this.Invoices_DeliveryMethodID = new HashSet<Invoice>();
        }
        /// <summary></summary>
		
        [Key] public int DeliveryMethodID { get; set; }
        /// <summary></summary>
		
        public string DeliveryMethodName { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime ValidFrom { get; set; }
        /// <summary></summary>
		
        public DateTime ValidTo { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<PurchaseOrder> PurchaseOrders_DeliveryMethodID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Supplier> Suppliers_DeliveryMethodID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Customer> Customers_DeliveryMethodID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<Invoice> Invoices_DeliveryMethodID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}