using GoldApi.Core.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoldApi.DataAccess.Entities;

[Table("user")]
public class User
{
    [Key]
    public Guid UserId { get; set; }
    
    [StringLength(100)]
    public string? Email { get; set; }
    public AuthenticationType AuthenticationType { get; set; }
    public DateTime CreationDate { get; set; }
    public bool IsActive { get; set; } = true;
}
