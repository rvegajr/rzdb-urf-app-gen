
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.Linq;
using System.Web.OData;
using System.Web.OData.Query;
using System.Web.OData.Routing;
using Repository.Pattern.UnitOfWork;
using System.Web.Http;
using System.Threading.Tasks;
using System.Net;
using Repository.Pattern.Infrastructure;
using System.Data.Entity.Infrastructure;
using DataAccess.Models;
using Service;
using System;

namespace WebApi.Controllers
{
        /// <summary></summary>
        [ODataRoutePrefix("SpecialDeals")]
        public partial class SpecialDealsController : ODataController
        {
            private readonly ISpecialDealService _service;
            private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    
            /// <summary></summary>
            public SpecialDealsController( 
                IUnitOfWorkAsync unitOfWorkAsync,
                ISpecialDealService service)
            {
                _unitOfWorkAsync = unitOfWorkAsync;
                _service = service;
            }
    
            /// <summary></summary>
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public IQueryable<SpecialDeal> GetSpecialDeals()
            {
                return _service.Queryable();
            }
    
            /// <summary></summary>
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public SingleResult<SpecialDeal> GetSpecialDealFromId( [FromODataUri] int SpecialDealID)
            {
                return SingleResult.Create(_service.Queryable().Where(t =>  t.SpecialDealID==SpecialDealID ));
            }
    
            /// <summary></summary>
            [HttpGet]
            [ODataRoute("({SpecialDealID})")]
            [EnableQuery]
            public SingleResult<SpecialDeal> GetSpecialDeal( [FromODataUri] int SpecialDealID)
            {
                return SingleResult.Create(_service.Queryable().Where(t =>  t.SpecialDealID==SpecialDealID ));
            }



            /// <summary></summary>
            [HttpPut]
            [ODataRoute("({SpecialDealID})")]
            public async Task<IHttpActionResult> Put( [FromODataUri] int SpecialDealID, SpecialDeal item)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                if (SpecialDealID == item.SpecialDealID)
                {
                    return BadRequest();
                }
    
                item.ObjectState = ObjectState.Modified;
                _service.Update(item);
    
                try
                {
                    await _unitOfWorkAsync.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists( SpecialDealID))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            /// <summary></summary>
            [HttpPost]
            [ODataRoute]
            public async Task<IHttpActionResult> Post(SpecialDeal item)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                item.ObjectState = ObjectState.Added;
                _service.Insert(item);
    
                try
                {
                    await _unitOfWorkAsync.SaveChangesAsync();
                }
                catch (DbUpdateException)
                {
                    if (ItemExists( item.SpecialDealID))
                    {
                        return Conflict();
                    }
                    throw;
                }
    
                return Created(item);
            }
    
            /// <summary></summary>
            [HttpPatch]
            [AcceptVerbs("PATCH", "MERGE")]
            [ODataRoute("({SpecialDealID})")]
            public async Task<IHttpActionResult> Patch( [FromODataUri] int SpecialDealID, Delta<SpecialDeal> patch)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                var item = await _service.FindAsync(  SpecialDealID );
    
                if (item == null)
                {
                    return NotFound();
                }
    
                patch.Patch(item);
                item.ObjectState = ObjectState.Modified;
    
                try
                {
                    await _unitOfWorkAsync.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ItemExists(  SpecialDealID ))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            /// <summary></summary>
            [HttpDelete]
            [ODataRoute]
            public async Task<IHttpActionResult> Delete( [FromODataUri] int SpecialDealID)
            {
                var item = await _service.FindAsync( SpecialDealID);
    
                if (item == null)
                {
                    return NotFound();
                }
    
                item.ObjectState = ObjectState.Deleted;
    
                _service.Delete(item);
                await _unitOfWorkAsync.SaveChangesAsync();
    
                return StatusCode(HttpStatusCode.NoContent);
            }

            /// <summary></summary>
            private bool ItemExists( [FromODataUri] int SpecialDealID)
            {
                return _service.Query(t =>  t.SpecialDealID==SpecialDealID).Select().Any();
            }
    
            /// <summary></summary>
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    _unitOfWorkAsync.Dispose();
                }
                base.Dispose(disposing);
            }
        }
}