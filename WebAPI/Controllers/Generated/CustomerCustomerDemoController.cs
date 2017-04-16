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
    [ODataRoutePrefix("CustomerCustomerDemo")]
        public partial class CustomerCustomerDemoController : ODataController
        {
            private readonly ICustomerCustomerDemoService _service;
            private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    
            public CustomerCustomerDemoController( 
                IUnitOfWorkAsync unitOfWorkAsync,
                ICustomerCustomerDemoService service)
            {
                _unitOfWorkAsync = unitOfWorkAsync;
                _service = service;
            }
    
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public IQueryable<CustomerCustomerDemo> GetCustomerCustomerDemo()
            {
                return _service.Queryable();
            }
    
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public SingleResult<CustomerCustomerDemo> GetCustomerCustomerDemoFromId([FromODataUri] int CustomerCustomerDemoId)
            {
                return SingleResult.Create(_service.Queryable().Where(t => t.CustomerCustomerDemoId == CustomerCustomerDemoId));
            }
    
            [HttpGet]
            [ODataRoute("({CustomerCustomerDemoid})")]
            [EnableQuery]
            public SingleResult<CustomerCustomerDemo> GetCustomerCustomerDemo([FromODataUri] int CustomerCustomerDemoId)
            {
                return SingleResult.Create(_service.Queryable().Where(t => t.CustomerCustomerDemoId == CustomerCustomerDemoId));
            }

            [HttpPut]
            [ODataRoute("({CustomerCustomerDemoId})")]
            public async Task<IHttpActionResult> Put(int CustomerCustomerDemoId, CustomerCustomerDemo item)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                if (CustomerCustomerDemoId != item.CustomerCustomerDemoId)
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
                    if (!ItemExists(CustomerCustomerDemoId))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            [HttpPost]
            [ODataRoute]
            public async Task<IHttpActionResult> Post(CustomerCustomerDemo item)
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
                    if (ItemExists(item.CustomerCustomerDemoId))
                    {
                        return Conflict();
                    }
                    throw;
                }
    
                return Created(item);
            }
    
            [HttpPatch]
            [AcceptVerbs("PATCH", "MERGE")]
            [ODataRoute("({CustomerCustomerDemoId})")]
            public async Task<IHttpActionResult> Patch(int CustomerCustomerDemoId, Delta<CustomerCustomerDemo> patch)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                CustomerCustomerDemo item = await _service.FindAsync(CustomerCustomerDemoId);
    
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
                    if (!ItemExists(CustomerCustomerDemoId))
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
                CustomerCustomerDemo item = await _service.FindAsync(key);
    
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
    
            private bool ItemExists(int CustomerCustomerDemoId)
            {
                return _service.Query(e => e.CustomerCustomerDemoId == CustomerCustomerDemoId).Select().Any();
            }
        }
}