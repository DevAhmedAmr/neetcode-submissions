public class Solution
{
    public bool hasDuplicate(int[] nums)
    {
        var NumsSet = new HashSet<int>();

        foreach (int i in nums)
        {
            if (NumsSet.Contains(i)) {
                return true;

            }
            
            NumsSet.Add(i); 


            
                
          


        }
        return false;
    }
}