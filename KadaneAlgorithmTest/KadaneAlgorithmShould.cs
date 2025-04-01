using KadaneAlgorithmDemo;

namespace TestProject1;

public class KadaneAlgorithmShould
{
    [Fact]
    public void GiveMaxSubOfSubArray()
    {
        KadaneAlgorithm kadaneAlgorithm = new KadaneAlgorithm
        {
            IntegerArray = [-2, 1, -3, 4, -1, 2, 1, -5, 4]
        }; 

        var largestSumOfSubArray = kadaneAlgorithm.GetLargestSumOfSubArray();
        Assert.Equal(6, largestSumOfSubArray);
    }
    
    [Fact]
    public void GiveHighestNegativeNumberWhenAllElementsAreNegative()
    {
        KadaneAlgorithm kadaneAlgorithm = new KadaneAlgorithm
        {
            IntegerArray = [-7,-4,-2,-456]
        };

        var largestSumOfSubArray = kadaneAlgorithm.GetLargestSumOfSubArray();
        Assert.Equal(-2, largestSumOfSubArray);
    }
}