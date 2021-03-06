/*
27. Remove Element
test

Given an array [nums] and a value val, remove all instances of that value in-place and return the new length.

Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

The order of elements can be changed. It doesn't matter what you leave beyond the new length.

Clarification:

Confused why the returned value is an integer but your answer is an array?

Note that the input array is passed in by reference, which means a modification to the input array will be known to the caller as well.

*/
/* 
    Example 1:
    Input: nums = [3,2,2,3], val = 3
    Output: 2, nums = [2,2]
    Explanation: Your function should return length = 2, with the first two elements of nums being 2.
    It doesn't matter what you leave beyond the returned length. For example if you return 2 with nums = [2,2,3,3] or nums = [2,2,0,0], your answer will be accepted.
*/

/* 
    Example 2:
    Input: nums = [0,1,2,2,3,0,4,2], val = 2
    Output: 5, nums = [0,1,4,0,3]
    Explanation: Your function should return length = 5, with the first five elements of nums containing 0, 1, 3, 0, and 4. Note that the order of those five elements can be arbitrary. 
    It doesn't matter what values are set beyond the returned length.
    */

/* 
    Constraints
    0 <= nums.length <= 100
    0 <= nums[i] <= 50
    0 <= val <= 100
*/
/*
    1st, on 3/16/2021
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

*********************************************************************************/
public class Solution {
    public int RemoveElement(int[] nums, int val) {
        //the official solution use i instead of ValueCount and j in stead of i
        int ValueCount = 0;
        
        if(nums.Length > 0)
        {
            for(int i=0;i<nums.Length;i++)
            {
                if (val != nums[i])
                {
                    nums[ValueCount] = nums[i];
                    ValueCount++;
                }
            }
        }
       
        return ValueCount;
    }

    public int RemoveElement_current(int[] nums, int val) {
        //above is wrong, array in java is different from C#
        int j = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[j] = nums[i];
                j++;
            }
        }

        //below is a must for C# since nums[j] = nums[i] won't cut the val ones
        Array.Resize(ref nums, j);
        return j;
    }
}
