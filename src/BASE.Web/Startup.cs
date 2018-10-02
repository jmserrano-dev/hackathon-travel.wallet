using BASE.Application.Client.Cards;
using BASE.Application.Client.Flights;
using BASE.Application.Client.Notifications;
using BASE.Application.Client.PointsOfInterest;
using BASE.Application.Client.Recommendations.Airports;
using BASE.Application.Client.Recommendations.Events;
using BASE.Application.Client.Recommendations.Hotels;
using BASE.Data;
using MediatR;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Swashbuckle.AspNetCore.Swagger;

namespace BASE.Web
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddScoped<IMediator, Mediator>();
            services.AddMediatR(typeof(GetCards).Assembly);
            services.AddMediatR(typeof(GetFlights).Assembly);
            services.AddMediatR(typeof(GetNotifications).Assembly);
            services.AddMediatR(typeof(GetPointsOfInterest).Assembly);
            services.AddMediatR(typeof(GetEvents).Assembly);
            services.AddMediatR(typeof(GetHotels).Assembly);
            services.AddMediatR(typeof(GetAirports).Assembly);
            services.AddEntityFrameworkSqlServer();
            var connectionstring = Configuration.GetValue<string>("ConnectionStrings:DefaultConnection");
            services.AddDbContext<BaseContext>(o =>
             {
                 o.UseSqlServer(connectionstring, sqlServerOptions => sqlServerOptions.MigrationsAssembly("BASE.Data"));
                 o.ConfigureWarnings(warnings => warnings.Throw(RelationalEventId.QueryClientEvaluationWarning));
             });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "My API", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseSwagger();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
