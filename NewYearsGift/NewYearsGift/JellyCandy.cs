using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class JellyCandy : Candy
    {
        public JellyCandy()
        {
            Weight = new Random().Next(50, 300);
            Filling = TypeFilling.Jelly;
            NameCandy = "Желейная";
        }
    }
}
