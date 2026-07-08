public class Solution {
    public int MaxProfit(int[] prices) {
     int left=0,right=1;
     int maxProfit=0;
     ;
 
    if (prices.Length<2)
        return maxProfit;

     while(( right<=prices.Length-1)){
     
       
        Console.WriteLine($" ({prices[right]}-{prices[left]}) prift {maxProfit} ");

     

        maxProfit=Math.Max(maxProfit,prices[right]-prices[left]);
        if (prices[left]>prices[right]){
                    left=right;}
            right++;


 
     }
    return Math.Max(maxProfit,0);

    }
}
