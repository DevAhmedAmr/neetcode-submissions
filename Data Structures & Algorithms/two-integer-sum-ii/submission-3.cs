public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int start = 0 , end = numbers.Length-1;
        int[] targetIndecies = new int[2];

        while (true){
            int s = numbers[start];
            int e = numbers[end];

            if (start == end)
                break;
            
            //Console.WriteLine($"{s} {e} , {start} {end}");
            
            if (s+e == target){
                targetIndecies[0]=start+1;
                targetIndecies[1]=end+1;

                return targetIndecies;

            }
            else if (s+e > target)
                end--;
            else if (s+e < target)
                start++;
            


        }
        return targetIndecies;
        
    }
}
