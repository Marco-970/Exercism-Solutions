static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return (float)3.213;
        }
        else if (balance >= 0 && balance < 1000)
        {
            return (float)0.5;
        }
        else if (balance >= 1000 && balance < 5000)
        {
            return (float)1.621;
        }
        else
        {
            return (float)2.475;
        }
    }
        

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
