using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogEf.Models;
[Table("User")]
public class User
{
    [Key]//Primary Key
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }
    public string Bio { get; set; }
    public string Image { get; set; }
    public string Slug { get; set; }
    public List<Role> Role { get; set; }

    public User()
    {
        Role = new List<Role>();
    }
}