using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PersonalSite.Server.Data;
using PersonalSite.Server.Services;
using System.Linq;
using System.Net.Mime;

namespace PersonalSite.Server
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services, IConfiguration config)
        {
            services.AddMvc();
            services.AddAuthentication();

            services.AddIdentity();
                //.AddJsonOptions(opt => opt.SerializerSettings.ContractResolver = new DefaultContractResolver()) //Use PascalCase in responses instead of camelCase
                //.AddJsonOptions(opt => opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore);

            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
                });
            });
            //  services.Configure<IISOptions>(o => o.AutomaticAuthentication = true);
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>();
            services.AddTransient<RsvpService>();
            services.AddEntityFrameworkInMemoryDatabase();
            services.AddDbContext<RsvpDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
            app.UseBlazor<Client.Program>();
        }
    }
}
