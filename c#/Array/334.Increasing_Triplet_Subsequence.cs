/*
Given an integer array nums, return true if there exists a triple of indices (i, j, k) such that i < j < k and nums[i] < nums[j] < nums[k]. If no such indices exists, return false.

 

Example 1:

Input: nums = [1,2,3,4,5]
Output: true
Explanation: Any triplet where i < j < k is valid.
Example 2:

Input: nums = [5,4,3,2,1]
Output: false
Explanation: No triplet exists.
Example 3:

Input: nums = [2,1,5,0,4,6]
Output: true
Explanation: The triplet (3, 4, 5) is valid because nums[3] == 0 < nums[4] == 4 < nums[5] == 6.
 

Constraints:

1 <= nums.length <= 105
-231 <= nums[i] <= 231 - 1
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
    //
    public bool IncreasingTriplet(int[] nums) {
        int first = int.MaxValue;
        int second = int.MaxValue;
        
        for(int i =0; i < nums.Length; i++)
        {
            if(nums[i] <= first)
            {
                first = nums[i];
            }
            else if(nums[i] <= second)
            {
                second = nums[i];
            }
            else
            {
                return true;   
            }
        }
        
        return false;
    }
}