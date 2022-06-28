using Microsoft.AspNetCore.Identity;
using WebApplication18_Authentication_Autorization.Models.Entities.Concrete;

namespace WebApplication18_Authentication_Autorization.Models.DTOs
{
    public class AssignedRoleDTO
    {
        public IdentityRole Role { get; set; }

        public IEnumerable<AppUser> HasRole { get; set; }

        public IEnumerable<AppUser> HasNotRole { get; set; }

        public string RoleName { get; set; }

        public string[] AddIds { get; set; }

        public string[] DeleteIds { get; set; }
    }
}
