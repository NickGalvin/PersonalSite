using Amazon.S3;
using Amazon.S3.Transfer;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Blazor.Server;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.ResponseCompression;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using PersonalSite.Server.Data;
using PersonalSite.Server.Services;
using PersonalSite.Shared;
using System.Linq;
using System.Net.Mime;
using PayPal.Api;

namespace PersonalSite.Server
{
    public class Startup
    {
        public Startup(IConfiguration config)
        {
            Configuration = config;
            Config = config.Get<SiteConfig>();
        }

        IConfiguration Configuration { get; }
        SiteConfig Config { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
            services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(opt =>
                {
                    var signingKey = Convert.FromBase64String(Config.JWT.SigningSecret);
                    opt.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = false,
                        ValidateAudience = false,
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(signingKey)
                    };
                });
            Config = config;
        }

        private IConfiguration Config { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc()
                    .AddJsonOptions(opt => opt.SerializerSettings.ContractResolver = new DefaultContractResolver()) //Use PascalCase in responses instead of camelCase
                    .AddJsonOptions(opt => opt.SerializerSettings.NullValueHandling = NullValueHandling.Ignore);

            //services.AddAuthentication()
            //            .AddMicrosoftAccount(microsoftOptions => { })
            //            .AddGoogle(googleOptions => { })
            //            .AddTwitter(twitterOptions => { })
            //            .AddFacebook(facebookOptions => {
            //                facebookOptions.AppId = "";
            //                facebookOptions.AppSecret = "";
            //                facebookOptions.AuthorizationEndpoint = "";
            //                facebookOptions.ClientId = "";
            //                });

            //services.AddDbContext<ApplicationDbContext>(options =>
            //                options.UseSqlServer(
            //                    Configuration.GetConnectionString("DefaultConnection")));
            //services.AddDefaultIdentity<IdentityUser>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();



            //services.AddResponseCompression(options =>
            //{
            //    options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
            //    {
            //        MediaTypeNames.Application.Octet,
            //        WasmMediaTypeNames.Application.Wasm,
            //    });
            //});
            services.AddResponseCompression(options =>
            {
                options.MimeTypes = ResponseCompressionDefaults.MimeTypes.Concat(new[]
                {
                    MediaTypeNames.Application.Octet,
                    WasmMediaTypeNames.Application.Wasm,
                });
            });

            //  services.Configure<IISOptions>(o => o.AutomaticAuthentication = true);
            services.AddDefaultAWSOptions(Config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>();
            services.AddEntityFrameworkInMemoryDatabase();

            services.AddDbContext<PersonalSiteDbContext>();
            services.AddTransient<InquiryService>();
            services.AddDbContext<SiteDbContext>();
            services.AddTransient<UserService>();
            services.AddSingleton<SiteConfig>(Config);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseResponseCompression();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseAuthentication();
            app.UseMvc();
            app.UseBlazor<Client.Program>();
        }
    }
}
