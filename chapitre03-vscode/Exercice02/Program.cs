using static System.Console;

object obj = 3;
int j = 4;

if (obj is int i)
{
    WriteLine($"{i} x {j} = {i * j}");
}
else
{
    WriteLine("obj is not an int so it can't multiply!");
}