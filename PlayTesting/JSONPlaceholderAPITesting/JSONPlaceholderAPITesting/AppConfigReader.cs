using System.Configuration;

namespace JSONPlaceholderAPITesting
{
    public class AppConfigReader
    {
        public static readonly string baseUrl = ConfigurationManager.AppSettings["base_url"];
    }
}
