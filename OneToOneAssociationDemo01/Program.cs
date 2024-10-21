CreditCard creditCard = new CreditCard("1111", new DateTime(2024, 10, 31), 50000);

Customer customer = new Customer("Md. Saddam Hossain", 18, 30000, creditCard);

if (customer.IsEligibleForCreditCard())
{
    Console.WriteLine($"{customer.Name} is eligible for a credit card.");

    if (creditCard.IsCardValid())
    {
        Console.WriteLine("The credit card is valid.");

        PerformPurchase(creditCard, 50000);
    }
    else
    {
        Console.WriteLine("The credit card is expired.");
    }
}
else
{
    Console.WriteLine($"{customer.Name} is not eligible for credit card.");
}


void PerformPurchase(CreditCard creditCard, double purchaseAmount)
{
    try
    {
        creditCard.MakePurchase(purchaseAmount);
        Console.WriteLine($"Purchase successful. Available credit: {creditCard.AvailableCredit}");
    }
    catch (InvalidOperationException ex)
    {
        Console.WriteLine(ex.Message);
    }

    Console.WriteLine($"Outstanding balance: {creditCard.GetOutstandingBalance()}");
}