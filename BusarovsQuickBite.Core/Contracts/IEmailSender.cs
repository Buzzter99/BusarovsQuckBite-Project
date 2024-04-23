namespace BusarovsQuickBite.Core.Contracts
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject,string fromEmail, string htmlMessage);
    }
}
