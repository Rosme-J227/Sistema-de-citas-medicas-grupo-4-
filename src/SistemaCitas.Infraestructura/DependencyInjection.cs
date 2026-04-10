using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SistemaCitas.Infraestructura.Persistencia;

namespace SistemaCitas.Infraestructura;

public static class DependencyInjection
{
    public static IServiceCollection AddInfraestructura(this IServiceCollection services, string connectionString)
    {
        services.AddDbContext<SistemaCitasDbContext>(options =>
            options.UseSqlite(connectionString));

        return services;
    }
}
