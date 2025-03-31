using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.Property
{
  [Table("Units")]
  public class Unit
  {
    [Key]
    public int UnitID { get; set; }

    public int? BuildingID { get; set; }

    [MaxLength(20)]
    public string UnitNumber { get; set; }

    public decimal? UnitSize { get; set; }

    [MaxLength(50)]
    public string UnitType { get; set; }

    public decimal? RentAmount { get; set; }

    [MaxLength(20)]
    public string OccupancyStatus { get; set; }
  }
}
