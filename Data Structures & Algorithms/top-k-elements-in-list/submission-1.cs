    public class Solution
    {
//        Input: nums = [1, 2, 2, 3, 3, 3], k = 2

//Output: [2, 3]
        public int[] TopKFrequent(int[] nums, int k)
        {
            Dictionary<int,int> elementsFrequents = [];
            int maxDuplication = 0;

            int[] TopKFrequentNumbers = new int[k ];


            foreach (var i in nums)
            {
                if (!elementsFrequents.ContainsKey(i))
                    elementsFrequents[i] = 0;

                elementsFrequents[i] += 1;

                if (elementsFrequents[i] > maxDuplication)
                    maxDuplication = elementsFrequents[i];
            }

            List<int>[] arr = new List<int>[maxDuplication+1];

            foreach (var pair in elementsFrequents)

            {
                int number= pair.Key;
                int duplicationNumber= pair.Value;


                if (arr[duplicationNumber] is null)
                    arr[duplicationNumber] = new List<int> ();

                arr[duplicationNumber].Add(number);



            }

            int ItemFoundCounter = 0;
            int j = 0;

            //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(arr));

            for (int i = arr.Length-1; i>0; i--)
     
            {
                if (arr[i] is null)
                    continue;
                foreach (var item  in arr[i])
                {
                   // if (item = 0)
                    TopKFrequentNumbers[j]=item;
                    //Console.WriteLine(System.Text.Json.JsonSerializer.Serialize(TopKFrequentNumbers));

                    ItemFoundCounter++;
                    j++;


                    if (ItemFoundCounter >= k)
                        return TopKFrequentNumbers;
                 
                }




            }
            return TopKFrequentNumbers;








        }
    }