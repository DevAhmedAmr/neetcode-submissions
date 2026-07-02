public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
      int[] prefix= new int[nums.Length];
      int[] postfix=new int[nums.Length];
      int[] result=new int[nums.Length];
      for (int i = 0 ; i<nums.Length;i++){
        if (i == 0){
            prefix[i]=nums[i];
            continue;

        }

        prefix[i]= prefix[i-1] *nums[i];


      }
//[1,2,8,48] 
// [48,48,24,6]
      for (int i = nums.Length-1 ; i>=0; i--){
        if (i == nums.Length -1){
            postfix[i]=nums[i];
            
            continue;

        }

        postfix[i] = nums[i] * postfix[i+1];

      }
 
           
      for (int i = 0 ; i<nums.Length;i++){
            int prefiN ,postfixN;

            if (i == 0)
              prefiN=1;
            else
            prefiN=prefix[i-1];

            if (i ==nums.Length-1)
              postfixN=1;
            else
            postfixN=postfix[i+1];


            result[i] =prefiN *postfixN;
          }
      foreach (var number in prefix){
        Console.WriteLine(number);
      }   
      Console.WriteLine("+-----------+");
           
    foreach (var number in postfix){
        Console.WriteLine(number);
      }
    return result;
    }
}
