
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
    [Table("StateProvinces")]
    public partial class StateProvince : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StateProvince()
        {
             this.Cities_StateProvinceID = new HashSet<City>();
        }
        /// <summary></summary>
		
        [Key] public int StateProvinceID { get; set; }
        /// <summary></summary>
		
        public string StateProvinceCode { get; set; }
        /// <summary></summary>
		
        public string StateProvinceName { get; set; }
        /// <summary></summary>
		
        public int CountryID { get; set; }
        /// <summary></summary>
		
        public string SalesTerritory { get; set; }
        /// <summary></summary>
		
        public DbGeography Border { get; set; }
        /// <summary></summary>
		
        public System.Int64? LatestRecordedPopulation { get; set; }
        /// <summary></summary>
		
        public int LastEditedBy { get; set; }
        /// <summary></summary>
		
        public DateTime ValidFrom { get; set; }
        /// <summary></summary>
		
        public DateTime ValidTo { get; set; }
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")] 
         public virtual ICollection<City> Cities_StateProvinceID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("CountryID")]

        public virtual Country Country { get; set; }
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}