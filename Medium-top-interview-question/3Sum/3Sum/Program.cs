namespace Sum3 
{ 
    public class Program
    {
        public static void Main()
        {
            
        }
        public static IList<IList<int>> ThreeSum(int[] nums)  // -4 -1 -1 0 1 2
        {
            Array.Sort(nums);
            var result = new List<IList<int>>();   
            for (int i = 0; i < nums.Length; i++)
            {
                if (i > 0 && nums[i] == nums[i - 1])
                    continue;
                var pointerL = i + 1;
                var pointerR = nums.Length - 1;
                while (pointerL < pointerR)
                {
                    var sum = nums[i] + nums[pointerL] + nums[pointerR];
                    if (sum == 0)
                    {
                        result.Add(new List<int>() { nums[i], nums[pointerL], nums[pointerR] });
                        while (pointerL < pointerR && nums[pointerL] == nums[pointerL + 1])
                            pointerL++;
                        pointerL++;
                    }
                    else if (sum < 0)
                        pointerL++;
                    else
                        pointerR--;
                }
            }
            return result;
        }
    }
}

