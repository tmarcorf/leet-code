namespace _1_1480._Running_Sum_of_1d_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.Read();
        }

        public int[] RunningSum(int[] nums)
        {
            int[] arrayResult = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                arrayResult[i] = SumUntilPosition(nums, i);
            }

            return arrayResult;
        }

        private int SumUntilPosition(int[] nums, int position)
        {
            int sumResult = 0;

            for (int i = 0; i <= position; i++)
            {
                sumResult += nums[i];
            }

            return sumResult;
        }
    }
}
