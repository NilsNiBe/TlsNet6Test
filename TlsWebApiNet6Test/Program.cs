using System.Net;
using System.Runtime.InteropServices;

Console.WriteLine(RuntimeInformation.FrameworkDescription);
ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls13;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
