public class Solution {
    public int LongestConsecutive(int[] nums) {
        int[] squince=new int[nums.Length];
        int counter;
        HashSet<int> numsHash = nums.ToHashSet();

        if (numsHash.Count==1)
            return 1;
        
        if (numsHash.Count==0)
            return 0;
        
        counter=1;

        foreach(int num in nums){
            int squince_counter=1;
            int numCopy=num;

            if (numsHash.Contains(num - 1 ))
                continue;

            if (!numsHash.Contains(num + 1 ))
                continue;
            Console.WriteLine($"{num}");
            

                while (true){
                if (numsHash.Contains(++numCopy )){
                        Console.WriteLine($">> {num} {numCopy}");
                    
                    squince_counter++;
                    continue;
                    }
                    break;
                
            }
            if (counter < squince_counter){
                counter = squince_counter;
            }
        

        }
        return counter;
    }
}
 