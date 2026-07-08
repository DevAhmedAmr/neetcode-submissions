public class Solution {
    public int MaxProfit(int[] prices) {
     int left=0,right=1;
     int maxProfit=0;// minLeft,MaxRight=prices[1],
     ;
     //=prices[0]
    //
    if (prices.Length<2)
        return maxProfit;

     while(( right<=prices.Length-1)){
     
       
        Console.WriteLine($" ({prices[right]}-{prices[left]}) prift {maxProfit} ");

     

        maxProfit=Math.Max(maxProfit,prices[right]-prices[left]);
        if (prices[left]>prices[right]){
                    left=right;}
            right++;


    //10,1,5,6,7,1
    //,1,5,6,7,1,10
     }
    return Math.Max(maxProfit,0);

    }
}
