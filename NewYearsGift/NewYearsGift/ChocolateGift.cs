using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class ChocolateGift
    {
        public virtual Gift Create(int sizeGift)
        {
            Gift gift = new Gift();
            gift.Present = new Candy[sizeGift];
            for (int i = 0; i < sizeGift; i++)
            {
                gift.Present[i] = new ChocolateCandy();
            }

            return gift;
        }
    }
}
