public class Solution {
    public int Trap(int[] height)
    {
        int area = 0;
        int c = 0;
        for (int start = 0; start < height.Length - 1; start++)
        {
            int i, end = 0;
            bool secBarFound = false;
            Console.WriteLine($"-----------{start} <= {height.Length - 1} - {start < height.Length}---------------");

            for (i = start + 1; i < height.Length; i++)
            {
                // height[i] < height[i+1] &&

                if (height[start] <= height[i])
                {
                    Console.WriteLine($"innnnnnnnnnnn");

                    end = i;
                    secBarFound = true;
                    break;

                }
            }
            Console.WriteLine($"pre - {start} {end} {height[start]} {height[end]}");

            if (!secBarFound)
            {
                i = 0;
                bool noMatch= true;

                for (i = start + 1; i < height.Length; i++)
                {
                    if (height[i] < height[start] && height[i] > height[i - 1])
                    {

                        Console.WriteLine($">>> {height[i]} < {height[start]} && {height[i] }> {height[i - 1]}");

                        if (i > end)
                        {
                            end = i;
                             Console.WriteLine($">>>>>>>> end = {end} | {height[end]}");

                            noMatch=false;
                        }



                    }
                    else if ( noMatch && i == height.Length - 1)
                    {
                        Console.WriteLine($"hostifx {i} == {height.Length}");

                        end = height.Length - 1;
                    }
                }
            }
            Console.WriteLine($"after {start} {end} {height[start]} {height[end]}");
            int a = Math.Min(height[start], height[end]);
            while (start < end)
            {
                ;
                if (a - height[start] > 0)
                    area += a - height[start];
                Console.WriteLine($"-- {start} {end} {height[start]} {height[end]}|| {a }- {height[start]} = {a-height[start]} -> {area}");

                start++;
            }
            // if (c ==5)
            // break;

            start = end - 1;
            c++;
        }
        return area;

    }
    
    
}
