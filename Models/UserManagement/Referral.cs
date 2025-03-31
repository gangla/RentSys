using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.UserManagement
{
  [Table("Referrals")]
  public class Referral
  {
    [Key]
    public int ReferralID { get; set; }

    public int? TenantID { get; set; }

    [MaxLength(100)]
    public string ReferrerName { get; set; }

    [MaxLength(50)]
    public string ReferrerRelationship { get; set; }

    [MaxLength(100)]
    public string ContactInformation { get; set; }

    public DateTime? ReferralDate { get; set; }

    [MaxLength(20)]
    public string ReferralStatus { get; set; }

    public string ReferralComments { get; set; }
  }
}
