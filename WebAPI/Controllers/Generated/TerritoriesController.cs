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
    [ODataRoutePrefix("Territories")]
        public partial class TerritoriesController : ODataController
        {
            private readonly ITerritoryService _service;
            private readonly IUnitOfWorkAsync _unitOfWorkAsync;
    
            public TerritoriesController( 
                IUnitOfWorkAsync unitOfWorkAsync,
                ITerritoryService service)
            {
                _unitOfWorkAsync = unitOfWorkAsync;
                _service = service;
            }
    
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public IQueryable<Territory> GetTerritories()
            {
                return _service.Queryable();
            }
    
            [HttpGet]
            [ODataRoute]
            [EnableQuery]
            public SingleResult<Territory> GetTerritoryFromId([FromODataUri] string TerritoryId)
            {
                return SingleResult.Create(_service.Queryable().Where(t => t.TerritoryID == TerritoryId));
            }
    
            [HttpGet]
            [ODataRoute("({Territoryid})")]
            [EnableQuery]
            public SingleResult<Territory> GetTerritory([FromODataUri] string TerritoryId)
            {
                return SingleResult.Create(_service.Queryable().Where(t => t.TerritoryID == TerritoryId));
            }

            [HttpPut]
            [ODataRoute("({TerritoryId})")]
            public async Task<IHttpActionResult> Put(string TerritoryId, Territory item)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                if (TerritoryId != item.TerritoryID)
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
                    if (!ItemExists(TerritoryId))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            [HttpPost]
            [ODataRoute]
            public async Task<IHttpActionResult> Post(Territory item)
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
                    if (ItemExists(item.TerritoryID))
                    {
                        return Conflict();
                    }
                    throw;
                }
    
                return Created(item);
            }
    
            [HttpPatch]
            [AcceptVerbs("PATCH", "MERGE")]
            [ODataRoute("({TerritoryId})")]
            public async Task<IHttpActionResult> Patch(string TerritoryId, Delta<Territory> patch)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
    
                Territory item = await _service.FindAsync(TerritoryId);
    
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
                    if (!ItemExists(TerritoryId))
                    {
                        return NotFound();
                    }
                    throw;
                }
    
                return Updated(item);
            }
    
            [HttpDelete]
            [ODataRoute]
            public async Task<IHttpActionResult> Delete(string key)
            {
                Territory item = await _service.FindAsync(key);
    
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
    
            private bool ItemExists(string TerritoryId)
            {
                return _service.Query(e => e.TerritoryID == TerritoryId).Select().Any();
            }
        }
}