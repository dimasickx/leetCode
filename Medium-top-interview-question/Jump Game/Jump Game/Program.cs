namespace JumpGame
{
    public class Program
    {
        public static void Main()
        {
            
        }

        public static bool CanJump(int[] nums)
        {
            var stepsLeft = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (stepsLeft < 0)
                    return false;
                stepsLeft = (nums[i] > stepsLeft) ? nums[i] : stepsLeft;
                stepsLeft--;
            }
            return true;
        }
    }
}
