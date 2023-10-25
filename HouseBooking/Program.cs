using DataLayer;
using DataLayer.IRepository;
using Microsoft.EntityFrameworkCore;
using DataLayer.Repository;
using BusinessLayer.IService;
using BusinessLayer.Service;
using Entity;
using HouseBooking.Extansions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataBaseContext>(options =>
options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                    ));
// Add services to the container.

builder.Services.AddScoped<IApartmentRepository, ApartmentRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IOptionsRepository, OptionsRepository>();
builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
builder.Services.AddScoped<IPaymentRepository, PaymentRepository>();

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
