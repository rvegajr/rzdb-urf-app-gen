//------------------------------------------------------------------------------
// <auto-generated>
    //     This code was generated from a template.
    //
    //     Manual changes to this file may cause unexpected behavior in your application.
    //     Manual changes to this file will be overwritten if the code is regenerated.
    //
//  </auto-generated>
//------------------------------------------------------------------------------
using DataAccess.Models;
using Repository.Pattern.Repositories;
using Service.Pattern;


namespace Service
{
    /// <summary></summary>
    public interface ISupplierService : IService<Supplier>
    {
    }

    /// <summary></summary>
    public partial class SupplierService : Service<Supplier>, ISupplierService
    {
        /// <summary></summary>
        public SupplierService(IRepositoryAsync<Supplier> repository) : base(repository)
        {
        }
    }
}
