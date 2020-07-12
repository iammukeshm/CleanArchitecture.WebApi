using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IEmailService
    {
        Task SendPlainEmailAsync(string to, string subject, string body, string from = null);
    }
}
