class Solution {
    /**
     * @param {number[]} nums
     * @param {number} k
     * @return {number[]}
     */
    topKFrequent(nums, k) {
        const map = new Map();
        const result = [];
        nums.forEach(num => {
            map.has(num) ? map.set(num, map.get(num) + 1) : map.set(num, 1);
        });

        map.forEach((val, key) => {
            result.push({val, key});
        });

        result.sort((a, b) => b.val - a.val);

        return result.splice(0, k).map((obj) => obj.key);
    }
}
