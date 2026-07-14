public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // abc leabcee
        //var permutations= new List<HashSet<char>>();
        var s1Set= s1.ToHashSet<char>();
        var s1CharFreq=new int[256];
        int l=0,r=0;

        s1.GroupBy(c => c)
            .ToList()
            .ForEach(g => s1CharFreq[g.Key] = g.Count());
            

        for (;r<s2.Length;r++){
            int[] windowCharFreq=new int[256];

            if (r>=s1.Length-1){
                l = r-s1.Length+1;
                Console.WriteLine($"{l} {r} {s1.Length-1} {s2[l..(r+1)]} ");

                 s2[l..(r+1)].GroupBy(c => c)
                .ToList()
                .ForEach(g => windowCharFreq[g.Key] = g.Count());

            //     Console.WriteLine($"{String.Join(",",windowCharFreq)}");
            //     Console.WriteLine($"{String.Join(",",s1CharFreq)}");
             Console.WriteLine($"------------");

                if ( windowCharFreq.SequenceEqual(s1CharFreq))
                    return true;
            }


            


   

            

        }

        return false;
    }
}
