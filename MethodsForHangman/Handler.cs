﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsForHangman
{
    public class Handler
    {
        public void StartMethod()
        {
            var startCount = new Count();
            startCount.StartCount();

            var guessWordOnce = new GuessWordOnce();
            guessWordOnce.CheckWordGuess(false);  //Om true körs inte metoden, vilket är som tänkt.
        }
         
    }
}
