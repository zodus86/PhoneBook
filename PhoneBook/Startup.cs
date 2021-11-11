using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PhoneBook.Data;
using PhoneBook.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook
{
    public class Startup
    {
        private IConfigurationRoot _confstring;
        public Startup(IHostingEnvironment hostEnv)
        {
            _confstring = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsetting.json").Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(_confstring.GetConnectionString("DefaultConnection")));
            //services.AddTransient<IAllPhoneBook, MockPhoneBook>();
            services.AddTransient<IAllPhoneBook, PhoneBookRepository>();
            services.AddMvc();
            
        }


        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {

            app.UseDeveloperExceptionPage();
            app.UseStaticFiles();
            app.UseStatusCodePages();
           // app.UseMvcWithDefaultRoute();
            app.UseMvc(

               r =>
               {
                   r.MapRoute(
                       name: "default",
                       template: "{controller=PhoneBooks}/{action=List}"

                       );
               });

            using (var scope = app.ApplicationServices.CreateScope())
            {
                AppDbContext context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                DBObjects.Initial(context);
            }

           
        }
    }
}
