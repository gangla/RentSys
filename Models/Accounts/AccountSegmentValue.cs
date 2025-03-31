namespace RentSys.Models.Accounts
{
  public class AccountSegmentValue
  {
    public int AccountSegmentValueID { get; set; }
    public int AccountID { get; set; }
    public int SegmentID { get; set; }
    public string SegmentValue { get; set; }

    public Account Account { get; set; }
    public AccountSegment AccountSegment { get; set; }
  }
}
