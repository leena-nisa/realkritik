using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;
public class User
{
    public int Id { get; set; } // Primary key
    public int Uid { get; set; } 
    [Required]
    public string Name { get; set; }
    [Required]
    [EmailAddress]
    public string Email { get; set; }
    [Required]
    public string Username { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}

