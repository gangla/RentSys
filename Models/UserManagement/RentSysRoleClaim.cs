using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysRoleClaims")]
  public class RentSysRoleClaim
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(128)]
    public string RoleId { get; set; }

    [Required]
    public int TenantId { get; set; }

    [MaxLength]
    public string ClaimType { get; set; }

    [MaxLength]
    public string ClaimValue { get; set; }
  }
}
