namespace DynamicPropertyViewModel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews();

            var app = builder.Build();

            app.MapControllerRoute(
             "Corporative",
             "korporativ-satislar",
              "{controller=Home}/{action=CorporativeSales}/{id?}"
                );

            app.MapControllerRoute(
                "default",
                "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
