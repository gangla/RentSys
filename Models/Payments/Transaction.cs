namespace RentSys.Models.Payments
{
  public class Transaction
  {
    public int Id { get; set; } // Primary key
    public string TransactionId { get; set; } // Unique identifier for the transaction
    public string CustomerId { get; set; } // Identifier for the customer
    public DateTime TransactionDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }

    // Foreign key to PaymentMethod
    public int PaymentMethodId { get; set; }
    public PaymentMethod PaymentMethod { get; set; } // Navigation property

    // Card Payment Details
    public string LastFourDigitsOfCard { get; set; } // Only store last four digits of card number
    public string CardType { get; set; } // E.g., 'Visa', 'MasterCard'

    // Mobile Money Payment Details
    public string MobileMoneyProvider { get; set; } // E.g., 'M-Pesa', 'Airtel Money'
    public string MobileMoneyPhoneNumber { get; set; } // Masked or partially stored

    // Bank Transfer Details
    public string BankName { get; set; }
    public string AccountNumber { get; set; } // Masked or partially stored
    public string TransactionReference { get; set; } // Reference from bank
  }


}
