using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysUserClaims")]
  public class RentSysUserClaim
  {
    [Key]
    public int Id { get; set; }

    [Required]
    [MaxLength(128)]
    public string UserId { get; set; }

    [Required]
    public int TenantId { get; set; }

    [MaxLength]
    public string ClaimType { get; set; }

    [MaxLength]
    public string ClaimValue { get; set; }
  }
}
