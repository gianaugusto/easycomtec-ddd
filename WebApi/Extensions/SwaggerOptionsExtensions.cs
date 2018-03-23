using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.IO;

namespace WebApi.Extensions
{
    public static class SwaggerGenOptionsExtensions
    {
        public static SwaggerGenOptions AddXmlComment(this SwaggerGenOptions options)
        {
            var dir = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory);
            foreach (var fi in dir.EnumerateFiles("*.xml"))
            {
                options.IncludeXmlComments(fi.FullName);
            }
            return options;
        }
    }
}
