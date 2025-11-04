using COREBAK.BDAdapter;
using COREBAK.JsonAdaptor;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Adaptador;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Puerto;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Aplicacion;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Delegados;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Domain.Servicio;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Adaptador;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Persistencia;
using COREBAK.Usuario_.CasoUso.RegistarUsuario.Infraestructura.Puerto;

var builder = WebApplication.CreateBuilder(args);

// ========== CONFIGURACIÓN ==========
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ========== INYECCIÓN DE DEPENDENCIAS ==========

// Adaptadores
builder.Services.AddSingleton<IJsonAdaptador, JsonAdaptador>();

// IMPORTANTE: Registra DBAdaptador como CLASE CONCRETA
builder.Services.AddScoped<DBAdaptador>(provider =>
    new DBAdaptador(connectionString));

// También registra la interfaz si la tienes
builder.Services.AddScoped<IDBAdaptador>(provider =>
    provider.GetRequiredService<DBAdaptador>());

// Capa de Persistencia
builder.Services.AddScoped<IDelegado>(provider =>
{
    var dbAdaptador = provider.GetRequiredService<DBAdaptador>();
    return new BaseDatosSQL(dbAdaptador);
});

// Capa de Dominio

// Capa de Aplicación

// Puerto
builder.Services.AddScoped<IRegistrarUsuarioPuerto, RegistarUsuarioAdaptador>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();