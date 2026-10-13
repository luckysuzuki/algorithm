#:property PublishAot=false

using System;
using System.Collections.Generic;

// Local test: change the input here when practicing.
int[] height=[1,8,6,2,5,4,8,3,7];
Solution sl=new Solution();
sl.MaxArea(height);
// Submit only the Solution class to LeetCode.
public class Solution
{
    public int MaxArea(int[] height) {
        int right=height.Length-1;
        int ans=0;
        int left=0;
        while(left<right){
            ans=Math.Max((right-left)*Math.Min(height[right],height[left]),ans);
            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
            
        }
    return ans;
    }
}
