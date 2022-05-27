using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class GuessedChars
    {
        char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ".ToCharArray();
        
        public void SaveGuesses()
        {
            Console.WriteLine(alpha);
            string guess = Console.ReadLine().ToUpper().Trim();  //Gjorde en array från början, men tog bort den. Behöver detta också vara en array?

            foreach (var c in guess)
            {
                if (alpha.Contains(c))
                {
                    alpha[c].ToString().Remove(c);     //Hur tar jag bort bokstaven ur alpha?
                }
            }
            Console.WriteLine(alpha);
        }
    }
}
