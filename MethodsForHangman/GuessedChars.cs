using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class GuessedChars
    {
        //Sparar gissningarna i en egen lista
       // List<string> guesses = new List<string>();

        private List<string> alpha = new List<string>() {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö"};

        public string RemoveGuessedChars()
        {
            alpha.ForEach(c => Console.Write(" " + c));
            Console.WriteLine();
            string guess = Console.ReadLine().ToUpper().Trim();
            

            if (alpha.Contains(guess))
            {
                alpha.Remove(guess);
            }

            //alpha.ForEach(c => Console.Write(c));
            //Console.WriteLine();
            return guess;
        }

        
        //public void AllGuesses(string guess)
        //{
        //    guesses.Add(guess);
        //    guesses.ForEach(c => Console.SetCursorPosition(20, 0));
        //    guesses.ForEach(c => Console.WriteLine(c));
        //}
    }
}
