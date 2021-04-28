using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class AllCandyGift : ChocolateGift
    {
        public override Gift Create(int sizeGift)
        {
            Gift gift = new Gift();
            gift.Present = new Candy[sizeGift];
            for (int i = 0; i < sizeGift; i++)
            {
                int ramdomChocolateType = new Random().Next(0, 4);
                switch (ramdomChocolateType)
                {
                    case 0:
                        gift.Present[i] = new ChocolateCandy();
                        break;
                    case 1:
                        gift.Present[i] = new ChocolateMarzipanCandy();
                        break;
                    case 2:
                        gift.Present[i] = new ChocolateMarzipanNuts();
                        break;
                    case 3:
                        gift.Present[i] = new JellyCandy();
                        break;
                }
            }

            return gift;
        }
    }
}
