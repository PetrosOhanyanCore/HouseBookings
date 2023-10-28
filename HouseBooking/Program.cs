using DataLayer;
using DataLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using DataLayer.Repository;
using BusinessLayer.IService;
using BusinessLayer.Service;
using HouseBooking.Extansions;
using Microsoft.AspNetCore.Builder;

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
builder.Services.AddScoped<IAddressRepository, AddressRepository>();
builder.Services.AddScoped<IBookingRepository, BookingRepository>();
builder.Services.AddScoped<IApartmentRepository, ApartmentRepository>();
builder.Services.AddScoped<IBuildingRepository, BuildingRepository>();

builder.Services.AddTransient<IApartmentService, ApartmentService>();
//builder.Services.AddTransient<IClientService, ClientService>();
builder.Services.AddTransient<IOptionsService, OptionsService>();
builder.Services.AddTransient<IPaymentService, PaymentService>();
builder.Services.AddTransient<IApplicationUserService, ApplicationUserService>();

builder.Services.AddTransient<IClientService, ClientService>();

builder.Services.AddAutoMapperService();
builder.Services.AddIdentityServer();


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


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

app.UseAuthorization();

app.MapControllers();

app.Run();
