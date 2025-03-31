using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.Property
{
  [Table("Buildings")]
  public class Building
  {
    [Key]
    public int BuildingID { get; set; }

    public int? PropertyID { get; set; }

    [MaxLength(100)]
    public string BuildingName { get; set; }

    [MaxLength(20)]
    public string BuildingNumber { get; set; }

    [ForeignKey("PropertyID")]
    public virtual Property Property { get; set; }
  }
}
