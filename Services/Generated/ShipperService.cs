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
    public interface IShipperService : IService<Shipper>
    {
    }

    public partial class ShipperService : Service<Shipper>, IShipperService
    {
        public ShipperService(IRepositoryAsync<Shipper> repository) : base(repository)
        {
        }
    }
}
