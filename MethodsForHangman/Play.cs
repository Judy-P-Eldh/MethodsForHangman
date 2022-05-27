using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    internal class Play
    {
        public void PlayGame()
        {
            var hangMan = new WordGenerator();
            var ord = hangMan.GenerateWord();
            GuessWord(ord);
        }

        private void GuessWord(string ord)
        {
            ord = ord.ToUpper();

            foreach (var c in ord)
            {
                Console.Write("_ ");
            }

            Console.WriteLine($"\n\n(Ordet består av: {ord.Length} bokstäver.)\n");

            //var startCount = new Count();
            //startCount.StartCount();
        }
    }
}
