namespace KadaneAlgorithmDemo;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = [-2, 1, -3, 4, -1, 2, 1, -5, 4];
        // int[] nums = [-5,1,-10];
        var maxSum = FindMaxSumOfSubArray(nums);
        Console.WriteLine($"The max sum is:{maxSum}");
        Console.ReadLine();
    }

    

    private static int FindMaxSumOfSubArray(int[]? numbers)
    {
        if (numbers is null || numbers.Length == 0)
        {
            return -1;
        }

        // what if all the elements are -ve, return the max -ve element
        if (numbers.All(item => item < 0))
        {
            return numbers.Max();
        }

        int currentMax = 0;
        int globalMax = 0;
        foreach (var number in numbers)
        {
            currentMax = Math.Max(number, currentMax + number);
            globalMax = Math.Max(globalMax, currentMax);
        }

        return globalMax;
    }
}