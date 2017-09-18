using Microsoft.Restier.Providers.EntityFramework;
using Microsoft.Restier.Publishers.OData;
using Microsoft.Restier.Publishers.OData.Batch;
using System.Web.Http;
using System.Web.OData;

namespace RestierTests
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web-API-Konfiguration und -Dienste

            // Web-API-Routen
            config.MapHttpAttributeRoutes();

            config.MessageHandlers.Add(new ETagMessageHandler());

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            config.MapRestierRoute<EntityFrameworkApi<Models.Context>>(
                "CRM",
                "crm",
                new RestierBatchHandler(GlobalConfiguration.DefaultServer));
        }
    }
}