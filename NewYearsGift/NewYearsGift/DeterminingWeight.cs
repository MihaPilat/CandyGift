using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class DeterminingWeight
    {
        public int DeterminingWeightGift(Gift gift)
        {
            int weigthGift = 0;
            for (int i = 0; i < gift.Present.Length; i++)
            {
                weigthGift += gift.Present[i].Weight;
            }

            return weigthGift;
        }
    }
}
