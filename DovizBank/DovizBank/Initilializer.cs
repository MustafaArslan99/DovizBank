namespace DovizBank
{
    public class Initilializer
    {
        public static IConfigurationRoot Configuration;

        public static void Build()
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json",optional : true,reloadOnChange : true);
            Configuration = builder.Build();
        }
    }
}
