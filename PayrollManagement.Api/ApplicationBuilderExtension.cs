namespace PayrollManagement.Api
{
    public static class ApplicationBuilderExtension
    {
        public static IApplicationBuilder UseCustomizedCors(this IApplicationBuilder app)
        {
            app.UseCors(builder =>
            {
                builder.AllowAnyHeader();
                builder.AllowAnyMethod();
                builder.AllowAnyOrigin();
                //builder.WithOrigins("http://localhost:49862");
                //builder.WithMethods("GET");
                //builder.WithHeaders("Authorization");
            });
            return app;
        }
    }
}
