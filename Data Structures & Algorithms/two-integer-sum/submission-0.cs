public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var x = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            x[nums[i]] = i; // Sets the key (number) to the value (index)
        }

        for (int i = 0; i < nums.Length; i++) {

            if (x.ContainsKey(target - nums[i]) && x[target - nums[i]] != i)
            {

                return [i, x[target - nums[i]]];
            }
        }

        return [];
    }


}
