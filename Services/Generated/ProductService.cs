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
    public interface IProductService : IService<Product>
    {
    }

    public partial class ProductService : Service<Product>, IProductService
    {
        public ProductService(IRepositoryAsync<Product> repository) : base(repository)
        {
        }
    }
}
