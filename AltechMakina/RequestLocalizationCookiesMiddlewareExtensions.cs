namespace AltechMakina
{
    public static class RequestLocalizationCookiesMiddlewareExtensions
    {
        public static IApplicationBuilder UseRequestLocalizationCookies(this IApplicationBuilder app)
       => app.UseMiddleware<RequestLocalizationCookiesMiddleware>();
    }
}
