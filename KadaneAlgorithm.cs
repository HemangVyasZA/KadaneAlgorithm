namespace KadaneAlgorithmDemo;

public class KadaneResult
{
    public int MaxSum { get; init; }
    public int StartIndex { get; init; }
    public int EndIndex { get; init; }

    public override string ToString()
    {
        return $"Max Sum: {MaxSum}, Subarray: [{StartIndex}..{EndIndex}]";
    }
}
public class KadaneAlgorithm()
{
    public int[] IntegerArray { get; set; } = [];
    
    public int GetLargestSumOfSubArray()
    {
        if (IntegerArray.Length == 0)
        {
            throw new InvalidOperationException("Can't find largest sum of an empty array");
        }
        
        // If all elements of an array are -ve values, Logically the max number in the array is the height sum of the sub array.
        if (IntegerArray.All(item => item < 0))
        {
            return IntegerArray.Max();
        }
        
        int globalMax = 0;
        int currentMax = 0;

        foreach (var number in IntegerArray)
        {
            currentMax = Math.Max(number, number + currentMax);
            globalMax = Math.Max(globalMax, currentMax);
        }

        return globalMax;
    }
    
    public static KadaneResult FindMaxSubarray(int[]? nums)
    {
        if (nums == null || nums.Length == 0)
            return new KadaneResult { MaxSum = 0, StartIndex = -1, EndIndex = -1 }; // Handle empty input

        int maxCurrent = nums[0];
        int maxGlobal = nums[0];
        int start = 0, end = 0;
        int tempStart = 0; // Tracks where a new subarray begins

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > maxCurrent + nums[i])
            {
                // Start a new subarray at current index
                maxCurrent = nums[i];
                tempStart = i;
            }
            else
            {
                // Extend the existing subarray
                maxCurrent += nums[i];
            }

            // Update global max if current max is better
            if (maxCurrent > maxGlobal)
            {
                maxGlobal = maxCurrent;
                start = tempStart;
                end = i;
            }
        }

        return new KadaneResult
        {
            MaxSum = maxGlobal,
            StartIndex = start,
            EndIndex = end
        };
    }
}