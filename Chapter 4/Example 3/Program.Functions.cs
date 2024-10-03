
internal partial class Program
{
    static decimal CalculateTax(decimal amount, string twoLetterRegionCode)
    {
        decimal rate = 0.0M;
        switch (twoLetterRegionCode)
        {
            case "CH": 
                rate = 0.08M;
                break;
            case "DK": 
            case "NO": 
                rate = 0.25M;
                break;
            case "GB": 
            case "FR": 
                rate = 0.2M;
                break;
            case "HU": 
                rate = 0.27M;
                break;
            case "OR": 
            case "AK": 
            case "MT": 
                rate = 0.0M;
                break;
            case "ND": 
            case "WI": 
            case "ME": 
            case "VA": 
                rate = 0.05M;
                break;
            case "CA": 
                rate = 0.0825M;
                break;
            default: 
                rate = 0.06M;
                break;
        }
        return amount * rate;
    }
    /// <summary>
    /// Pass a 32-bit integer and it will be converted to ordinal form
    /// </summary>
    /// <param name="number">Number as a cardinal value e.g. 1, 2 , 3 and so on</param>
    /// <returns>Number as ordinal value e.g. 1st, 2nd, 3rd, and so on.</returns>
    static string CardinalToOrdinal(int number)
    {
        int lastTwoDigits = number % 100;
        switch (lastTwoDigits)
        {
            case 11: 
            case 12:
            case 13:
                return $"{number:N0}th";
            default:
                int lastDigit = number % 10;
                string suffix = lastDigit switch
                {
                    1 => "st",
                    2 => "nd",
                    3 => "rd",
                    _ => "th"
                };
                return $"{number:N0}{suffix}";
        }
    }

    static void RunCardinalToOrdinal()
    {
        for (int number = 1; number <= 1500; number++)
        {
            Write($"{CardinalToOrdinal(number)} ");
        }
        WriteLine();
    }
}
        

