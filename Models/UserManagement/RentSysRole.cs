using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("RentSysRoles")]
  public class RentSysRole
  {
    [Key]
    [MaxLength(128)]
    public string Id { get; set; }

    [Required]
    public int TenantId { get; set; }

    [MaxLength(128)]
    public string Name { get; set; }

    [MaxLength(128)]
    public string NormalizedName { get; set; }

    public string ConcurrencyStamp { get; set; }
  }
}
