using COREBAK.Middleware.Exceptions.Aplicacition;
using COREBAK.Middleware.Exceptions.Dominio.Excepciones;
using Microsoft.AspNetCore.Http;           // ✅ Para RequestDelegate y HttpContext
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Net;
using System.Text.Json;
namespace COREBAK.Middleware.Exceptions.Infraestructura.Middleware
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandlingMiddleware> _logger;

        public ExceptionHandlingMiddleware(
            RequestDelegate next,
            ILogger<ExceptionHandlingMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _next(context);

                // ✅ Interceptar respuestas exitosas sin contenido
                if (context.Response.StatusCode == StatusCodes.Status200OK &&
                    !context.Response.HasStarted &&
                    context.Response.ContentLength == null)
                {
                    await HandleSuccessResponseAsync(context);
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Ocurrió una excepción: {Message}", ex.Message);
                await HandleExceptionAsync(context, ex);
            }
        }

        private static async Task HandleSuccessResponseAsync(HttpContext context)
        {
            context.Response.ContentType = "application/json";

            var response = new
            {
                context.Response.StatusCode,
                Message = "La operación se realizó correctamente",
                Timestamp = DateTime.UtcNow,
                Path = context.Request.Path.Value
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(response, options);
            await context.Response.WriteAsync(json);
        }

        private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
        {
            context.Response.ContentType = "application/json";

            var (statusCode, message) = exception switch
            {
                ArgumentException _ => (StatusCodes.Status400BadRequest, "Error de validación"),
                KeyNotFoundException _ => (StatusCodes.Status404NotFound, "Recurso no encontrado"),
                UnauthorizedAccessException _ => (StatusCodes.Status401Unauthorized, "No autorizado"),
                InvalidOperationException _ => (StatusCodes.Status409Conflict, "Operación inválida"),
                _ => (StatusCodes.Status500InternalServerError, "Error interno del servidor")
            };

            context.Response.StatusCode = statusCode;

            var response = new
            {
                StatusCode = statusCode,
                Message = message,
                Details = exception.Message,
                Timestamp = DateTime.UtcNow,
                Path = context.Request.Path.Value
            };

            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

            var json = JsonSerializer.Serialize(response, options);
            await context.Response.WriteAsync(json);
        }
    }
}