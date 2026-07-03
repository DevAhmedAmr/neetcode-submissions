public class Solution {
    public int LongestConsecutive(int[] nums) {
        int[] squince=new int[nums.Length];
        int longest=0;
        HashSet<int> numsHash = nums.ToHashSet();

        // if (numsHash.Count==1)
        //     return 1;
        
        // if (numsHash.Count==0)
        //     return 0;
        
        //longest =1;

        foreach(int num in numsHash){
            int squince_counter=1;

            if (numsHash.Contains(num - 1 ))
                continue;

            // if (!numsHash.Contains(num + 1 ))
            //     continue;
           // Console.WriteLine($"{num}");
            

                while (true){
                    int n= num + squince_counter;

                if (numsHash.Contains(n)){
                    Console.WriteLine($">> {num} {n}");

                    squince_counter ++;

                    continue;
                    }
                    break;
                
            }
            if (longest  < squince_counter){
                Console.WriteLine($">> {longest} <  {squince_counter}");

                longest  = squince_counter;
            }
        

        }
        return longest ;
    }
}
 