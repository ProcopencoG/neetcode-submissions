public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        foreach (int num in nums){
            int need = target - num;
            if(Array.IndexOf(nums, need)!= -1 && Array.IndexOf(nums, need)!= Array.LastIndexOf(nums, num)){
                return new int[] {Array.IndexOf(nums, num), Array.LastIndexOf(nums, need) };
            }
        }
        return new int[] {0,0};

    }
}
