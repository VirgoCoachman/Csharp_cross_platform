using static System.Console;

WriteLine("Before parsing");
Write("What is your age? ");
string? input = ReadLine();

try
{
    int age = int.Parse(input);
    WriteLine($"You are {age} years old.");
}
catch (FormatException ex)
{
    WriteLine("The age you entered is not a valid number format.");
}
catch (OverflowException ex)
{
    WriteLine("Your age is a valid number format but is is either too big or too small.");
}
catch (Exception ex)
{
    WriteLine($"{ex.GetType()} says {ex.Message}");
}
WriteLine("After parsing");

Write("Enter an amount: ");
string? amount = ReadLine();

try
{
    decimal amountValue = decimal.Parse(amount);
}
catch (FormatException) when (amount.Contains("$"))
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amount must only contain digits!");
}
