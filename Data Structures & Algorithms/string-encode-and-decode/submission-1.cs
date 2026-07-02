public class Solution {

    public string Encode(IList<string> strs) {
        string EncodedString="";

        foreach(var str in strs){
            EncodedString+=str + ";";
        }

        return EncodedString;
 
    }

    public List<string> Decode(string s) {
        var l = new List<string> () ;
        var str="";
        foreach (char c in s){
            if(c == ';'){
                l.Add(str);
                str="";
                continue;
            }
            str+=c;

        }
        return l;
   }
}
