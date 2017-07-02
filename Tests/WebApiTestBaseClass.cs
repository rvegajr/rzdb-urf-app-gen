using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using Microsoft.Owin.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.Owin.Testing;

namespace Tests
{
    public class WebApiTestBaseClass
    {
        private static readonly Destructor Finalise = new Destructor();
        protected static TestServer TestServer;
        protected static HttpClient HttpClient;
        protected static IDisposable _app;
        //thanks! http://stackoverflow.com/questions/4364665/static-destructor
        static WebApiTestBaseClass()
        {
            TestServer = TestServer.Create<WebApi.Owin.Startup>();
            HttpClient = new HttpClient(TestServer.Handler);
        }


        private sealed class Destructor
        {
            ~Destructor()
            {
                //HttpClient.Dispose();
                TestServer.Dispose();
            }
        }
    }
}