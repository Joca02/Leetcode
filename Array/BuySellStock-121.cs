using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class BuySellStock_121
    {
        public static  int MaxProfit(int[] prices)
        {
            int maxStock = -1;
            int maxProfit = 0;
            for(int i=prices.Length-1; i>0; i--)
            {
                if (prices[i] > maxStock)
                    maxStock = prices[i];
                
                int profit = maxStock-prices[i-1];
                if(profit > maxProfit)
                    maxProfit = profit;    
            }
            return maxProfit;
        }
    }
}
