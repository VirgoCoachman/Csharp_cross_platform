using static System.Console;

namespace Exercice01
{
    class Application
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Write("Veuillez tapez une phrase ou un mot : ");
                string? phrase = ReadLine();

                if(String.IsNullOrEmpty(phrase))
                {
                    WriteLine("La phrase ou le mot ne doit pas être vide !");
                    continue;
                }

                if (Palindrome.EstUnPalindrome(phrase))
                {
                    WriteLine($"{phrase} : est un palindrome");
                }
                else
                {
                    WriteLine($"{phrase} : n'est pas un palindrome");
                }
            }

        }
    }
}
