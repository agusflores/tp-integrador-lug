namespace Data
{
    using System.Configuration;

    public static class DbConnectionString
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["DbConnString"].ConnectionString;
        }
    }
}
