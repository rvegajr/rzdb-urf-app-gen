
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
    [Table("TransactionTypes", Schema = "Application")]
    public partial class TransactionType : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TransactionType()
        {
             this.SupplierTransactions_TransactionTypeID = new HashSet<SupplierTransaction>();
             this.CustomerTransactions_TransactionTypeID = new HashSet<CustomerTransaction>();
             this.StockItemTransactions_TransactionTypeID = new HashSet<StockItemTransaction>();
        }
        /// <summary></summary>
		
        [Key] public int TransactionTypeID { get; set; }
        /// <summary></summary>
		
        public string TransactionTypeName { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime ValidFrom { get; set; }
        /// <summary></summary>
		
        public DateTime ValidTo { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<SupplierTransaction> SupplierTransactions_TransactionTypeID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<CustomerTransaction> CustomerTransactions_TransactionTypeID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<StockItemTransaction> StockItemTransactions_TransactionTypeID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}
