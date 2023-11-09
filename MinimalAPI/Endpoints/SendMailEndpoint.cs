using FastEndpoints;
using Microsoft.AspNetCore.Authorization;
using MinimalAPI.Interface;
using MinimalAPI.Models;

namespace MinimalAPI.Endpoints
{
    [HttpGet("/test1"),AllowAnonymous]
    public class SendMailEndpoint : EndpointWithoutRequest<WeatherForecast>
    {
        private readonly IEmailSender emailSender;

        public SendMailEndpoint(IEmailSender emailSender)
        {
            this.emailSender = emailSender;
        }
        public override async Task HandleAsync(CancellationToken ct)
        {
            var message = new Message(new string[] { "nonametotell4@gmail.com" }, "Test email", "This is the content from our email.",null);
            emailSender.SendEmail(message);
            await SendOkAsync(null, ct);
        }
    }
}
