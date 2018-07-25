using System;
using System.Configuration;
using Feedback.Service.Providers;
using Microsoft.Practices.Unity.Configuration;
using Unity;
using Unity.Lifetime;

namespace Feedback.Service
{
    internal static class DependencyFactory
    {
        private static readonly IUnityContainer Container;       
        
        static DependencyFactory()
        {
            Container = new UnityContainer();

            var section = (UnityConfigurationSection) ConfigurationManager.GetSection("unity");
            if (section != null)
            {
                section.Configure(Container);
            }

            RegisterTypes();
        }        

        public static T Resolve<T>()
        {
            if (!Container.IsRegistered(typeof(T)))
            {
                throw new Exception("Type is not registered!");
            }
            
            return Container.Resolve<T>();
        }

        private static void RegisterTypes()
        {
            Container.RegisterType<IFeedbackProvider, FeedbackProvider>(new SingletonLifetimeManager());
        }
    }
}