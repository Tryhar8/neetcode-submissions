public class Solution {
    private int lowestPrice = -1;
    private int price = 0;
    private int result = 0;
    private int tempRes = 0;

    public int MaxProfit(int[] prices) {
        for(int i = 0; i < prices.Length; i++) {
            price = prices[i];
            if(lowestPrice < 0 || lowestPrice > price)
                lowestPrice = price;
            
            tempRes = price - lowestPrice;
            if(tempRes > result)
                result = tempRes;
        }

        return result;
    }
}
