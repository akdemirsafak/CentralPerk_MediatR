using CentralPerk.API.Dtos;
using Microsoft.AspNetCore.Diagnostics;

namespace CentralPerk.API.Middlewares;

public static class UseCustomExceptionHandler
{
    public static void UseCustomException(this IApplicationBuilder app)
    {
        app.UseExceptionHandler(options =>
        {
            options.Run(async context =>
            {
                context.Response.ContentType = "application/json";
                var exceptionFeature = context.Features.Get<IExceptionHandlerFeature>();
                var exception = exceptionFeature.Error;
                context.Response.StatusCode = 500;
                await context.Response.WriteAsJsonAsync(ResponseDto<NoContentDto>.Fail(exception.Message));
            });
        });
    }
}