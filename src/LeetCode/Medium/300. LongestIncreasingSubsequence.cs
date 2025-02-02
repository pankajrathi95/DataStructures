/*
https://leetcode.com/problems/longest-increasing-subsequence/
Given an integer array nums, return the length of the longest strictly increasing subsequence.

A subsequence is a sequence that can be derived from an array by deleting some or no elements without changing the order of the remaining elements. For example, [3,6,2,7] is a subsequence of the array [0,3,1,6,2,2,7].

 

Example 1:

Input: nums = [10,9,2,5,3,7,101,18]
Output: 4
Explanation: The longest increasing subsequence is [2,3,7,101], therefore the length is 4.
Example 2:

Input: nums = [0,1,0,3,2,3]
Output: 4
Example 3:

Input: nums = [7,7,7,7,7,7,7]
Output: 1
 

Constraints:

1 <= nums.length <= 2500
-104 <= nums[i] <= 104
 

Follow up:

Could you come up with the O(n2) solution?
Could you improve it to O(n log(n)) time complexity?
*/

using System;

public class LongestIncreasingSubsequence
{
    public int LengthOfLIS(int[] nums)
    {
        if (nums.Length == 0)
        {
            return 0;
        }

        int[] lis = new int[nums.Length];
        int max = 1;

        for (int i = 0; i < nums.Length; i++)
        {
            lis[i] = 1;
            for (int j = 0; j < i; j++)
            {
                if (nums[i] > nums[j] && lis[i] < lis[j] + 1)
                {
                    lis[i] = lis[j] + 1;
                    max = Math.Max(max, lis[i]);
                }
            }
        }

        return max;
    }
}