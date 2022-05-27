using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class GuessedChars
    {
        public void SaveGuesses()
        {
            var alpha = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö" };

            alpha.ForEach(c => Console.Write(c));
            Console.WriteLine();
            string guess = Console.ReadLine().ToUpper().Trim();

            if (alpha.Contains(guess))
            {
                alpha.Remove(guess);
            }
            alpha.ForEach(c => Console.Write(c));
            Console.WriteLine();
        }
    }
}
