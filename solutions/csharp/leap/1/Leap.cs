public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        
        bool divisibleBy4 = year % 4 == 0;
        bool divisibleBy100 = year % 100 == 0;
        bool divisibleBy400 = year % 400 == 0;
        if (divisibleBy4 && !divisibleBy100)
        {
            return true;
        }
        else if (divisibleBy100 && divisibleBy400)
        {
            return true;
        }
        else
        {        
            return false;
        }
        
    }
}