using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AmazingChocolate.DomainModel.Interfaces.Repositories;
using AmazingChocolate.Infrastructure.DataAccess.Contexts;
using AmazingChocolate.Infrastructure.DataAccess.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace AmazingChocolate
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDistributedMemoryCache();
            services.AddSession();

            services.AddDbContext<AmazingChocolateContext>(options => options.UseSqlServer(AmazingChocolate.Infrastructure.DataAccess.Properties.Resources.
                ResourceManager.GetString("DbConnectionString")));
            services.AddTransient<IProdutoRepository, ProdutoRepository>();
            services.AddTransient<IClienteRepository, ClienteRepository>();
            services.AddTransient<IPedidoRepository, PedidoRepository>();
            
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Wellcome}/{id?}");
            });
        }
    }
}
