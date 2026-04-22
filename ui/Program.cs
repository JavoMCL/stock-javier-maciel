using Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ui
{
    internal static class Program
    {
        [STAThread]
        private static void Main()
        {
            using var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((_, configuration) =>
                {
                    configuration.AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);
                })
                .ConfigureServices((context, services) =>
                {
                    var connection = context.Configuration.GetConnectionString("DefaultConnection")
                                     ?? throw new InvalidOperationException("Falta ConnectionStrings:DefaultConnection en appsettings.json");

                    services.AddDbContext<AppDbContext>(options =>
                        options.UseMySql(connection, ServerVersion.AutoDetect(connection)));

                    services.AddTransient<frmPrincipal>();
                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                db.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();
            var mainForm = host.Services.GetRequiredService<frmPrincipal>();
            Application.Run(mainForm);
        }
    }
}