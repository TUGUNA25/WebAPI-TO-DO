using TO_DO.API.Infrastructure.Middlewares;

namespace TO_DO.API.Infrastructure.Extensions
{
    public static class ExceptionHandlerMiddlewareExtensions
    {
        public static void UseExceptionHandlerMiddleware (this IApplicationBuilder builder)
        {
            builder.UseMiddleware<ExceptionHandlerMiddleware>();
        }
    }
}
