public class Solution {
    public int MaxArea(int[] heights) {
        int start=0;
        int end=heights.Length-1;
        int maxArea=0;
        while(start<end){
            int hight= Math.Min(heights[start],heights[end]);
            int width = end-start;
            int area =hight*width;

            if (area > maxArea){
                maxArea=area;
            }
           ;
           //Console.WriteLine($"{start} {end} {heights[start] }>{heights[ end]} {area}");
           if (heights[start] >heights[ end])
           end --;
           else
           start++;
            

        
        }
        return maxArea;
        
    }
    // public int min (int min){

    // }
}
