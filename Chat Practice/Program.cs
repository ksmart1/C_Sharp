namespace Chat_Practice;
class Program
{
    static void Main(string[] args)
    {
        // Factorial calculator for C# practice.
        //1. Prompt the user to enter a non-negative integer.
        //2. Check if the input is valid. If not, display an error message
        // and ask the user to provide input again.
        //3. Calculate and print the factorial of the entered integer.
        // Factorial of 0 is 1 and the factorial of 1 is also 1.
        bool goAgain = true;

        do
        {
            Factorial factorial = new Factorial();
            Console.Write("Please enter a non-negative integer (999 to quit): ");
            factorial.Integer = Convert.ToInt32(Console.ReadLine());
            int userInt = factorial.Integer;

            if (factorial.Integer >= 0)
            {
                if (factorial.Integer == 999)
                {
                    //goAgain = false;
                    break;
                }
                else
                {
                    Console.WriteLine("You entered: {0}", factorial.Integer);
                    int result = GetFactorialOfInt(factorial);
                    Console.WriteLine("Factorial of {0} is {1}", userInt, result);
                } 
            }
            else
            {
                Console.WriteLine("You have problems following directions.");
                //goAgain = false;
            }
        }
        while (goAgain);
    }

    public static int GetFactorialOfInt(Factorial factorial)
    {
        int userInt = factorial.Integer;
        int result = 0;

        if (userInt == 0 || userInt == 1)
        {
            result = 1;
        }
        else
        {
            //int i = 1;
            int remaining = userInt - 1;
            Console.WriteLine("Remaining = {0} outside of while loop.", remaining);
            int prod = userInt * remaining;
            if (userInt > 2)
            {
                remaining--;
            }
            

            while (remaining > 0)
            {
                if (remaining >= 1)
                {
                    Console.WriteLine("Remaining before if multiplication and prod: {0}, {1}", remaining, prod);
                    prod = prod * remaining;
                    result = prod;
                    remaining -= 1;
                    Console.WriteLine("(After) Result = {0} and remaining after if multiplication= {1}.", result, remaining);
                }
                else
                {
                    result = prod;
                    Console.WriteLine("Result else = {0}", result);
                }
            }
        }

        return result;
    }
}

