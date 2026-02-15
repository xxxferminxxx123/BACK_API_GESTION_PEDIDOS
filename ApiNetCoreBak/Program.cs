using ApiNetCoreBak.Controllers.Modulos.CoreBak.Planilla.Scoped;
using ApiNetCoreBak.Controllers.Modulos.CoreBak.Rol.CasosUso.Scoped;
using COREBAK.Middleware.Exceptions.Infraestructura.Middleware;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);
    var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

    // Configuración de DbContexts
    //builder.Services.AddDbContext<RolDbContext>(options => options.UseSqlServer(connectionString));
    //builder.Services.AddDbContext<ListarUsuarioDbContext>(options =>options.UseSqlServer(connectionString));

    builder.Services.AddRolServices(connectionString);
    builder.Services.AddPlanillaServices(connectionString);


    builder.Services.AddControllers();
    builder.Services.AddEndpointsApiExplorer();

    //-------------------------------->
    //-------------------------------->
    //-------------------------------->
    //JWTKey-------------------------------->

    string key = "1uCpfKVEM7F7PnMJ1ZQSslduRbf8osyTNQxIkt1T5KI";

    builder.Services.AddAuthorization();
    builder.Services.AddAuthentication("Bearer").AddJwtBearer(option =>
    {
        var signigKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        var signingCredentials = new SigningCredentials(signigKey, SecurityAlgorithms.HmacSha256Signature);
        option.RequireHttpsMetadata = false;
        option.TokenValidationParameters = new TokenValidationParameters()
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            IssuerSigningKey = signigKey,
        };
    });
    //-------------------------------->
    //-------------------------------->
    //-------------------------------->

    builder.Services.AddSwaggerGen();

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

    var app = builder.Build();

    app.UseMiddleware<ExceptionHandlingMiddleware>();

    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }

    app.UseHttpsRedirection();

    app.UseCors("AllowFrontend");

    app.UseAuthentication(); // ← IMPORTANTE

    app.UseAuthorization();

    app.MapControllers();

    app.Run();