﻿using System;
using Unit_1._4_Rx.Models;

namespace Unit_1._4_Rx.Observers
{
    internal class ConsoleOddChars:IObserver<ConsoleInput>
    {
        public void OnNext(ConsoleInput consoleInput)
        {
            var even = consoleInputHasEvenNumberOfChars(consoleInput);
            var color = getColor(even);
            var textToPrint = getTextToPrint(even);
            Console.ForegroundColor = color;
            Console.WriteLine(textToPrint);
            Console.ResetColor();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnCompleted()
        {
            throw new NotImplementedException();
        }


        private bool consoleInputHasEvenNumberOfChars(ConsoleInput consoleInput)
        {
            return consoleInput.Message.Length % 2 == 0;
        }

        private ConsoleColor getColor(bool even)
        {
            return even ? ConsoleColor.Red : ConsoleColor.Green;
        }

        private string getTextToPrint(bool even)
        {
            return even ? "Your string had an even # of characters.\n" : "Your string had an odd # of characters.\n";
        }

    }
}
