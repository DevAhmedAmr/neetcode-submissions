public class Solution {
    public int Trap(int[] height)
    {
        int maxL=0,maxR=0;
        int  l=0 ,r=height.Length-1;
        int area=0;
      //  int i=0;
        while(l<=r){
            // maR= 0 ,2 ,2,2

            // maxL=0 ,0 ,5,5
            if (maxL<maxR){
                int a = Math.Min(maxL,maxR)-height[l];
                Console.WriteLine($"L {maxL}<{maxR} | {height[l]} = {a}");
                if (a>0)
                    area+=a;
                maxL=Math.Max(maxL,height[l]);
                l++;

            }else{
               int a = Math.Min(maxL,maxR)-height[r];
                Console.WriteLine($"R {maxL}<{maxR} | {height[r]} = {a}");

                if (a>0)
                    area+=a;
                maxR=Math.Max(maxR,height[r]);
                r--;
            }

        }
        
    return area;

    }

    
}
