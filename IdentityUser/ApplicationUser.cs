using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityUser
{
    public class ApplicationUser : Microsoft.AspNetCore.Identity.IdentityUser
    {
        public bool IsAdmin { get; set; }
        public string DataEventRecordsRole { get; set; }
        public string SecuredFilesRole { get; set; }

        public DateTime AccountExpires { get; set; }
    }
}
