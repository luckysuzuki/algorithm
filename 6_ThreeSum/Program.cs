#:property PublishAot=false

using System;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic;

// Local test: change the input here when practicing.
int [] nums = [-1,0,1,2,-1,-4];
Solution sl=new Solution();
sl.ThreeSum(nums);
// Submit only the Solution class to LeetCode.
public class Solution
{
        public IList<IList<int>> ThreeSum(int[] nums) {
        Array.Sort(nums);
        List<IList<int>> ans=new List<IList<int>>();
        for(int i = 0; i < nums.Length; i++)
        {
            if (i > 0  && nums[i] == nums[i - 1])
            {
                continue;//跳过重复数字找到寻找区间
            }
            int left=i+1;
            int right=nums.Length-1;
            for (; left < nums.Length; left++)
            {
                if (left > i + 1 && nums[left] == nums[left - 1])
                {
                    continue;
                }//跳过重复数字y
                while (left < right && nums[left] + nums[right] > -nums[i])
                {
                    right--;
                }
                if (left == right)
                {
                    break;

                }
                if (nums[left] + nums[right] == -nums[i])
                {
                    List<int> ints =new List<int>();
                    ints.Add(nums[i]);
                    ints.Add(nums[left]);
                    ints.Add(nums[right]);
                    ans.Add(ints);
                }
            }
        }


        return ans;
    }
}
