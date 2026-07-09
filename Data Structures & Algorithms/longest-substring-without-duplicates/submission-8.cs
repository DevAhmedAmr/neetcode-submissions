public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hashset=new HashSet<char>();
        int maxLengthOfLongestSubstring=0;
        int l=0,r=0;
    //zxyyxyz
        while(r<s.Length){
            if (!hashset.Contains(s[r]))
                hashset.Add(s[r]);
            else{
                while(hashset.Contains(s[r])){
                    hashset.Remove(s[l]);
                    l++;
                }
                hashset.Add(s[r]);
            }
                maxLengthOfLongestSubstring= Math.Max(hashset.Count(),maxLengthOfLongestSubstring);
                    Console.WriteLine(String.Join(", ",hashset.ToList()));

            r++;
        }

        maxLengthOfLongestSubstring= Math.Max(hashset.Count(),maxLengthOfLongestSubstring);

        return maxLengthOfLongestSubstring;

    }
}
