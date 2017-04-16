using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;

namespace CppeDb.WebApi.Controllers
{
    [RoutePrefix("api/values")]
    public class ValuesController : ApiController
    {
        /// <summary>
        /// Gets some very important data from the server.
        /// </summary>
        [HttpGet]
        [Route("")]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// Looks up some data by ID.
        /// </summary>
        /// <param name="id">The ID of the data.</param>
        [HttpGet]
        [Route("{id:int}")]
        public string Get(int id)
        {
            return "value " + id.ToString();
        }
    }
}