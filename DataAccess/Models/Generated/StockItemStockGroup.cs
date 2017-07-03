
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
    [Table("StockItemStockGroups", Schema = "Warehouse")]
    public partial class StockItemStockGroup : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StockItemStockGroup()
        {
        }
        /// <summary></summary>
		
        [Key] public int StockItemStockGroupID { get; set; }
        /// <summary></summary>
		
        public int StockItemID { get; set; }
        /// <summary></summary>
		
        public int StockGroupID { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime LastEditedWhen { get; set; }
    /// <summary></summary>        
        [ForeignKey("StockGroupID")]

        public virtual StockGroup StockGroup { get; set; }
    /// <summary></summary>        
        [ForeignKey("StockItemID")]

        public virtual StockItem StockItem { get; set; }
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}
