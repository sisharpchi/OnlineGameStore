using Microsoft.EntityFrameworkCore;
using OnlineGameStore.Dal;

namespace OnlineGameStore.Server.Configuration;

public static class DataBaseConfiguration
{
    public static void AddDataBaseConnection(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

        builder.Services.AddDbContext<MainContext>(options =>
            options.UseSqlServer(connectionString));
    }
}
