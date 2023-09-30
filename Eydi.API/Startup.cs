using System.Text;
using AutoMapper;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using ES.API.Modules;
using ES.Core.DataAccess;
using ES.Core.Module;
using ES.Domain;
using ES.Service.AutoMapperConfig;
using Microsoft.OpenApi.Models;
using ES.Services.Contracts;
using ES.Services.Modules;
using ES.Service.Contracts;
using ES.Services.Modules.Calculate;
using System.ComponentModel;

namespace ES.API
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
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
            services.AddControllers().AddNewtonsoftJson();

            services.AddDbContext<DB>(options => options.UseSqlServer(Configuration.GetConnectionString("dbconn")));
            //  , b => b.UseOracleSQLCompatibility("11")));

            services.AddScoped<DbContext, DB>();

            services.AddAutoMapper(typeof(CommonProfile).Assembly);

            Extensions.Mapper = services.BuildServiceProvider().GetService<IMapper>();

            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("AppSettings:Secret").Value);
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Energy Solution Api",
                    Version = "v1.0.0",
                    Description = "Energy Solution  Api"
                });
            });

            services.AddHttpContextAccessor();
            services.AddScoped<CurrentUser>();
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IUserBiz, UserBiz>();
            services.AddScoped<IWindowsBiz, WindowsBiz>();
            services.AddScoped<ICalculateBiz, CalculateBiz>();
            services.AddScoped<IComponentsBiz,ComponentsBiz >();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //#if !DEBUG
            app.ConfigureExceptionHandler(/*logger*/);
            //#endif
            app.UseStaticFiles();
            //app.UseMiddleware<HttpLoggingMiddleware>();
            app.UseCors("CorsPolicy");
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tamin API");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
