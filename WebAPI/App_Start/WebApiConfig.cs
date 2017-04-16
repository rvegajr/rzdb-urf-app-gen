using System.Net.Http.Formatting;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Cors;
using System.Web.Http.Filters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using DataAccess.Models;
using System.Web.Http.Dispatcher;
using Microsoft.Practices.Unity;
using System.Web.Http.ExceptionHandling;

namespace WebAPI
{
    public static class WebApiConfig
    {
        public static HttpConfiguration OwinRegister()
        {
            HttpConfiguration config = new HttpConfiguration();
            config.IncludeErrorDetailPolicy = IncludeErrorDetailPolicy.Always;
            config.DependencyResolver = new CustomUnityDependencyResolver(UnityOwinHelpers.GetConfiguredContainer());
            
            Register(config);
            return config;
        }
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.Services.Replace(typeof(IExceptionLogger), new UnhandledExceptionLogger());
            config.Services.Replace(typeof(IExceptionHandler), new GlobalExceptionHandler());

            // Web API configuration and services
            var serializer = config.Formatters.JsonFormatter.CreateJsonSerializer();
            serializer.Converters.Add(new Newtonsoft.Json.Converters.StringEnumConverter());

            config.Formatters.JsonFormatter.SerializerSettings =
                new JsonSerializerSettings
                {
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    NullValueHandling = NullValueHandling.Ignore,
                    ContractResolver = new CamelCasePropertyNamesContractResolver()
                };
            config.Formatters.Clear();
            config.Formatters.Insert(0, new JsonMediaTypeFormatter());

            //EnableCorsAttribute cors = new EnableCorsAttribute("*", "*", "*");
            //config.EnableCors(cors);

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "webapi/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            ODataConfig.Register(config);
        }
    }
    public class AllowCrossSiteJsonAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            //actionContext.Response.Headers.Add("Access-Control-Allow-Origin", "*");
            base.OnActionExecuting(actionContext);
        }
    }
}
