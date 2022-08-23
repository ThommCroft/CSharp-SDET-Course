using System.Configuration;

namespace WebAPITesting
{
    public static class AppConfigReader
    {
        public static readonly string baseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
