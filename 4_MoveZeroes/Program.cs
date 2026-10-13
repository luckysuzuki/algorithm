#:property PublishAot=false

using System;
using System.Collections.Generic;

// Local test: change the input here when practicing.
int[] nums=[0,0,1];
Solution sl=new Solution();
sl.MoveZeroes(nums);
foreach(int i in nums)
{
    Console.WriteLine(i);
}
// Submit only the Solution class to LeetCode.
public class Solution
{
    public void MoveZeroes(int[] nums) {
        int slow = 0;

        // 第一步：把所有非 0 元素依次移到数组前面
        for (int fast = 0; fast < nums.Length; fast++) {
            if (nums[fast] != 0) {
                nums[slow] = nums[fast];
                slow++;
            }
        }

        // 第二步：将 slow 后面剩余的位置全部补 0
        for (int i = slow; i < nums.Length; i++) {
            nums[i] = 0;
        }
    }
}
