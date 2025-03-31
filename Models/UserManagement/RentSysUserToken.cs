using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysUserTokens")]
  public class RentSysUserToken
  {
    [Key, Column(Order = 0)]
    [MaxLength(128)]
    public string UserId { get; set; }

    [Key, Column(Order = 1)]
    [MaxLength(128)]
    public string LoginProvider { get; set; }

    [Key, Column(Order = 2)]
    [MaxLength(128)]
    public string Name { get; set; }

    public string Value { get; set; }

    [Required]
    public int TenantId { get; set; }
  }
}
