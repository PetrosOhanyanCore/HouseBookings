using AutoMapper;
using DataLayer;
using Entity;
using HouseBooking.Filters;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Model.Mapper;
using System.Text;

namespace HouseBooking.Extansions
{
    public static class ServiceCollectionExtansion
    {
        public static IServiceCollection AddAutoMapperService(this IServiceCollection services)
        {
            var mappingConfig = new MapperConfiguration(

                mc =>
                {
                    mc.AddProfile(new ApartmentProfile());
                    mc.AddProfile(new ApplicationUserProfile());
                    mc.AddProfile(new OptionsProfile());
                    mc.AddProfile(new PaymentProfile());
                }
            );

            IMapper mapper = mappingConfig.CreateMapper();

            services.AddSingleton(mapper);
            return services;
        }

        public static IServiceCollection AddIdentityServer(this IServiceCollection services)
        {
            services.AddIdentity<ApplicationUser, IdentityRole>
                (c =>
                {
                    c.Password.RequireDigit = true;
                    c.Password.RequireLowercase = true;
                    c.Password.RequiredLength = 8;
                    c.Password.RequireNonAlphanumeric = true;
                    c.Password.RequireUppercase = true;
                })
                .AddEntityFrameworkStores<DataBaseContext>()
                .AddSignInManager<SignInManager<ApplicationUser>>()
                .AddDefaultTokenProviders();

            return services;

        }

        public static IServiceCollection AddSwaggerServices(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "HouseBookingAPI", Description = "Description for House Booking API", Version = "v1" });
                c.OperationFilter<AddAuthHeaderOperationFilter>();
                c.AddSecurityDefinition("bearer", new OpenApiSecurityScheme
                {
                    Description = "JWT Authorization header using the Bearer scheme. Example: \"Bearer {token}\"",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "bearer",
                    BearerFormat = "JWT"
                });
                

                c.DocumentFilter<SwaggerAddEnumDescriptionsFilter>();
            });

            return services;
        }

        public static IServiceCollection AddAuthenticationServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddAuthentication(auth =>
            {
                auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    ValidateLifetime = Convert.ToBoolean(configuration["Jwt:ValidateLifetime"]),
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"])),
                    RequireExpirationTime = true,
                    RequireSignedTokens = true,
                };
                options.RequireHttpsMetadata = true;
                options.SaveToken = true;
                options.ClaimsIssuer = configuration["Jwt:Issuer"];
            });

            return services;
        }
    }
}
