using System;
using System.Net;
using BisSandboxApi.Web.Models.Responses;

namespace BisSandboxApi.Web.Middlewares;

public class ExceptionMiddleware
{
    private readonly RequestDelegate _next;

    public ExceptionMiddleware(RequestDelegate next)
    {
        _next = next;
    }

    public async Task InvokeAsync(HttpContext httpContext)
    {
        try
        {
            await _next(httpContext);
        }
        catch (Exception ex)
        {
            await HandleExceptionAsync(httpContext, ex);
        }
    }

    private async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = 0;

        await context.Response.WriteAsync(new ApiResponse()
        {
            ErrorCode = context.Response.StatusCode,
            //ErrorMsg = "Internal Server Error"
            ErrorMsg = exception.Message
        }.ToString());
    }
}