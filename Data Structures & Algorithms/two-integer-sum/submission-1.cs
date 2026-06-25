public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        var numsDict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            numsDict[nums[i]] = i; // Sets the key (number) to the value (index)
        }

        for (int i = 0; i < nums.Length; i++) {

            if (numsDict.ContainsKey(target - nums[i]) && numsDict[target - nums[i]] != i)
            {

                return [i, numsDict[target - nums[i]]];
            }
        }

        return [];
    }


}
