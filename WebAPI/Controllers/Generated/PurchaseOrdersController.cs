
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
        [ODataRoutePrefix("PurchaseOrders")]
        public partial class PurchaseOrdersController : ODataController
        {
            private readonly IPurchaseOrderService _service;
            private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    
            /// <summary></summary>
            public PurchaseOrdersController( 
                IUnitOfWorkAsync unitOfWorkAsync,
                IPurchaseOrderService service)
            {
                _unitOfWorkAsync = unitOfWorkAsync;
                _service = service;
            }
    
            /// <summary></summary>
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public IQueryable<PurchaseOrder> GetPurchaseOrders()
            {
                return _service.Queryable();
            }
    
            /// <summary></summary>
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public SingleResult<PurchaseOrder> GetPurchaseOrderFromId( [FromODataUri] int PurchaseOrderID)
            {
                return SingleResult.Create(_service.Queryable().Where(t =>  t.PurchaseOrderID==PurchaseOrderID ));
            }
    
            /// <summary></summary>
            [HttpGet]
            [ODataRoute("({PurchaseOrderID})")]
            [EnableQuery]
            public SingleResult<PurchaseOrder> GetPurchaseOrder( [FromODataUri] int PurchaseOrderID)
            {
                return SingleResult.Create(_service.Queryable().Where(t =>  t.PurchaseOrderID==PurchaseOrderID ));
            }



            /// <summary></summary>
            [HttpPut]
            [ODataRoute("({PurchaseOrderID})")]
            public async Task<IHttpActionResult> Put( [FromODataUri] int PurchaseOrderID, PurchaseOrder item)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                if (PurchaseOrderID == item.PurchaseOrderID)
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
                    if (!ItemExists( PurchaseOrderID))
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
            public async Task<IHttpActionResult> Post(PurchaseOrder item)
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
                    if (ItemExists( item.PurchaseOrderID))
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
            [ODataRoute("({PurchaseOrderID})")]
            public async Task<IHttpActionResult> Patch( [FromODataUri] int PurchaseOrderID, Delta<PurchaseOrder> patch)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                var item = await _service.FindAsync(  PurchaseOrderID );
    
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
                    if (!ItemExists(  PurchaseOrderID ))
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
            public async Task<IHttpActionResult> Delete( [FromODataUri] int PurchaseOrderID)
            {
                var item = await _service.FindAsync( PurchaseOrderID);
    
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
            private bool ItemExists( [FromODataUri] int PurchaseOrderID)
            {
                return _service.Query(t =>  t.PurchaseOrderID==PurchaseOrderID).Select().Any();
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
