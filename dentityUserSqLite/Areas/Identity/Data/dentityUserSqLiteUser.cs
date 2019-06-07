using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace dentityUserSqLite.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the dentityUserSqLiteUser class
    public class dentityUserSqLiteUser : IdentityUser
    {
        public bool IsAdmin { get; set; }
        public string DataEventRecordsRole { get; set; }
        public string SecuredFilesRole { get; set; }

        public DateTime AccountExpires { get; set; }
    }
}
