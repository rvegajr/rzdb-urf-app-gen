
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
    [Table("Cities", Schema = "Application")]
    public partial class City : Entity
    {

        /// <summary></summary>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public City()
        {
             this.SystemParameters_DeliveryCityID = new HashSet<SystemParameter>();
             this.SystemParameters_PostalCityID = new HashSet<SystemParameter>();
             this.Suppliers_DeliveryCityID = new HashSet<Supplier>();
             this.Suppliers_PostalCityID = new HashSet<Supplier>();
             this.Customers_DeliveryCityID = new HashSet<Customer>();
             this.Customers_PostalCityID = new HashSet<Customer>();
        }
        /// <summary></summary>
		
        [Key] public int CityID { get; set; }
        /// <summary></summary>
		
        public string CityName { get; set; }
        /// <summary></summary>
		
        public int StateProvinceID { get; set; }
        /// <summary></summary>
		
        public DbGeography Location { get; set; }
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
         [InverseProperty("DeliveryCity")]
         public virtual ICollection<SystemParameter> SystemParameters_DeliveryCityID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PostalCity")]
         public virtual ICollection<SystemParameter> SystemParameters_PostalCityID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("DeliveryCity")]
         public virtual ICollection<Supplier> Suppliers_DeliveryCityID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PostalCity")]
         public virtual ICollection<Supplier> Suppliers_PostalCityID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("DeliveryCity")]
         public virtual ICollection<Customer> Customers_DeliveryCityID { get; set; }
            
        /// <summary></summary> 
         [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
         [InverseProperty("PostalCity")]
         public virtual ICollection<Customer> Customers_PostalCityID { get; set; }
            
    /// <summary></summary>        
        [ForeignKey("StateProvinceID")]

        public virtual StateProvince StateProvince { get; set; }
    /// <summary></summary>        
        [ForeignKey("LastEditedBy")]

        public virtual Person Person { get; set; }

    }
}
