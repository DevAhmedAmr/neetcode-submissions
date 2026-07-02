public class Solution {

    public string Encode(IList<string> strs) {
        string EncodedString="";

        foreach(var str in strs)
            EncodedString+= $"{str.Length}#"+str;
        

        return EncodedString;
 
    }

    public List<string> Decode(string s) {
        var l = new List<string> () ;
        Console.WriteLine($"{s} | {s.Length} ");
        string number= ""; //5
        //5#hello#5world
        for (int i = 0; i<s.Length;i++){
            var str="";
            Console.WriteLine($"- {i} {i<s.Length} ");

            if (s[i] == '#'){ 
                int j= i+1;
                int len = i+1+int.Parse(number);
         
                for (; j<len;j++){
                    Console.WriteLine($"{j} {len}  {number} {i}");
                    str+=s[j];
   
                }

                l.Add(str);

                number="";
                i=j;
                
                if (j+1 >= s.Length ){
                        break;
                    }
 
            }

            number+=s[i];

        }
        return l;
   }
}
