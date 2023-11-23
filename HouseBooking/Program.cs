using DataLayer;
using Microsoft.EntityFrameworkCore;
using HouseBooking.Extansions;
using HouseBooking.Middleware;
using HouseBooking.Filters;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication("Cookies")
    .AddCookie("Cookies");

builder.Services.AddAuthorization();

builder.Services.AddDbContext<DataBaseContext>(options =>
options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                    ));

//builder.Services.AddRouting();

builder.Services.AddAutoMapperService();
builder.Services.AddIdentityServer();
builder.Services.AddRepositoryServices(builder.Configuration);
builder.Services.AddBusinessLogicServices(builder.Configuration);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerServices();


var app = builder.Build();

var routeBuilder = new RouteBuilder(app);

//routeBuilder.MapRoute("controller", async context =>
//{
//    await context.Response.WriteAsync("{controller} template");
//});

//routeBuilder.MapRoute("{controller}/{action}", async context =>
//{
//    await context.Response.WriteAsync("{controller}/{action} template");
//});

app.UseCors("app-cors-policy");
app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("v1/swagger.json", "House Booking");
    });
}

app.UseMiddleware<TokenManagerMiddleware>();
//app.UseMiddleware<HttpGlobalExceptionFilter>();

//app.MapControllerRoute(
//    name: "PaymentRoute",
//    pattern: "api/payments/{action}/{id?}", 
//    defaults: new { controller = "Payment", action = "AddPayment" });

app.Run();
