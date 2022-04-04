using static System.Console;

namespace Exercice01
{
    internal class Palindrome
    {
        internal static bool EstUnPalindrome(string phrase)
        {
            string phraseCompactE = Palindrome.Compacter(phrase);
            string phraseInversE = Palindrome.Pivoter(phraseCompactE);

            return phraseCompactE.Equals(phraseInversE);
        }

        private static string Pivoter(string phraseCompactE)
        {
            string chaineInversEe = "";
            foreach (var item in phraseCompactE)
            {
                chaineInversEe = $"{item.ToString()}{chaineInversEe}";
            }

            return chaineInversEe;
        }

        private static string Compacter(string phrase)
        {
            char[] ponctuations = new[]{' ', ',', ';', '.', '!', '?', '\''};
            string chaineCompactee = "";
            bool estUnePonctuation = false;
            for (int i = 0; i < phrase.Length; i++)
            {
                foreach (char item in ponctuations)
                {
                    if(item.Equals(phrase[i]))
                    {
                        estUnePonctuation = true;
                        break;
                    }
                }
                if (!estUnePonctuation)
                {
                    chaineCompactee += phrase[i].ToString();
                }
                estUnePonctuation = false;
            }

            return chaineCompactee;
        }
    }
}