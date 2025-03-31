namespace RentSys.Models.Accounts
{
  public class Account
  {
    public int AccountID { get; set; }
    public string AccountCode { get; set; }
    public string AccountName { get; set; }
    public string AccountType { get; set; }
    public string AccountDescription { get; set; }
    public int? ParentAccountID { get; set; }
    public bool IsActive { get; set; } = true;
    public char? NormalBalance { get; set; }

    public ICollection<AccountSegmentValue> AccountSegmentValues { get; set; }
  }
}
