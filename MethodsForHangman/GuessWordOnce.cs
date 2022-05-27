using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class GuessWordOnce
    {
        string word = "ord";
        
        public bool WordGuess()      //False = metoden har inte körts. True = metoden har körts.
        {
            Console.WriteLine("Gissa hela ordet, 3 bokstäver.");
            string guess = Console.ReadLine().ToUpper().Trim();

            word = word.ToUpper();
           
            if (word == guess)
            {
                Console.WriteLine("Rätt");
            }
            else
            {
                Console.WriteLine("Fel");
            }
            return true;
        }
    }
}
