using System.ComponentModel.DataAnnotations;

namespace Pizzeria.Modules.Users.DTOs;

public class RegisterDto
{
    [Required]
    public string Username { get; set; }
    [Required]
    public string Password { get; set; }
}
