using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCode
{
    public class CoinChange
    {
        int[] coins = { 1,2,5};
        int amount = 11;

        //int[] coins = { 186, 419, 83, 408 };
        //int V = 6249;
        //int m = coins.Length;
        public int CoinChange1()
        {
            int ans = 0;
            Array.Sort(coins);
            for (int i = coins.Length - 1; i >= 0; i--)
            {
                if (amount > 0)
                {
                    ans = ans + (amount / coins[i]);
                    amount = amount % coins[i];
                }
            }
            if (amount > 0)
                ans = -1;
            return ans;
        }
        public int CoinChange2()
        {
            return minCoins(coins, amount);
        }
        //TODO: Have to still understand
        public int minCoins(int[] coins,  int amount)
        {
            // base case 
            if (amount < 1) return 0;
            int[] dp = new int[amount + 1];
            int sum = 0;

            while (++sum <= amount)
            {
                int min = -1;
                foreach (var coin in coins)
                {
                    if (sum >= coin && dp[sum - coin] != -1)
                    {
                        int temp = dp[sum - coin] + 1;
                        min = min < 0 ? temp : (temp < min ? temp : min);
                    }
                }
                dp[sum] = min;
            }
            return dp[amount];
        }
    
    }
}
