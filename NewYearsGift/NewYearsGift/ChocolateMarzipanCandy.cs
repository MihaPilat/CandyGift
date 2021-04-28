using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class ChocolateMarzipanCandy : ChocolateCandy
    {
        public ChocolateMarzipanCandy()
        {
            Weight = new Random().Next(50, 200);
            Filling = TypeFilling.ChocolateMarzizan;
            NameCandy = "Шоколадная с марзипаном";
        }
    }
}
