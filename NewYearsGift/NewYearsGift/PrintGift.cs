using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class PrintGift
    {
        public void DisplayGift(Gift gift)
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("Наш подарок:");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("{");
            Console.ForegroundColor = ConsoleColor.Yellow;
            for (int i = 0; i < gift.Present.Length; i++)
            {
                Console.WriteLine($"Конфета: {gift.Present[i].NameCandy}. Ее вес: {gift.Present[i].Weight}.");
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("}");
        }
    }
}
