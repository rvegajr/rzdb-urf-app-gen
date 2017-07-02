using Microsoft.Practices.Unity;
using Repository.Pattern.DataContext;
using Repository.Pattern.Ef6;
using Repository.Pattern.Repositories;
using Repository.Pattern.UnitOfWork;

namespace WebApi
{
    /// <summary></summary>
    public static class UnityConfigRegistrations
    {
        /// <summary></summary>
        public static void RegisterTypes(IUnityContainer container)
        {
            RegisterTypes(container, UnityRegistrationLifetimeManagerType.PerRequest);
        }
        /// <summary></summary>
        public static void RegisterTypesOwin(IUnityContainer container)
        {
            RegisterTypes(container, UnityRegistrationLifetimeManagerType.NotControlled);
        }
        /// <summary></summary>
        public static void RegisterTypes(IUnityContainer container, UnityRegistrationLifetimeManagerType lifetimeMangerType)
        {
            //container
            //.RegisterType<IScenarioObjectService, ScenarioObjectServiceEx>()
            //;
        }
    }
}