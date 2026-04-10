using Microsoft.Extensions.DependencyInjection;

namespace SistemaCitas.Aplicacion;

public static class DependencyInjection
{
    public static IServiceCollection AddAplicacion(this IServiceCollection services)
    {
        // Aquí irán los servicios de aplicación y casos de uso
        return services;
    }
}
