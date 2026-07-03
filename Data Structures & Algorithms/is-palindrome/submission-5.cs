public class Solution {
    public bool IsPalindrome(string s) {
        //bool isPalindrome = True;
        // var  cleanS=new StringBuilder();
        // //97 <= c<= 122 , 65<=c<= 90

        // foreach (char c in s.ToLower()){
        //     //Console.WriteLine($"({(int)c}>={97} && {c}<={122}) || ({c}>={65} && {c}<={90}) = {(c>=97 && c<=122)} || {(c>=65 && c<=90)}");

        //     if (char.IsLetterOrDigit(c)){
        //         cleanS.Append(c);
        //     }
        // }

       //Console.WriteLine($"{cleanS}");


        for (
            int start=0,end=s.Length -1;
            start<end;
            start++,end--
        
        )
        {   
            //Console.WriteLine($"{cleanS[start] } == { cleanS[end]}");
            while(!char.IsLetterOrDigit(s[start])){
                start++;
                if (start > s.Length-1){
                    Console.WriteLine($"break {start} {end}");
                return true;}
                }

            Console.WriteLine($"11 {start } == { end}");

            while(!char.IsLetterOrDigit(s[end])){
                end--;
            if (end<=0 )
              return true;
                }
            Console.WriteLine($"{start } == { end}");


            
            Console.WriteLine($"2 {s[start]} == {s[end]}");

            if(!(char.ToLower(s[start]) == char.ToLower(s[end])) ){
                return false;

            }
            Console.WriteLine($"{start } == { end}");
            Console.WriteLine($"-----------------------------");

        }
        return true;
    }
}
