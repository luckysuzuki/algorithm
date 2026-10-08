#:property PublishAot=false

using System;
using System.Collections.Generic;

// Local test: change the input here when practicing.
int[] nums = [2, 7, 11, 15];
int target = 9;

int[] result = new Solution().TwoSum(nums, target);
Console.WriteLine($"[{string.Join(", ", result)}]");

// Submit only the Solution class to LeetCode.
public class Solution
{
    public int[] TwoSum(int[] nums, int target)
    {
        // 思路：遍历数组，用哈希表保存已经遍历过的“数值 -> 下标”。
        // 对当前数 nums[i]，只需查找是否出现过 target - nums[i]。
        // 哈希表查询平均为 O(1)，因此整体时间复杂度为 O(n)，空间复杂度为 O(n)。
        var seen = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            // 如果补数已出现，它与当前数相加就是 target，返回这两个数的下标。
            if (seen.TryGetValue(target - nums[i], out int index))
            {
                return [index, i];
            }

            // 先查找、后记录，避免把当前元素与自己配对。
            // 重复数值可以覆盖旧下标，因为后续配对只需要一个已出现的下标。
            seen[nums[i]] = i;
        }

        // 遍历结束仍未找到配对时，返回空数组。
        return [];
    }
}
