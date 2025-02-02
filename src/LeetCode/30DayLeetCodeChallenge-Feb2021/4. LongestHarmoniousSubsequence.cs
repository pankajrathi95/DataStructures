/*
#594 - https://leetcode.com/problems/longest-harmonious-subsequence/

We define a harmonious array as an array where the difference between its maximum value and its minimum value is exactly 1.

Given an integer array nums, return the length of its longest harmonious subsequence among all its possible subsequences.

A subsequence of array is a sequence that can be derived from the array by deleting some or no elements without changing the order of the remaining elements.

 

Example 1:

Input: nums = [1,3,2,2,5,2,3,7]
Output: 5
Explanation: The longest harmonious subsequence is [3,2,2,2,3].
Example 2:

Input: nums = [1,2,3,4]
Output: 2
Example 3:

Input: nums = [1,1,1,1]
Output: 0
 

Constraints:

1 <= nums.length <= 2 * 104
-109 <= nums[i] <= 109
*/

using System;
using System.Collections.Generic;

public class LongestHarmoniousSubsequence
{
    public int FindLHS(int[] nums)
    {
        Dictionary<int, int> values = new Dictionary<int, int>();
        foreach (var num in nums)
        {
            if (!values.ContainsKey(num))
            {
                values.Add(num, 1);
            }
            else
            {
                values[num]++;
            }
        }

        int max = 0;
        foreach (var kvp in values)
        {
            if (values.ContainsKey(kvp.Key + 1))
            {
                max = Math.Max(max, values[kvp.Key] + values[kvp.Key + 1]);
            }
        }

        return max;
    }
}