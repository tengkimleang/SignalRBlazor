
using Microsoft.AspNetCore.Http.Features;
using MinimalAPI.Interface;
using MinimalAPI.Models;
using MinimalAPI.Repository;
using Org.BouncyCastle.Asn1.Ocsp;

namespace MinimalAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddAuthorization();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var emailConfig = builder.Configuration
            .GetSection("EmailConfiguration")
            .Get<EmailConfiguration>();
            builder.Services.Configure<FormOptions>(o => {
                o.ValueLengthLimit = int.MaxValue;
                o.MultipartBodyLengthLimit = int.MaxValue;
                o.MemoryBufferThreshold = int.MaxValue;
            });
            builder.Services.AddSingleton(emailConfig);
            builder.Services.AddScoped<IEmailSender, EmailSender>();

            var app = builder.Build();
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
            app.UseHttpsRedirection();
            app.UseAuthorization();

            var summaries = new[]
            {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            app.MapPost("/weatherforecast", (HttpContext httpContext) =>
            {
                var files = httpContext.Request.Form.Files.Any() ? httpContext.Request.Form.Files : new FormFileCollection();
                IEmailSender emailSender = new EmailSender(emailConfig);
                var message = new Message(new string[] { "nonametotell4@gmail.com" }, "Test email", "This is the content from our email.", null);
                emailSender.SendEmail(message);
                var forecast = Enumerable.Range(1, 5).Select(index =>
                    new WeatherForecast
                    {
                        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                        TemperatureC = Random.Shared.Next(-20, 55),
                        Summary = summaries[Random.Shared.Next(summaries.Length)]
                    })
                    .ToArray();
                return forecast;
            })
            .WithName("GetWeatherForecast")
            .WithOpenApi();

            app.Run();
        }
    }
}