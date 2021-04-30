using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class SortingGift
    {
        public Gift Sorting(Gift gift)
        {
            for (int i = 0; i < gift.Present.Length; i++)
            {
                for (int j = i + 1; j < gift.Present.Length; j++)
                {
                    if (gift.Present[i].Weight > gift.Present[j].Weight)
                    {
                        int a = gift.Present[i].Weight;
                        int b = gift.Present[j].Weight;
                        gift.Present[i].Weight = b;
                        gift.Present[j].Weight = a;
                    }
                }
            }

            return gift;
        }
    }
}
