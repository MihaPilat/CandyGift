using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class ChocolateMarzipanNuts : ChocolateMarzipanCandy
    {
        public ChocolateMarzipanNuts()
        {
            Weight = new Random().Next(50, 500);
            Filling = TypeFilling.ChocolateMarzizanNuts;
            NameCandy = "Шоколадная с марзипаном и орешками";
        }
    }
}
