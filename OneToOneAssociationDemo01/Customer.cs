namespace OneToOneAssociationDemo01;

public class Customer
{
    private const int MinimumEligibleAge = 18;
    private const double MinimumMonthlyFinancialStanding = 30000;

    public string Name { get; set; }

    public int Age { get; set; }

    public double FinancialStanding { get; set; }

    public CreditCard CreditCard { get; set; }

    public Customer(string name, int age, double financialStanding, CreditCard creditCard)
    {
        Name = name;
        Age = age;
        FinancialStanding = financialStanding;
        CreditCard = creditCard;
    }

    public bool IsEligibleForCreditCard()
    {
        return Age >= MinimumEligibleAge && FinancialStanding >= MinimumMonthlyFinancialStanding;
    }
}
