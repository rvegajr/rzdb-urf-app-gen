
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
    [Table("OrderLines", Schema = "Sales")]
    public partial class OrderLine : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public OrderLine()
        {
        }
        /// <summary></summary>
		
        [Key] public int OrderLineID { get; set; }
        /// <summary></summary>
		
        public int OrderID { get; set; }
        /// <summary></summary>
		
        public int StockItemID { get; set; }
        /// <summary></summary>
		
        public string Description { get; set; }
        /// <summary></summary>
		
        public int PackageTypeID { get; set; }
        /// <summary></summary>
		
        public int Quantity { get; set; }
        /// <summary></summary>
		
        public decimal? UnitPrice { get; set; }
        /// <summary></summary>
		
        public decimal TaxRate { get; set; }
        /// <summary></summary>
		
        public int PickedQuantity { get; set; }
        /// <summary></summary>
		
        public DateTime? PickingCompletedWhen { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime LastEditedWhen { get; set; }
    /// <summary></summary>        
        [ForeignKey("OrderID")]

        public virtual Order Order { get; set; }
    /// <summary></summary>        
        [ForeignKey("PackageTypeID")]

        public virtual PackageType PackageType { get; set; }
    /// <summary></summary>        
        [ForeignKey("StockItemID")]

        public virtual StockItem StockItem { get; set; }
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}
