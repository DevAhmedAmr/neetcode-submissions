public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var sums = new List<List<int>>();
        Array.Sort(nums);
        for (int i = 0; i < nums.Length; i++) {
            int start = i+1, end = nums.Length - 1;

            if (i>0 && nums[i] == nums[i-1])
            continue;

            while  (start < end) {

                int sum = nums[i] + nums[start] + nums[end];
         
         
               // Console.WriteLine($"{sum} | {start} {end}");

                if (sum > 0)
                    end--;
                else if (sum<0)
                    start++;
                else{


                    sums.Add(new List<int>() { nums[i], nums[start], nums[end] });
                    start++;
                    while (nums[start] == nums[start-1]&& start < end)
                    start++;

                }
               

            
            }

        }

        return sums;
    }
}

