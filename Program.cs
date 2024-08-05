Console.WriteLine("How many numbers do you want to print?");
string? userNumber = Console.ReadLine();

int maxNumber = 0;

try
{
    maxNumber = Convert.ToInt32(userNumber);
    if (maxNumber < Int32.MaxValue)
    {
        Console.WriteLine($"You want to print {maxNumber} numbers.");
    }
    else{
        Console.WriteLine("This number is too big.");
    }
}
catch (FormatException)
{
    Console.WriteLine("Please enter a number only.");
}
catch (OverflowException)
{
    Console.WriteLine("This number is too big.");
}

for (var counter = 1; counter < maxNumber; counter++)
{
    string output = "";

    static Boolean IsDivisor(int counter, int divisor)
    {
        return counter % divisor == 0;
    }

    static void UpdateOutput(int counter, int[] divisor, string[] word, ref string refArgument)
    {
        for (int i = 0; i < divisor.Length; i++)
        {
            if (IsDivisor(counter, divisor[i]))
            {
                refArgument += word[i];
            }
        }
    }

    if (IsDivisor(counter, 11))
    {
        if (IsDivisor(counter, 17))
        {
            UpdateOutput(counter, [11, 13], ["Bong", "Fezz"], ref output);
        }
        else 
        {
            UpdateOutput(counter, [13, 11], ["Fezz", "Bong"], ref output);
        }
    }
    else
    {
        if (IsDivisor(counter, 17))
        {
            UpdateOutput(counter, [7, 5, 13, 3], ["Bang", "Buzz", "Fezz", "Fizz"], ref output);
        }
        else
        {
            UpdateOutput(counter, [3, 13, 5, 7], ["Fizz", "Fezz", "Buzz", "Bang"], ref output);
        }
    } 

    if (output == "")
    {
        Console.WriteLine(counter);
    }
    else
    {
        Console.WriteLine(output);
    }
}
