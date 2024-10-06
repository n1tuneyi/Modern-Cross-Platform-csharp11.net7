
internal partial class Program
{
    static int Factorial(int number)
    {
        if (number < 0)
        {
            throw new ArgumentException(message:
            $"The factorial function is defined for non-negative only.Input: { number }", paramName: nameof(number));
        }
        else if (number == 0)
        {
            return 1;
        }
        else
        {
            checked
            {
                return number * Factorial(number - 1);
            }
        }
    }

    static int FibImperative(int term)
    {
        if (term == 1)
            return 0;
        if (term == 2)
            return 1;
        else
        {
            return FibImperative(term - 2) + FibImperative(term - 1);
        }
        
    }

    static void RunFactorial()
    {
        for (int i = -2; i <= 15; i++)
        {
            try
            {
                WriteLine($"{i}! = {Factorial(i):N0}");
            }
            catch (OverflowException)
            {
                WriteLine($"{i}! is too big for a 32-bit integer.");
            }
            catch (Exception ex)
            {
                WriteLine($"{i}! throws {ex.GetType()}: {ex.Message}");
            }
        }
    }

    static void RunFibImperative()
    {
        for(int i = 1;i <= 30;i++)
        {
            WriteLine("The {0} term of the Fibonacci Sequence is {1:N0}.", arg0: i, arg1: FibImperative(term: i));
        }
    }

}
        

