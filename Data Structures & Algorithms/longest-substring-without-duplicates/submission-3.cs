public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var hashset=new HashSet<char>();
        int maxLengthOfLongestSubstring=0;
        for(int i=0 ; i<s.Length; i++){
            if (hashset.Contains(s[i])){
                maxLengthOfLongestSubstring= Math.Max(hashset.Count(),maxLengthOfLongestSubstring);
                hashset=new HashSet<char>();
                int j = i;
                while(j>0){
                     if (!hashset.Contains(s[j]))
                     {
                         hashset.Add(s[j]);
                        
                     }
                     else
                     break;

                    j--;
                }                           


            }else{hashset.Add(s[i]);}
                
            
        }
        maxLengthOfLongestSubstring= Math.Max(hashset.Count(),maxLengthOfLongestSubstring);

        return maxLengthOfLongestSubstring;

    }
}
