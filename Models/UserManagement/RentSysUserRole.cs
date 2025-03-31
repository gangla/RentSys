using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysUserRoles")]
  public class RentSysUserRole
  {
    [Key, Column(Order = 0)]
    [MaxLength(128)]
    public string UserId { get; set; }

    [Key, Column(Order = 1)]
    [MaxLength(128)]
    public string RoleId { get; set; }

    public int TenantId { get; set; }
  }
}
