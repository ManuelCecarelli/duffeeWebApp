using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities;

public abstract class User
{
    public int Id { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Name { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string LastName { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Password { get; set; }

    [Column(TypeName = "nvarchar(100)")]
    public string Email { get; set; }

    [Required]
    [Column(TypeName = "nvarchar(100)")]
    public string UserName { get; set; }

    protected User(string name, string lastName, string password, string email, string userName)
    {
        Name = name;
        LastName = lastName;
        Password = password;
        Email = email;
        UserName = userName;
    }
}
