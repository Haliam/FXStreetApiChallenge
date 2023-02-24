using Microsoft.OpenApi.Models;
using System;

namespace Football.API
{
    public static class FootballApiDoc
    {
        public static OpenApiInfo GetInfo()
        {
            return new OpenApiInfo
            {
                Title = "Football API",
                Contact = new OpenApiContact
                {
                    Email = "devhaliam@gmail.com",
                    Name = "Haliam Pérez",
                    Url = new Uri("https://github.com/Haliam")
                },
                License = new OpenApiLicense
                {
                    Name = "Football License",
                    Url = new Uri("https://opensource.org/licenses/mit"),

                },
                Version = "v1",
            };
        }
    }
}
