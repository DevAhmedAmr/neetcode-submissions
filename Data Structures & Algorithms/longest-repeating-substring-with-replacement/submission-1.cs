public class Solution {
    public int CharacterReplacement(string s, int k) {
        int fast =0, slow=0,total=0;
        var charsCount=new Dictionary<char,int>();
  
        for(fast = 0;fast<s.Length;fast++){
            int windowSize=fast-slow+1;
            charsCount[s[fast]]= charsCount.GetValueOrDefault(s[fast],0)+1;//A=1,b1
            //2 - 1 
             Console.WriteLine($"- {s[fast]}:{fast} {s[slow]}:{slow}| {windowSize}");

            if (windowSize - charsCount.Values.Max()>k){
                

                charsCount[s[slow]]-=1;
                slow++;
                windowSize=fast-slow+1;
                 }



            total = Math.Max(total,windowSize);



            



        }
        return total;
        
    }
}
