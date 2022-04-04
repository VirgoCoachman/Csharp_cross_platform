using static System.Console;

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0)
    {
        Write("Fizz");
    }
    if (i % 5 == 0)
    {
        Write("Buzz");
    }
    if (i % 3 != 0 && i % 5 != 0)
    {
        Write(i);
    }
    if (i < 100)
    {
        Write(", ");
    }
    if (i % 10 == 0)
    {
        WriteLine();
    }
}
