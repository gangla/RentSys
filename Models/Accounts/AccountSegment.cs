namespace RentSys.Models.Accounts
{
  public class AccountSegment
  {
    public int SegmentID { get; set; }
    public string SegmentName { get; set; }
    public string SegmentDescription { get; set; }

    public ICollection<AccountSegmentValue> AccountSegmentValues { get; set; }
  }
}
