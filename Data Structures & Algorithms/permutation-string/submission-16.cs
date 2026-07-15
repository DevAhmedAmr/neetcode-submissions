public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int matches =0,l=0,r=0;
        int[] s1Arr = new int[255],s2Arr= new int[255];
      
        if (s2.Length < s1.Length)
                return false;

        for (int i=0;i<s1.Length;i++){
            s1Arr[(int)(s1[i])]+=1;
            s2Arr[(int)(s2[i])]+=1;
        }

        for (int i=0;i<s1Arr.Length;i++){
         if ( s1Arr[i]== s2Arr[i])
            matches+=1;
            //   else{
            //         Console.WriteLine($"{(char)i} : {s1Arr[i]}== {s2Arr[i]} {s1Arr[i]== s2Arr[i]}");

            //     }
            }
        for ( l = 0, r=s1.Length;r<s2.Length;r++){
            if (matches==255)
            return true;

            s2Arr[(int)s2[r]] += 1;



                if (s2Arr[(int)s2[r]] == s1Arr[(int)s2[r]])
                matches+=1;

                else if (s1Arr[(int)s2[r]] + 1 == s2Arr[(int)s2[r]])
                    matches-=1;

            int index=(int)s2[l];
            s2Arr[index] -= 1;

            if (s2Arr[index] == s1Arr[index])
                matches += 1;
                
            else if (s1Arr[(index)] - 1 == s2Arr[index])
                matches -= 1;
            l+=1;



        }


  
        return matches==255;
    }
}
