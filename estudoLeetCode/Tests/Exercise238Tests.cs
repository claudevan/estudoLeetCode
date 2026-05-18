using Xunit;
using estudoLeetCode;

namespace Tests;

public class Exercise238Tests
{
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
    [InlineData(new[] { -1, 1, 0, -3, 3 }, new[] { 0, 0, 9, 0, 0 })]
    public void Result(int[] nums, int[] expected)
    {
        var exercise = new Exercise238();
        var result = exercise.ProductExceptSelf(nums);
        Assert.Equal(expected, result);
    }
}