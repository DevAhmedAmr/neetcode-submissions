public class Solution {
    public bool IsPalindrome(string s) {
        //bool isPalindrome = True;
        String cleanS="";
        //97 <= c<= 122 , 65<=c<= 90

        foreach (int c in s.ToLower()){
            Console.WriteLine($"({(int)c}>={97} && {c}<={122}) || ({c}>={65} && {c}<={90}) = {(c>=97 && c<=122)} || {(c>=65 && c<=90)}");

            if ((c>=97 && c<=122) || (c>=65 && c<=90) || (c>=48 && c<=57)){
                cleanS+=(char)c;
            }
        }

       Console.WriteLine($"{cleanS}");


        for (
            int start=0,end=cleanS.Length -1;
            start<cleanS.Length-1;
            start++,end--
        
        )
        {   
            Console.WriteLine($"{cleanS[start] } == { cleanS[end]}");

            if(!(cleanS[start] == cleanS[end])){
                return false;

            }

        }
        return true;
    }
}
