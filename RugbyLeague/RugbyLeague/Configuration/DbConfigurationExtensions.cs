using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RugbyLeague.Data.EfStructures;

namespace RugbyLeague.Configuration
{
    public static class DbConfigurationExtensions
    {
        public static IServiceCollection ConfigureDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<RugbyLeagueDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("MasterDbConnection")));
            return services;
        }
    }
}
