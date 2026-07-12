public class Solution {
    public int CharacterReplacement(string s, int k) {
        //
        var charsNum= new Dictionary<char,int>();
        int l=0,r=0,max=0;
        for (;r<s.Length;r++){

            int charDuplicationNumber=charsNum.GetValueOrDefault(s[r],0);
            charsNum[s[r]]= charDuplicationNumber+1;

            int windowSize=r-l+1;

            int maxLetter=charsNum.Values.Max();

            if (windowSize-maxLetter >k){
              while((r-l+1)-charsNum.Values.Max() >k && l<r){
                charsNum[s[l]]-=1;
                l++;

              }
            }
            max=Math.Max(max,r-l+1);


        }
        return max;
        
    }
}
