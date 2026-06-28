public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> hash = new HashSet<int>();
        foreach (int num in nums){
            bool added = hash.Add(num);
            if(!added){
                return true;
            }
        }
        return false;
        
        
    }
}