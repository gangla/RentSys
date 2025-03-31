using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysUserLogins")]
  public class RentSysUserLogin
  {
    [Key, Column(Order = 0)]
    [MaxLength(128)]
    public string LoginProvider { get; set; }

    [Key, Column(Order = 1)]
    [MaxLength(128)]
    public string ProviderKey { get; set; }

    [MaxLength]
    public string ProviderDisplayName { get; set; }

    [Key, Column(Order = 2)]
    [MaxLength(128)]
    public string UserId { get; set; }

    public int TenantId { get; set; }
  }
}
