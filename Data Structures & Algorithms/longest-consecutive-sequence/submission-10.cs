public class Solution {
    public int LongestConsecutive(int[] nums) {
        var numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet) {
            if (numSet.Contains(num - 1)) continue; // only start at sequence starts

            int length = 1;
            while (numSet.Contains(num + length)) length++;

            longest = Math.Max(longest, length);
        }

        return longest;
    }
}