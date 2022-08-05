using AddressBook.Models;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace AddressBook.Services.Interfaces
{
    public interface IEmailService : IEmailSender
    {
        Task SendEmailAsync(AppUser appuser, List<Contact> contacts, EmailData emailData);
    }
}
