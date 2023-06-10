using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CMS.Service.EmailServices
{
    public interface IEmailService
    {
        Task SendMailAsync(string to, string subject, string body);
    }
}