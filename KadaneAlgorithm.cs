namespace KadaneAlgorithmDemo;

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
}