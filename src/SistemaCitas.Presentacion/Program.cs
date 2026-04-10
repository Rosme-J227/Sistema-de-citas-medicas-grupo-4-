using SistemaCitas.Presentacion.Components;
using SistemaCitas.Infraestructura;
using SistemaCitas.Aplicacion;

var builder = WebApplication.CreateBuilder(args);

// Agregar servicios al contenedor.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Obtener string de conexión (usará appsettings.json o variable por defecto)
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") 
    ?? "Data Source=sistemacitas.db";

// Registrar capas de Clean Architecture
builder.Services.AddInfraestructura(connectionString);
builder.Services.AddAplicacion();

var app = builder.Build();

// Configurar el pipeline de solicitudes HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // El valor predeterminado de HSTS es 30 días. Es posible que desee cambiarlo para escenarios de producción.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

// Endpoint de prueba básico
app.MapGet("/api/estado", () => Results.Ok(new { Estado = "Saludable", Mensaje = "La API está ejecutándose correctamente" }));

app.Run();
