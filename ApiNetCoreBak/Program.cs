using ApiNetCoreBak.Controllers.Modulos.CoreBak.Rol.CasosUso.Scoped;
using ApiNetCoreBak.Controllers.Modulos.CoreBak.Usuario.Scoped;

using COREBAK.Exceptions.Infraestructura.Middleware;
using COREBAK.Rol_.CasosUso.RegistrarRol_.Infraestructura.Data;
using COREBAK.Usuario_.CasosUso.RegistrarUsuario_.Infraestructura.Data;
using Microsoft.EntityFrameworkCore;

    var builder = WebApplication.CreateBuilder(args);

    // ========== CONFIGURACIÓN DE SERVICIOS ==========

    // 1. Configurar DbContext
    //builder.Services.AddDbContext<ApplicationDbContext>(options =>
    //    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddDbContext<RolDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

// 2. Agregar servicios del módulo Usuario
    //builder.Services.AddUsuarioServices();
    builder.Services.AddRolServices();

// 3. Servicios de ASP.NET Core
builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    // 4. Configurar Swagger (sin JWT)
    builder.Services.AddSwaggerGen();

    // 5. Configurar CORS
    builder.Services.AddCors(options =>
    {
        options.AddPolicy("AllowFrontend", policy =>
        {
            policy
                .WithOrigins(
                    "http://localhost:4200",   // Angular
                    "http://localhost:5173",   // Vite
                    "http://localhost:8080"    // Vue CLI
                )
                .AllowAnyHeader()
                .AllowAnyMethod()
                .AllowCredentials();
        });
    });

    // ========== CONSTRUCCIÓN DE LA APLICACIÓN ==========
    var app = builder.Build();

    // ========== CONFIGURACIÓN DEL PIPELINE ==========

    // 1. Middleware de manejo de excepciones
    app.UseMiddleware<ExceptionHandlingMiddleware>();

    // 2. Configuración para desarrollo
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    // 3. Middlewares de seguridad y routing
    app.UseHttpsRedirection();

    // 4. Activar CORS (antes de MapControllers)
    app.UseCors("AllowFrontend");

    // 5. Mapeo de controladores
    app.MapControllers();

    // ========== EJECUCIÓN ==========
    app.Run();
