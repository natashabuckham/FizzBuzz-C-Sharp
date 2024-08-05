// See https://aka.ms/new-console-template for more information

for (var counter = 1; counter < 2432; counter++)
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
