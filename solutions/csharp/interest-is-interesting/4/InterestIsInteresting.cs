static class SavingsAccount
{
    public static float InterestRate(decimal balance) => balance switch
        {
            < 0 => (float)3.213,
            < 1000 => (float)0.5,
            < 5000 => (float)1.621,
            _ => (float)2.475
        };
        

    public static decimal Interest(decimal balance) => balance * (decimal)(InterestRate(balance) / 100);
    
    public static decimal AnnualBalanceUpdate(decimal balance) => Interest(balance) + balance;
    
    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        if(balance == targetBalance || balance > targetBalance)
        {
            return years;
        }
        else
        {
            do
            {
                balance = AnnualBalanceUpdate(balance);
                years += 1;
            } while (balance <= targetBalance);
            return years;
        }
    }
}
