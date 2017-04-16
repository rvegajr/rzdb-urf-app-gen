using Microsoft.Owin;
using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Dispatcher;

[assembly: OwinStartup(typeof(WebAPI.Owin.Startup))]

namespace WebAPI.Owin
{
    public class Startup
    {
        public static void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.OwinRegister());
        }
    }
}