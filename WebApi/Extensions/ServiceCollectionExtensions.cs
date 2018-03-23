using Microsoft.Extensions.DependencyInjection;

using Swashbuckle.AspNetCore.Swagger;


namespace WebApi.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(options =>
            {
                options.SwaggerDoc("v1", new Info
                {
                    Version = "1",
                    Title = "API demo Easycommtech",
                    Description = "API responsavel por expor recursos do dominio de Talentos",
                    Contact = new Contact
                    {
                        Name = "Giancarlos Augusto Macedo"
                    }
                });
                
                options.DescribeAllEnumsAsStrings();
                options.DescribeStringEnumsInCamelCase();
                options.AddXmlComment();
            });
            return services;
        }
    }
}
