public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        HashSet<String> tempBucket = new HashSet<String>();
        Array.Sort(nums);
        Console.WriteLine(nums);

        for (int i = 0; i < nums.Length; i++) {
            int _i = nums[i];
            if (_i > 0)
                break;

            for (int j = i + 1; j < nums.Length; j++) {
                int _j = nums[j];

                if (_i + _j > 0)
                    break;

                for (int k = j + 1; k < nums.Length; k++) {
                    int _k = nums[k];
                    if (_i + _j + _k == 0) {
                        tempBucket.Add(_i.ToString() + "," + _j.ToString() + "," + _k.ToString());
                        break;
                    } else if (_i + _j + _k > 0)
                        break;
                }
            }
        }
        return tempBucket.Select(s => s.Split(",")
                         .Select(s => { 
                            int.TryParse(s, out int num);
                            return num;
                            }).ToList())
                            .ToList();
    }
}
