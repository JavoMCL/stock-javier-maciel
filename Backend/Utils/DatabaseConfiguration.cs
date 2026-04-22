using Microsoft.Extensions.Configuration;

namespace Backend.Utils;

internal static class DatabaseConfiguration
{
    internal static string GetConnectionString()
    {
        var envConnection = Environment.GetEnvironmentVariable("STOCK_CONNECTION_STRING");
        if (!string.IsNullOrWhiteSpace(envConnection))
        {
            return envConnection;
        }

        var candidates = new[]
        {
            Path.Combine(AppContext.BaseDirectory, "appsettings.json"),
            Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json"),
            Path.Combine(Directory.GetCurrentDirectory(), "ui", "appsettings.json"),
            Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "ui", "appsettings.json"))
        };

        var configBuilder = new ConfigurationBuilder();

        foreach (var candidate in candidates)
        {
            if (File.Exists(candidate))
            {
                configBuilder.AddJsonFile(candidate, optional: false, reloadOnChange: false);
                var config = configBuilder.Build();
                var connectionString = config.GetConnectionString("DefaultConnection");
                if (!string.IsNullOrWhiteSpace(connectionString))
                {
                    return connectionString;
                }
            }
        }

        throw new InvalidOperationException("No se encontro 'DefaultConnection'. Define STOCK_CONNECTION_STRING o appsettings.json.");
    }
}

