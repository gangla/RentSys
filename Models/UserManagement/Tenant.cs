using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using RentSys.Models.Screening;

namespace RentSys.Models.UserManagement
{
  [Table("Tenants")]
  public class Tenant
  {
    [Key]
    public int TenantID { get; set; }

    [MaxLength(20)]
    public string TenantCode { get; set; }

    [MaxLength(50)]
    public string FirstName { get; set; }

    [MaxLength(50)]
    public string LastName { get; set; }

    [MaxLength(100)]
    public string Email { get; set; }

    [MaxLength(20)]
    public string PhoneNumber { get; set; }

    public DateTime? DateOfBirth { get; set; }

    [MaxLength(10)]
    public string Gender { get; set; }

    [MaxLength(20)]
    public string MaritalStatus { get; set; }

    public int? NumberOfDependents { get; set; }

    [MaxLength(255)]
    public string Address { get; set; }

    [MaxLength(50)]
    public string City { get; set; }

    [MaxLength(50)]
    public string StateProvince { get; set; }

    [MaxLength(20)]
    public string ZipCode { get; set; }

    [MaxLength(50)]
    public string Country { get; set; }

    [MaxLength(20)]
    public string AlternativePhoneNumber { get; set; }

    [MaxLength(50)]
    public string EmergencyContactName { get; set; }

    [MaxLength(20)]
    public string EmergencyContactPhoneNumber { get; set; }

    [Column(TypeName = "decimal(10, 2)")]
    public decimal? Income { get; set; }

    [MaxLength(50)]
    public string Occupation { get; set; }

    [MaxLength(100)]
    public string Employer { get; set; }

    [MaxLength(255)]
    public string PreviousAddress { get; set; }

    [MaxLength(100)]
    public string PreviousLandlord { get; set; }

    [MaxLength(255)]
    public string ReasonForMoving { get; set; }

    [MaxLength(20)]
    public string SocialSecurityNumber { get; set; }

    [MaxLength(20)]
    public string DriverLicenseNumber { get; set; }

    [MaxLength(20)]
    public string PassportNumber { get; set; }

    [MaxLength(50)]
    public string PetPreferences { get; set; }

    [MaxLength(50)]
    public string SmokingPreferences { get; set; }

    [MaxLength(50)]
    public string ParkingRequirements { get; set; }
    public virtual ICollection<BackgroundCheck> BackgroundChecks { get; set; } // Navigation property
  }
}
