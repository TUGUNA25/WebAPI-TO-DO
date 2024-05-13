using TO_DO.API.Infrastructure.Middlewares;

namespace TO_DO.API.Infrastructure.Extensions
{
    public static class RequestResponseLoggingMiddlewareExtensions
    {
        public static void UseRequestResponseLogging(this IApplicationBuilder builder)
        {
            builder.UseMiddleware<RequestResponseLoggingMiddleware>();
        }
    }
}
