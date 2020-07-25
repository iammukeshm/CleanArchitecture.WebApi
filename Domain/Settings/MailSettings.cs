using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Settings
{
    public class MailSettings
    {
        public string EmailFrom { get; set; }
        public string SmtpHost { get; set; }
        public int SmtpPort { get; set; }
        public string SmtpUser { get; set; }
        public string SmtpPass { get; set; }
        public string DisplayName { get; set; }
    }
}
