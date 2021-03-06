/*
Given n non-negative integers representing an elevation map where the width of each bar is 1, compute how much water it can trap after raining.

Example 1:
Input: height = [0,1,0,2,1,0,1,3,2,1,2,1]
Output: 6
Explanation: The above elevation map (black section) is represented by array [0,1,0,2,1,0,1,3,2,1,2,1]. 
In this case, 6 units of rain water (blue section) are being trapped.

Example 2:
Input: height = [4,2,0,3,2,5]
Output: 9

Constraints:
n == height.length
0 <= n <= 3 * 104
0 <= height[i] <= 105
*/

 /********************************************************************************
 Solution Category: 1
 *********************************************************************************
 Time Range:
 From: 
 To: 2021-04-19 15:11

 From: 2021-04-19 15:15
 To: 2021-04-19 15:48
 *********************************************************************************
 Submission Result:
Runtime: 92 ms, faster than 78.27% of C# online submissions for Trapping Rain Water.
Memory Usage: 25.9 MB, less than 45.21% of C# online submissions for Trapping Rain Water.

Runtime: 92 ms, faster than 78.27% of C# online submissions for Trapping Rain Water.
Memory Usage: 25.8 MB, less than 82.43% of C# online submissions for Trapping Rain Water.
 *********************************************************************************
 Note: 
    [2-pointer] [dp] [daynamic programming]
 *********************************************************************************/
public class Solution {
    public int Trap(int[] height) {
        int ans = 0;
        //dp
        if(height.Length < 3){ return ans;}

        //each dp array stores the highest point of left/right, includes itself
        int[] max_left_dp = new int[height.Length];
        max_left_dp[0] = height[0];
        int[] max_right_dp = new int[height.Length];
        max_right_dp[height.Length-1] = height[height.Length-1];

        //fill left array
        for(int i = 1; i < height.Length; i++)
        {
            max_left_dp[i] = Math.Max(max_left_dp[i-1],height[i]);
        }

        //fill right array
        for(int j = height.Length - 2; j >= 0; j--)
        {
            max_right_dp[j] = Math.Max(max_right_dp[j+1],height[j]);
        }

        for(int i = 0; i < height.Length; i++)
        {
            ans += Math.Min(max_left_dp[i],max_right_dp[i]) - height[i];
        }

        return ans;
    }

     public int Trap_two_pointers(int[] height) {
        int ans = 0;
        //two pointers one pass
        if(height.Length < 3){ return ans;}

        int l_index = 0;
        int r_index = height.Length - 1;

        //r_max and r_max means till the current one, the max, that's the reason why it's l_index < r_index in the while at beginning
        int l_max = 0;
        int r_max = 0;

        while(l_index < r_index)
        {
            if(height[l_index] < height[r_index])
            {
                //left is smaller
                if(height[l_index] < l_max){ans += (l_max - height[l_index]);}else{ l_max = height[l_index];};
                l_index++;
            }
            else
            {
                //right is smaller or equal
                if(height[r_index] < r_max){ans += (r_max - height[r_index]);}else{r_max= height[r_index];};
                r_index--;
            }
        }
       
        return ans;
    }
}