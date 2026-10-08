#:property PublishAot=false

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

// Local test: change the input here when practicing.
int[] nums= [100,4,200,1,3,2];
Solution solution=new Solution();
Console.WriteLine(solution.LongestConsecutive(nums));
// Submit only the Solution class to LeetCode.
public class Solution
{
    public int LongestConsecutive(int[] nums) {
            int answer=0;
            HashSet<int> ints=nums.ToHashSet();
            int cur=0;
            int length=0;
            foreach( int num in nums)
        {
            if (!ints.Contains(num-1))
            {
                cur=num;
                length=1;
             while (ints.Contains(cur+1))
            {
                cur++;
                length++;
            }
            answer=Math.Max(answer,length);
            }
        }
        return answer;
    }
}
