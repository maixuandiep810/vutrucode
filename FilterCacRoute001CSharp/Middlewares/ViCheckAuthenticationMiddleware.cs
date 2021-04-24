using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using vigalileo.Services.System.Auth;

namespace vigalileo.BackendApi.Middlewares
{
    public class ViCheckAuthenticationMiddleware
    {
        private readonly RequestDelegate _next;
        public ViCheckAuthenticationMiddleware(RequestDelegate next) => _next = next;
        public async Task Invoke(HttpContext httpContext, IJWTService jWTService)
        {
            if (String.IsNullOrEmpty(httpContext.Items["ClientId"].ToString()))
            {
                throw new System.Exception("You are not logged in.");
            }
            await _next(httpContext);
        }
    }
}