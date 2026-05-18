using Xunit;

namespace Tests;

public class Exercise03Test
{
    [Theory]
    [InlineData("au", 2)]
    [InlineData("", 0)]
    [InlineData("abcabcbb", 3)]
    [InlineData("bbbbb", 1)]
    [InlineData("pwwkew", 3)]
    public void Test1(string s, int expected)
    {
        var exercise = new estudoLeetCode.Exercise03();
        var result = exercise.LengthOfLongestSubstring(s);
        Assert.Equal(expected, result);
    }
}