using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class Count
    {
        public static int CountDown(int count)
        {
            
            var guessedChars = new GuessedChars();
           

            for (int i = 10; i > 0; i--)
            {
                guessedChars.RemoveGuessedChars();
                
                Console.WriteLine(i.ToString());

            }
            return count;
        }

        public void StartCount()
        {
            CountDown(10);
        }

    }
}
