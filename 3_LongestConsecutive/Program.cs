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
/*
这题我一开始就想到了对每个值使用while遍历但我认为时间复杂度是O（n的平方）然后改用了检查前一个值跟
跟后一个值是否存在hash里如果存在的话标记为true 到时候再遍历一遍发现这样得到的是相邻的数
如 123467这样的序列答案就是6 
不要想着“内部循环对每个元素会运行多少次”，而是要计算整个程序中的总操作次数。

*/