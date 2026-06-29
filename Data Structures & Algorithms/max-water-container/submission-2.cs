public class Solution {
    public int MaxArea(int[] heights) {
        int end_sum = 0;
        int curr_sum = 0;

        for(int i = 0; i < heights.Length; i++) {
            var val = heights[i];
            for(int j = i+1; j < heights.Length; j++) {
                curr_sum = 0;
                var val2 = heights[j];
                int multiplier = j - i;
                curr_sum += ((val2 > val ? val : val2) * multiplier);
                if(curr_sum > end_sum)
                    end_sum = curr_sum;
            }
        }
        return end_sum;
    }
}
