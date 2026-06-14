class Solution {
    /**
     * @param {string[]} strs
     * @return {string[][]}
     */
    groupAnagrams(strs) {
        if(strs.length === 0)
            return [[""]];

        const hashedValues = new Map()
        const result = [];
        strs.forEach((str) => {
            const sortedWord = str.split('').sort().join();

            if(hashedValues.has(sortedWord))
                hashedValues.set(sortedWord, [...hashedValues.get(sortedWord), str])
            else hashedValues.set(sortedWord, [str]);
        });

        
        hashedValues.forEach((key, val) => {
            result.push(key);
        });
        return result;
    }
}
