/*
Given an array of integers nums containing n + 1 integers where each integer is in the range [1, n] inclusive.

There is only one repeated number in nums, return this repeated number.

 

Example 1:

Input: nums = [1,3,4,2,2]
Output: 2
Example 2:

Input: nums = [3,1,3,4,2]
Output: 3
Example 3:

Input: nums = [1,1]
Output: 1
Example 4:

Input: nums = [1,1,2]
Output: 1
 

Constraints:

2 <= n <= 3 * 104
nums.length == n + 1
1 <= nums[i] <= n
All the integers in nums appear only once except for precisely one integer which appears two or more times.
 

Follow up:

How can we prove that at least one duplicate number must exist in nums?
Can you solve the problem without modifying the array nums?
Can you solve the problem using only constant, O(1) extra space?
Can you solve the problem with runtime complexity less than O(n2)?
*/


/********************************************************************************
Solution Category: 

*********************************************************************************
Time Range:
From: 
To: 
*********************************************************************************
Submission Result:

*********************************************************************************
Note: 
//Floyd's Tortoise and Hare?????
*********************************************************************************/
public class Solution {
    public int FindDuplicate(int[] nums) {
        /*
        Runtime: 100 ms, faster than 51.97% of C# online submissions for Find the Duplicate Number.
        Memory Usage: 27.1 MB, less than 26.38% of C# online submissions for Find the Duplicate Number.
        */
        Dictionary<int,int> dict = new Dictionary<int,int>();

        for(int i =0; i < nums.Length;i++)
        {
            if(dict.Keys.Contains(nums[i]))
            {
                return nums[i];
            }
            else
            {
                dict[nums[i]]= 1;
            }
        }

        return -1;
    }

    public int FindDuplicate_sort(int[] nums) {
        /*
        Runtime: 96 ms, faster than 76.15% of C# online submissions for Find the Duplicate Number.
        Memory Usage: 25.9 MB, less than 84.99% of C# online submissions for Find the Duplicate Number.
        */
       Array.Sort(nums);

       for(int i = 1; i< nums.Length;i++)
       {
           if((nums[i] - nums[i-1])==0)
           {
               return nums[i];
           }
       }

       return -1;
    }
}