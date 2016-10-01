using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Web.Http;
using Newtonsoft.Json.Serialization;

namespace ColduTourmalet.web
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var jsonFormatter = new JsonMediaTypeFormatter();
            // Web API configuration and services
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
            jsonFormatter.UseDataContractJsonSerializer = false;
            
            //optional: set serializer settings here
            config.Services.Replace(typeof(IContentNegotiator), new JsonContentNegotiator(jsonFormatter));

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }

    public class JsonContentNegotiator : IContentNegotiator
    {
        private JsonMediaTypeFormatter JsonFormatter;

        public JsonContentNegotiator(JsonMediaTypeFormatter jsonFormatter)
        {
            JsonFormatter = jsonFormatter;
        }

        public ContentNegotiationResult Negotiate(Type type, HttpRequestMessage request, IEnumerable<MediaTypeFormatter> formatters)
        {
            return new ContentNegotiationResult(
            this.JsonFormatter,
            new MediaTypeHeaderValue("application/json"));
        }
    }
}
