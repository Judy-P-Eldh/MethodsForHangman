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
            for (int i = 10; i > 0; i--)
            {
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
