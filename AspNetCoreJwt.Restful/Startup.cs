using System;
using System.IdentityModel.Tokens.Jwt;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

namespace AspNetCoreJwt.Restful
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
            services.AddControllers();
            services.AddMemoryCache();

            // JWT 认证授权
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidIssuer = Configuration["Jwt:Issuer"],
                    ValidAudience = Configuration["Jwt:Audience"],
                    ValidateAudience = true,
                    ValidateLifetime = true, //是否验证失效时间
                    ClockSkew = TimeSpan.FromSeconds(5), // 允许5秒偏差,
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:SecurityKey"]))
                };
                options.Events = new JwtBearerEvents
                {
                    OnTokenValidated = (context) =>
                        {
                            var jtiClaims = context.Principal.Claims.FirstOrDefault(item => item.Type == JwtRegisteredClaimNames.Jti);

                            var cache = context.HttpContext.RequestServices.GetService<IMemoryCache>();
                            if (cache.TryGetValue(jtiClaims.Value, out object value))   // 缓存中存在，说明token 已注销，已失效
                            {
                                context.Fail("授权已失效");
                            }
                            return Task.CompletedTask;
                        }
                };
            });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "NetCoreApi Jwt授权集成Swagger案列", Version = "v1" });

                /********XML文档注释*******/
                var basePath = Path.GetDirectoryName(typeof(Program).Assembly.Location);//获取应用程序所在目录（绝对，不受工作目录影响，建议采用此方法获取路径）
                var xmlPath = Path.Combine(basePath, "AspNetCoreJwt.Restful.xml");
                c.IncludeXmlComments(xmlPath, true);

                xmlPath = Path.Combine(basePath, "AspNetCoreJwt.RequestDTO.xml");
                c.IncludeXmlComments(xmlPath);

                xmlPath = Path.Combine(basePath, "AspNetCoreJwt.ResponseDTO.xml");
                c.IncludeXmlComments(xmlPath);

                /********JWT 授权请求头*******/
                var security = new OpenApiSecurityRequirement();
                var scheme = new OpenApiSecurityScheme
                {
                    Reference = new OpenApiReference
                    {
                        Id = "jwt",
                        Type = ReferenceType.SecurityScheme
                    },
                    Description = "json web token授权请求头，在下方输入Bearer {token} 即可，注意两者之间有空格",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey
                };
                security.Add(scheme, new string[] { });
                c.AddSecurityRequirement(security);
                c.AddSecurityDefinition("jwt", scheme);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "测试jwt授权");
            });

            app.UseAuthentication();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
