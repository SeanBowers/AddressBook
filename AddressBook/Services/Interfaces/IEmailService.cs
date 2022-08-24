using AddressBook.Models;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace AddressBook.Services.Interfaces
{
    public interface IEmailService : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage);

    }
}
