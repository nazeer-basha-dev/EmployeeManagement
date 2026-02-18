using EmployeeManagementAPI.DTOs;
using System.Security.Claims;

namespace EmployeeManagementAPI.Middleware
{
    public class CustomMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<CustomMiddleware> _logger;
        private readonly AuthSettings _authSettings;

        public CustomMiddleware(RequestDelegate next, ILogger<CustomMiddleware> logger, AuthSettings authSettings)
        {
            _next = next;
            _logger = logger;
            _authSettings = authSettings;
        }

        //public async Task InvokeAsync(HttpContext context)
        //{
        //    _logger.LogInformation("Handling request: " + context.Request.Method + " " + context.Request.Path);
        //    await context.Response.WriteAsync("Custom Middleware Executing...\n");
        //    await _next(context);
        //    _logger.LogInformation("Finished handling request.");
        //}

        public async Task InvokeAsync(HttpContext context)
        {
            var authHeader = context.Request.Headers["Authorization"].FirstOrDefault();

            if (string.IsNullOrEmpty(authHeader) || !authHeader.StartsWith("Bearer "))
            {
                context.Response.StatusCode = StatusCodes.Status401Unauthorized;
                await context.Response.WriteAsync("Missing or invalid Authorization header");
                return;
            }

            var token = authHeader.Substring("Bearer ".Length).Trim();

            if (token != _authSettings.TokenId)
            {
                context.Response.StatusCode = StatusCodes.Status403Forbidden;
                await context.Response.WriteAsync("Invalid token");
                return;
            }

            await _next(context);
        }
    }
}
