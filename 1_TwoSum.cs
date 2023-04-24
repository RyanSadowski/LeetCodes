using FluentAssertions;
using Xunit;

namespace LeetCodes;

public static class TwoSum1
{
    // public static int[] TwoSum(int[] nums, int target)
    // {
    //     for (var i = 0; i < nums.Count(); i++)
    //     {
    //         for (var j = 0; j < nums.Count(); j++)
    //         {
    //             if (j <= i)
    //             {
    //                 continue;
    //             }
    //             if (nums[i] + nums[j] == target)
    //             {
    //                 return new int[] {i, j};
    //             }
    //         }
    //     }
    //
    //     return new int[] { };
    // }
    //
    
    public static int[] TwoSum(int[] nums, int target)
    {
        //<target num, index>
        var dict = new Dictionary<int, int>();

        for (var i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i]))
            {
                return new[] {i, dict[target - nums[i]]};
            }

            if (!dict.ContainsKey(nums[i]))
            {
                dict.Add(nums[i], i);
            }
        }

        return new int[] { };
    }
}

public class TestTwoSum
{
    [Fact]
    public async Task FunctionName_Should_DoSomething()
    {
        // Arrange
        var nums1 = new int[] {2, 7, 11, 15};
        var target1 = 9;
        var nums2 = new int[] {3,2,4};
        var target2 = 6;
        var nums3 = new int[] {3,3};
        var target3 = 6;

        // Act
        var result1 = TwoSum1.TwoSum(nums1, target1);
        var result2 = TwoSum1.TwoSum(nums2, target2);
        var result3 = TwoSum1.TwoSum(nums3, target3);

        //Assert
        result1.Should().Contain(0);
        result1.Should().Contain(1);
        result2.Should().Contain(1);
        result2.Should().Contain(2);
        result3.Should().Contain(0);
        result3.Should().Contain(1);
        
    }
    
}