using COREBAK.BDAdapter;
using COREBAK.JsonAdaptor;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Adaptador;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Persistencia;
using COREBAK.Pedido_.CasosUso.Web.CrearPedido.Infraestructura.Puerto;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Adaptadores
builder.Services.AddSingleton<IJsonAdaptador, JsonAdaptador>();

builder.Services.AddScoped<DBAdaptador>(provider =>
    new DBAdaptador(connectionString));

builder.Services.AddScoped<IDBAdaptador>(provider =>
    provider.GetRequiredService<DBAdaptador>());

builder.Services.AddScoped<IDelegado>(provider =>
{
    var dbAdaptador = provider.GetRequiredService<DBAdaptador>();
    return new BaseDatosSQL(dbAdaptador);
});

builder.Services.AddScoped<ICrearPedidoPuerto, CrearPedidoAdaptador>();

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