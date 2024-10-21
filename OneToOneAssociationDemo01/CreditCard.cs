namespace OneToOneAssociationDemo01;

public class CreditCard
{
    public string CardNumber { get; set; }

    public DateTime ExpirationDate { get; set; }

    public double CreditLimit { get; set; }

    public double AvailableCredit { get; set; }

    public CreditCard(string cardNumber, DateTime expirationDate, double creditLimit)
    {
        CardNumber = cardNumber;
        ExpirationDate = expirationDate;
        CreditLimit = creditLimit;
        AvailableCredit = creditLimit;
    }

    public bool IsCardValid()
    {
        return ExpirationDate > DateTime.Now;
    }

    public void MakePurchase(double purchaseAmount)
    {
        if (purchaseAmount > AvailableCredit)
        {
            throw new InvalidOperationException("Insufficient credit available.");
        }
        AvailableCredit -= purchaseAmount;
    }

    public double GetOutstandingBalance()
    {
        return CreditLimit - AvailableCredit;
    }
}