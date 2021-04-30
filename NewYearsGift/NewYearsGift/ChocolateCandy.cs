using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class ChocolateCandy : Candy
    {
        public ChocolateCandy()
        {
            Weight = new Random().Next(50, 150);
            Filling = TypeFilling.Chocolate;
            NameCandy = "Шоколадная";
        }
    }
}
