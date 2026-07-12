public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var set = new HashSet<char>();

        int r = 0, l =0,max=0;

        for (;r<s.Length;r++){

            if (!set.Contains(s[r])){
                set.Add(s[r]);
                //s[l..r].Length
                max = Math.Max(max,s[l..r].Length+1);
            }
            else {
                while (set.Contains(s[r])){
                set.Remove(s[l]);
                l++;
                }
                set.Add(s[r]);

            }
            
            Console.WriteLine($" {l} {r} | {s[l..r]} | {max} ");

        }
        return max;
    }
}
