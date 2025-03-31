namespace RentSys.Models.Payments
{
  public class PaymentMethod
  {
    public int PaymentMethodId { get; set; } // Primary key
    public string MethodName { get; set; } // Name of the payment method (e.g., 'CardPayment', 'MobileMoney', 'BankTransfer')

    // Navigation property for related transactions
    public ICollection<Transaction> Transactions { get; set; }
  }

}
