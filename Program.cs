// See https://aka.ms/new-console-template for more information

for (var counter = 1; counter < 101; counter++)
{
    string output = "";

    static void CheckDivisor(int counter, int divisor, string word, ref string refArgument)
    {
        if (counter % divisor == 0)
        {
            refArgument += word;
        }
    }

    if (output == "")
    {
        CheckDivisor(counter, 3, "Fizz", ref output);
        CheckDivisor(counter, 5, "Buzz", ref output);
        CheckDivisor(counter, 7, "Bang", ref output);
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
