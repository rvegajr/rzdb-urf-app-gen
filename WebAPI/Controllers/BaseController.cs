using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CppeDb.WebAPI.Controllers
{
    public abstract class BaseController : ApiController
    {
        internal HttpResponseMessage MapExceptionToReponse(Exception ex)
        {
            return Request.CreateResponse(HttpStatusCode.InternalServerError,
                new
                {
                    Message = ex.Message,
                    Inner = ex.InnerException?.Message,
                    Controller = ControllerContext.RouteData.Values["controller"].ToString(),
                    Action = ControllerContext.RouteData.Values["action"].ToString()
                });
        }

        internal IHttpActionResult ExceptionAsIHttpActionResult(Exception ex)
        {
            return InternalServerError(ex);
        }

    }
}