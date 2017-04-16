using Microsoft.Practices.Unity;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;
using System.Web.Http;
using Unity.WebApi;
using System;
using DataAccess.Models;

namespace WebAPI.Models
{
    public static class UnityConfig
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        private static void RegisterTypes(UnityContainer container)
        {
            UnityConfigRegistrations.RegisterTypes( container );
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }

        /// <summary>
        /// Gets the configured Unity container.
        /// </summary>
        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion
    }
}