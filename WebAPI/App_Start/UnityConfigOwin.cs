﻿using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.Practices.Unity;
using System.Linq;
using WebApi.Owin;

namespace WebApi
{
    public static class UnityOwinHelpers
    {
        #region Unity Container
        private static Lazy<IUnityContainer> container = new Lazy<IUnityContainer>(() =>
        {
            var container = new UnityContainer();
            RegisterTypes(container);
            return container;
        });

        public static IUnityContainer GetConfiguredContainer()
        {
            return container.Value;
        }
        #endregion

        //private static readonly Type[] EmptyTypes = new Type[0];

        public static IEnumerable<Type> GetTypesWithCustomAttribute<T>(Assembly[] assemblies)
        {
            foreach (var assembly in assemblies)
            {
                foreach (Type type in assembly.GetTypes())
                {
                    if (type.GetCustomAttributes(typeof(T), true).Length > 0)
                    {
                        yield return type;
                    }
                }
            }
        }

        public static void RegisterTypes(IUnityContainer container)
        {
            //var myAssemblies = AppDomain.CurrentDomain.GetAssemblies().Where(a => a.FullName.StartsWith("SelfHostWebApiOwin")).ToArray();

            container.RegisterType(typeof(Startup));
            UnityConfigRegistrations.RegisterTypesOwin(container);
            /*
            container.RegisterTypes(
                UnityHelpers.GetTypesWithCustomAttribute<UnityIoCContainerControlledAttribute>(myAssemblies),
                WithMappings.FromMatchingInterface,
                WithName.Default,
                WithLifetime.ContainerControlled,
                null
                ).RegisterTypes(
                         UnityHelpers.GetTypesWithCustomAttribute<UnityIoCTransientLifetimeAttribute>(myAssemblies),
                         WithMappings.FromMatchingInterface,
                         WithName.Default,
                         WithLifetime.Transient);
            */
        }

    }
}