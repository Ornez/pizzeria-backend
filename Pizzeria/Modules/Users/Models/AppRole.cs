using Microsoft.AspNetCore.Identity;

namespace Pizzeria.Modules.Users.Models;

public class AppRole : IdentityRole<int>
{
    public ICollection<AppUserRole> UserRoles { get; set; }
}
