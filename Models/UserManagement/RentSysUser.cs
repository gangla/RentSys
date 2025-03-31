using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysUsers")]
  public class RentSysUser
  {
    [Key]
    [MaxLength(128)]
    public string Id { get; set; }

    public int TenantId { get; set; }

    [MaxLength(128)]
    public string UserName { get; set; }

    [MaxLength(128)]
    public string NormalizedUserName { get; set; }

    [MaxLength(128)]
    public string Email { get; set; }

    [MaxLength(128)]
    public string NormalizedEmail { get; set; }

    public bool EmailConfirmed { get; set; }

    public string PasswordHash { get; set; }

    public string SecurityStamp { get; set; }

    public string ConcurrencyStamp { get; set; }

    public string PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTimeOffset? LockoutEnd { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    [MaxLength(128)]
    public string ProfileType { get; set; }

    [MaxLength(128)]
    public string CountryId { get; set; }

    [MaxLength(128)]
    public string Region { get; set; }

    [MaxLength(128)]
    public string Ward { get; set; }
  }
}
