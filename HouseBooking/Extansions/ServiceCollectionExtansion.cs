using AutoMapper;
using BusinessLayer.IService;
using BusinessLayer.Service;
using DataLayer;
using DataLayer.IRepository;
using DataLayer.Repository;
using Entity;
using HouseBooking.Filters;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Model;
using Model.Mapper;

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
                    mc.AddProfile(new TransaltionProfile());
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

        public static IServiceCollection AddBusinessLogicServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<JwtOptions>(configuration.GetSection("Jwt"));

            services.AddTransient<IApartmentService, ApartmentService>();
            services.AddTransient<IAddressService, AddressService>();
            services.AddTransient<IScoringService, ScoringService>();
            services.AddTransient<IOptionsService, OptionsService>();
            services.AddTransient<IPaymentService, PaymentService>();
            services.AddTransient<IApplicationUserService, ApplicationUserService>();
            services.AddTransient<IClientService, ClientService>();
            services.AddTransient<IBuildingService, BuildingService>();
            services.AddTransient<IApartmentImageService, ApartmentImageService>();
            services.AddTransient<IBuildingImageService, BuildingImageService>();
            services.AddTransient<IBookingService, BookingService>();
            services.AddTransient<ITranslationService, TranslationService>();

            return services;
        }

        public static IServiceCollection AddRepositoryServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<DataBaseContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"))
           );

            // Add services to the container.

            services.AddScoped<IApartmentRepository, ApartmentRepository>();
            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<IOptionsRepository, OptionsRepository>();
            services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
            services.AddScoped<IPaymentRepository, PaymentRepository>();
            services.AddScoped<IBookingRepository, BookingRepository>();
            services.AddScoped<IAddressRepository, AddressRepository>();
            services.AddScoped<IBuildingImageRepository, BuildingImageRepository>();
            services.AddScoped<IBuildingRepository, BuildingRepository>();
            services.AddScoped<IScoringRepository, ScoringRepository>();
            services.AddScoped<IApartmentImageRepository, ApartmentImageRepository>();
            services.AddScoped<ITranslationRepository, TranslationRepository>();

            return services;
        }
    }
}
