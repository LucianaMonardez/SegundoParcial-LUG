using System.Configuration;

namespace DAL
{
    public class ConnectionUtils
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["ParcialConnection"].ConnectionString;
        }
    }
}
