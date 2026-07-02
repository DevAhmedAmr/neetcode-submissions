public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs)
    {
        var dict = new Dictionary<string, List<string>>{ };
        List <List<string>> GroupAnagramslist= new List<List<string>>();

        foreach (var str in strs)
        {
            int[] arr =new int[255];

            foreach (char c in str.ToArray())
            {

                arr[(int)c] += 1;

            }
            
            if (!dict.ContainsKey(string.Join(",", arr))){
                Console.WriteLine($"str {str}");
                dict[string.Join(",", arr)]=new List<string>();
            }
            //Console.WriteLine($"** { string.Join("", arr)} {str}\n\n");
            dict[string.Join(",", arr)].Add(str);




        }

        return dict.Values.ToList();
        

        
    }



}
