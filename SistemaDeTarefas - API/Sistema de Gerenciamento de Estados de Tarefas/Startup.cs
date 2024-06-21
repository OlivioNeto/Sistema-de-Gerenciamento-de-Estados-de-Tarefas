﻿using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Sistema_de_Gerenciamento_de_Estados_de_Tarefas.Data;

namespace Sistema_de_Gerenciamento_de_Estados_de_Tarefas
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new InvalidOperationException("A cadeia de conexão 'DefaultConnection' é nula ou vazia.");
            }

            services.AddDbContext<StateDBContext>(options =>
                options.UseNpgsql(connectionString));

            services.AddControllers();

            // Configuração do Swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "API - Sistema de Gerenciamento de Tarefas", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            // Habilitação do middleware do Swagger
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API - Sistema de Gerenciamento de Tarefas");
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
