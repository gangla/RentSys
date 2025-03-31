using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.Property
{
  [Table("Properties")]
  public class Property
  {
    [Key]
    public int PropertyID { get; set; }

    [MaxLength(100)]
    public string PropertyName { get; set; }

    [MaxLength(255)]
    public string PropertyAddress { get; set; }

    [MaxLength(100)]
    public string City { get; set; }

    [MaxLength(100)]
    public string StateProvince { get; set; }

    [MaxLength(100)]
    public string Country { get; set; }

    [MaxLength(20)]
    public string PostalCode { get; set; }

    public decimal? Latitude { get; set; }

    public decimal? Longitude { get; set; }

    public int? OwnerID { get; set; }

    public string PropertyDescription { get; set; }

    public decimal? PropertySize { get; set; }

    public int? NumberOfUnits { get; set; }

    public decimal? MarketValue { get; set; }

    public decimal? PurchasePrice { get; set; }

    public decimal? EstimatedRentalIncome { get; set; }

    public virtual ICollection<Building> Buildings { get; set; } // Navigation property
  }
}
