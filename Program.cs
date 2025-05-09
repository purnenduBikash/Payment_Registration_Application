using Microsoft.EntityFrameworkCore;
using Payment_Registration_Application.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var provider = builder.Services.BuildServiceProvider();
var config = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<PaymentRegistrationApplicationContext>(item => item.UseSqlServer(config.GetConnectionString("dbcs")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(options=>
options.WithOrigins("http://localhost:4200")
.AllowAnyMethod()
.AllowAnyHeader());//this is to make compartrible our web api with port 4200

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
