public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var result = new List<List<int>>();
        Array.Sort(nums);
        //[-1,0,1,2,-1,-4]
         //[-4,-1,-1,0,1,2]
        for(int i =0; i<nums.Length;i++){
            int current = nums[i] ; 
            var combination=new List<int>();
           // int start =0 ,end=nums.Length-1;


                if (i> 0 && nums[i] == nums[i-1])
                    continue;


            for(int start =i+1, end=nums.Length-1;start<end;){
                int r = (nums[start] + nums[end] + current) ;
    
     

                if (r ==0 ){
                    result.Add(new List<int>(){current,nums[start] , nums[end]});
                        start++;
                       while (nums[start]== nums[start-1] && start <end)
                            start++;
      

                    }

                else if (r>0)
                    end--;
                else if (r<0)
                start++;
                else
                break;

           
                
                


                


            }

        
        }

        return result;

    }
}
