public class Solution {
    public int MaxProfit(int[] prices) {
        int l=0 , r=0, maxProfit=0;

        for (; r < prices.Length; r++){
            Console.WriteLine($"l:{l} r:{r} -> {Math.Max(prices[r]-prices[l],maxProfit)}= Math.Max({prices[r]}-{prices[l]},{maxProfit});");

            maxProfit= Math.Max(prices[r]-prices[l],maxProfit);

            if (prices[r]<prices[l])
            l=r;
        }
        return maxProfit;
    } 
}
