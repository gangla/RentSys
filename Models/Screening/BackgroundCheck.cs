using RentSys.Models.UserManagement;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.Screening
{
  [Table("BackgroundChecks")]
  public class BackgroundCheck
  {
    [Key]
    public int BackgroundCheckID { get; set; }

    public int? TenantID { get; set; }

    public DateTime? CheckDate { get; set; }

    [MaxLength(50)]
    public string CheckType { get; set; }

    [MaxLength(20)]
    public string CheckStatus { get; set; }

    public string CheckResult { get; set; }

    [ForeignKey("TenantID")]
    public virtual Tenant Tenant { get; set; }
  }
}
