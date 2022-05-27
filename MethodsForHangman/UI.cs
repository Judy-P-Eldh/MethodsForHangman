using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class UI
    {

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public void StartMenu()
        {
            var play = new Play();
            Dictionary<int, string> startMenu = new Dictionary<int, string>();

            Print("Välkommen!\n--------------" +

                "\n1) Börja spela" +
                "\n2) Läs reglerna" +
                "\n0) Avsluta\n");

            var input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    play.PlayGame();
                    break;
                case "2":
                    //Rules();
                    break;
                case "0":
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
        }

        
        public void PlayMenu()
        {
            Console.WriteLine("Poäng: 10");   //Ska räkna ner
            Console.WriteLine("Gissa hela ordet");  //Ska vara möjlig att välja endast en gång.
            Console.WriteLine("Du har gissat på: ");
        }

        public void CursorPosition()
        {
            Console.SetCursorPosition(20, 0);
        }
    }
}
