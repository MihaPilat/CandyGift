using System;
using System.Collections.Generic;
using System.Text;

namespace NewYearsGift
{
    public class SearchCandy
    {
        public int Search(Gift gift, int weight)
        {
            int indexCandy = 0;
            for (int i = 0; i < gift.Present.Length; i++)
            {
                if (weight == gift.Present[i].Weight)
                {
                    indexCandy = i + 1;
                    break;
                }
            }

            return indexCandy;
        }
    }
}
