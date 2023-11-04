using DataLayer;
using DataLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using DataLayer.Repository;
using BusinessLayer.IService;
using BusinessLayer.Service;
using HouseBooking.Extansions;
using HouseBooking.Middleware;
using Microsoft.AspNetCore.Builder;
using HouseBooking.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseContext>(options =>
options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                    ));

builder.Services.AddRouting();


// Add services to the container.

builder.Services.AddScoped<IApartmentRepository, ApartmentRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IOptionsRepository, OptionsRepository>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IBuildingImageRepository, BuildingImageRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();
builder.Services.AddScoped<IScoringRepository, ScoringRepository>();
builder.Services.AddScoped<IApartmentImageRepository, ApartmentImageRepository>();
builder.Services.AddScoped<ITranslationRepository, TranslationRepository>();

builder.Services.AddTransient<IApartmentService, ApartmentService>();
builder.Services.AddTransient<IAddressService, AddressService>();
builder.Services.AddTransient<IScoringService, ScoringService>();
builder.Services.AddTransient<IOptionsService, OptionsService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddTransient<IApplicationUserService, ApplicationUserService>();
builder.Services.AddTransient<IClientService, ClientService>();
builder.Services.AddTransient<IBuildingService, BuildingService>();
builder.Services.AddTransient<IApartmentImageService, ApartmentImageService>();
builder.Services.AddTransient<IBuildingImageService, BuildingImageService>();
builder.Services.AddTransient<IBookingService, BookingService>();
builder.Services.AddTransient<ITranslationService, TranslationService>();



builder.Services.AddAutoMapperService();
builder.Services.AddIdentityServer();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerServices();


var app = builder.Build();

var routeBuilder = new RouteBuilder(app);

routeBuilder.MapRoute("controller", async context =>
{
    await context.Response.WriteAsync("{controller} template");
});

routeBuilder.MapRoute("{controller}/{action}", async context =>
{
    await context.Response.WriteAsync("{controller}/{action} template");
});

app.UseCors("app-cors-policy");
app.UseRouting();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("v1/swagger.json", "House Booking");
    });
}


app.UseHttpsRedirection();


app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<TokenManagerMiddleware>();
//app.UseMiddleware<HttpGlobalExceptionFilter>();

app.MapControllers();

//app.MapControllerRoute(
//    name: "PaymentRoute",
//    pattern: "api/payments/{action}/{id?}", 
//    defaults: new { controller = "Payment", action = "AddPayment" });

app.Run();
