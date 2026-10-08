#:property PublishAot=false

using System;
using System.Collections.Generic;

// Local test: change the input here when practicing.

string[] strings=["eat", "tea", "tan", "ate", "nat", "bat"];
Solution s=new Solution();

// Submit only the Solution class to LeetCode.
public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        // 思路：字母异位词包含相同的字母和相同的出现次数，排序后的字符串一定相同。
        // 例如 eat、tea、ate 排序后都是 aet，因此可以用排序结果作为分组的键。
        // 用字典保存“排序后的字符串 -> 原字符串列表”，把同一个键的单词归到一组。
        // 设单词数为 n、最长单词长度为 k，时间复杂度为 O(n * k * log k)。
        // 除输入外，最坏空间复杂度为 O(n * k)，主要用于分组键和结果列表。
        Dictionary<string, List<string>> stringmap =
            new Dictionary<string, List<string>>();

        foreach (string s in strs)
        {
            // 排序字符副本以生成统一的分组键，保留原字符串作为结果。
            char[] chars = s.ToCharArray();
            Array.Sort(chars);

            string key = new string(chars);

            if (stringmap.ContainsKey(key))
            {
                // 已有相同排序结果，加入现有的异位词分组。
                stringmap[key].Add(s);
            }
            else
            {
                // 第一次遇到这个键，创建分组，并放入当前单词。
                stringmap[key] = new List<string> { s };
            }
        }

        // 字典的值就是所有分组；按返回类型把每一组放入结果列表。
        IList<IList<string>> result = new List<IList<string>>();

        foreach (List<string> group in stringmap.Values)
        {
            result.Add(group);
        }

        return result;
    }
}
