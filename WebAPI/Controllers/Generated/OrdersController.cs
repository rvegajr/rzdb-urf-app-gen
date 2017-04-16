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

namespace WebAPI.Controllers
{
    [ODataRoutePrefix("Orders")]
        public partial class OrdersController : ODataController
        {
            private readonly IOrderService _service;
            private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    
            public OrdersController( 
                IUnitOfWorkAsync unitOfWorkAsync,
                IOrderService service)
            {
                _unitOfWorkAsync = unitOfWorkAsync;
                _service = service;
            }
    
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public IQueryable<Order> GetOrders()
            {
                return _service.Queryable();
            }
    
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public SingleResult<Order> GetOrderFromId([FromODataUri] int OrderId)
            {
                return SingleResult.Create(_service.Queryable().Where(t => t.OrderID == OrderId));
            }
    
            [HttpGet]
            [ODataRoute("({Orderid})")]
            [EnableQuery]
            public SingleResult<Order> GetOrder([FromODataUri] int OrderId)
            {
                return SingleResult.Create(_service.Queryable().Where(t => t.OrderID == OrderId));
            }

            [HttpPut]
            [ODataRoute("({OrderId})")]
            public async Task<IHttpActionResult> Put(int OrderId, Order item)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                if (OrderId != item.OrderID)
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
                    if (!ItemExists(OrderId))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            [HttpPost]
            [ODataRoute]
            public async Task<IHttpActionResult> Post(Order item)
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
                    if (ItemExists(item.OrderID))
                    {
                        return Conflict();
                    }
                    throw;
                }
    
                return Created(item);
            }
    
            [HttpPatch]
            [AcceptVerbs("PATCH", "MERGE")]
            [ODataRoute("({OrderId})")]
            public async Task<IHttpActionResult> Patch(int OrderId, Delta<Order> patch)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                Order item = await _service.FindAsync(OrderId);
    
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
                    if (!ItemExists(OrderId))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            [HttpDelete]
            [ODataRoute]
            public async Task<IHttpActionResult> Delete(int key)
            {
                Order item = await _service.FindAsync(key);
    
                if (item == null)
                {
                    return NotFound();
                }
    
                item.ObjectState = ObjectState.Deleted;
    
                _service.Delete(item);
                await _unitOfWorkAsync.SaveChangesAsync();
    
                return StatusCode(HttpStatusCode.NoContent);
            }
    
            protected override void Dispose(bool disposing)
            {
                if (disposing)
                {
                    _unitOfWorkAsync.Dispose();
                }
                base.Dispose(disposing);
            }
    
            private bool ItemExists(int OrderId)
            {
                return _service.Query(e => e.OrderID == OrderId).Select().Any();
            }
        }
}