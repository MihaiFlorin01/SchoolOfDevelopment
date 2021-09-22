using FluentValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using SchoolOf.Common.DatabaseSettings;
using SchoolOf.Data;
using SchoolOf.Data.Abstraction;
using SchoolOf.Mappers;
using SchoolOf.ShoppingCart.Filters;
using SchoolOf.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolOf.ShoppingCart
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(corsOptions =>
            {
                corsOptions.AddPolicy("defaultPoly", corsPolicyBuilder =>
                {
                    corsPolicyBuilder.AllowAnyMethod();
                    corsPolicyBuilder.AllowAnyOrigin();
                    corsPolicyBuilder.AllowAnyHeader();
                });
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "SchoolOf.ShoppingCart", Version = "v1" });
            });

            services.AddScoped<DatabaseContext>();

            // unit of work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<GlobalExceptionFilter>();

            services.AddAutoMapper(typeof(ProductsMapperProfile).Assembly);

            services.AddValidatorsFromAssembly(typeof(CartProductValidator).Assembly);

            services.AddControllers(opt =>
            {
                opt.Filters.AddService<GlobalExceptionFilter>();
            });

            // configuration (options)
            services.Configure<DbSettings>(Configuration.GetSection(nameof(DbSettings)));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "SchoolOf.ShoppingCart v1"));
            }

            app.UseCors("defaultPoly");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
