public int[] TwoSum(int[] nums, int target) {
    int[] returnArray = new int[2];

    for (int i = 0; i < nums.Length; i++) 
    {
        for (int j = 0; j < nums.Length; j++)
        {
            if (i != j && (nums[i] + nums[j]) == target)
            {
                returnArray[0] = i;
                returnArray[1] = j;
            }
        }
    }

    return returnArray;
}

public bool 