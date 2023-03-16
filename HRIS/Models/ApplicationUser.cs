using Microsoft.AspNetCore.Identity;

namespace HRIS.Models
{
    public class ApplicationUser:IdentityUser
    {
        public string FName { get; set; }
        public string UName { get; set; }
    }
}
