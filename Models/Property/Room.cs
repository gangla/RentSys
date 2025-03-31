using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace RentSys.Models.Property
{
  [Table("Rooms")]
  public class Room
  {
    [Key]
    public int RoomID { get; set; }

    public int? UnitID { get; set; }

    [MaxLength(20)]
    public string RoomNumber { get; set; }

    [MaxLength(50)]
    public string RoomType { get; set; }

    public decimal? RoomSize { get; set; }

    public string RoomAmenities { get; set; }
  }
}
