namespace Api_Farmacias.Helpers
{
    public class Startup
    {
         public void ConfigureServices(IServiceCollection services)
    {
        

        services.AddAutoMapper(typeof(Startup));
    }

    }
}