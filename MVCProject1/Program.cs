namespace MVCProject1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews(); //Register Built-in MVC Service

            var app = builder.Build();

            //app.MapGet("/", () => "Hello World!");
            //app.MapGet("/login", () => "u r signed in!");
            //app.MapGet("/login", SignIn);

            app.UseStaticFiles(); //Configuar Middleware Static Files

            //MVC
            app.MapControllerRoute
                (
                name:"default",
                pattern:"{controller=Home}/{action=Index}/{id?}"
                );

            app.Run();
        }

        public static string SignIn()
        {
            return $"u r signed in!";
        }
    }
}
