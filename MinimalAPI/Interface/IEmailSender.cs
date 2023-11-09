using MinimalAPI.Models;

namespace MinimalAPI.Interface
{
    public interface IEmailSender
    {
        void SendEmail(Message message);
    }
}
