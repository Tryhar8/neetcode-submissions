public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var arr = s.ToCharArray();
        Dictionary<char, int> dic = new Dictionary<char, int>();
        int currL = 0;
        int longestL = 0;

        for(int i = 0; i < arr.Length; i++) {
            char c = arr[i];
            if(dic.ContainsKey(c)) {
                i = dic[c];
                dic.Clear();
                if(longestL < currL)
                    longestL = currL;
                currL = 0;
            } else {
                currL += 1;
                dic.Add(c, i);
            }
        }
        if(currL > longestL)
            longestL = currL;
        
        return longestL;
    }
}
