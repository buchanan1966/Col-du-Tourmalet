using System.Linq;
using Microsoft.Practices.Unity;
using System.Web.Http;
using System.Web.Mvc;
using ColduTourmalet.web.code.business;
using ColduTourmalet.web.code.data;
using Microsoft.Practices.Unity.Mvc;
using UnityDependencyResolver = Unity.WebApi.UnityDependencyResolver;

namespace ColduTourmalet.web
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            FilterProviders.Providers.Remove(FilterProviders.Providers.OfType<FilterAttributeFilterProvider>().First());
            FilterProviders.Providers.Add(new UnityFilterAttributeFilterProvider(container));

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IEntityManager<JournalEntry>, JournalEntryManager>();

            DependencyResolver.SetResolver(new Microsoft.Practices.Unity.Mvc.UnityDependencyResolver(container));
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);

        }
    }
}