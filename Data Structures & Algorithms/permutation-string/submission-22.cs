public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int[] s1Freq=new int[255];
        int[] s2Freq=new int[255];
        int matches=0;
        if(s2.Length < s1.Length )
        return false;

        for(int i = 0; i < s1.Length; i++)
            {
                s1Freq[(int)s1[i]]+=1;
                s2Freq[(int)s2[i]]+=1;
            }
            
        for(int i = 0; i < s1Freq.Length; i++)
            {
                if(s1Freq[i]==s2Freq[i])
                        matches+=1;
            }

        int l=0;
        for(int r =  s1.Length ; r < s2.Length; r++)
            {
                if (matches==255)
                    return true;

                int index=(int)s2[r];
                Console.WriteLine($"{index} -> {(char) index } | {matches} feq: s1 {s1Freq[index]} | s2 {s2Freq[index]}");

                s2Freq[index]++;

                if (s2Freq[index]==s1Freq[index])
                    matches++;
                else if (s1Freq[index]+1==s2Freq[index])
                    matches--;
                    
                Console.WriteLine($"1- {index} -> {(char) index } | {matches} feq: s1 {s1Freq[index]} | s2 {s2Freq[index]}");

                index=(int)s2[l];
                s2Freq[index]--;

                if (s2Freq[index]==s1Freq[index])
                    matches++;
                else if (s1Freq[index]-1==s2Freq[index])
                    matches--;
                Console.WriteLine($"1- {index} -> {(char) index } | {matches} feq: s1 {s1Freq[index]} | s2 {s2Freq[index]}");
                Console.WriteLine($"-------------------");
                l++;

            }




    return matches==255;
    }
}
