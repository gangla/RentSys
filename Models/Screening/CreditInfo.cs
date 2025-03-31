using RentSys.Models.UserManagement;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.Screening
{
  [Table("CreditInfo")]
  public class CreditInfo
  {
    [Key]
    public int CreditInfoID { get; set; }

    public int? TenantID { get; set; }

    public int? CreditScore { get; set; }

    public DateTime? CreditReportDate { get; set; }

    [MaxLength(50)]
    public string CreditBureau { get; set; }

    public byte[] CreditReportData { get; set; }

    [ForeignKey("TenantID")]
    public virtual Tenant Tenant { get; set; }
  }
}
