namespace ConsoleApp1
{
    internal class Program
    {

        static int[] product(int[] nums)
        {

            int n = nums.Length;
            int[] output = new int[n];


            for (int i = 0; i < n; i++)
            {
                output[i] = 1;
            }

            int left = 1;
            for (int i = 0; i < n; i++)
            {
                output[i] *= left;
                left *= nums[i];
            }

            int right = 1;
            for (int i = n - 1; i >= 0; i--)
            {
                output[i] *= right;
                right *= nums[i];
            }

            return output;
        }

        static void Main()
        {
            Console.WriteLine("Enter elements of array : ");
            string input = Console.ReadLine();
            string[] stringArray = input.Split(' ');
            int[] nums = new int[stringArray.Length];

            for (int i = 0; i < stringArray.Length; i++)
            {
                nums[i] = int.Parse(stringArray[i]);
            }

            int[] result = product(nums);

            foreach(int i in result)
            {
                Console.WriteLine(i);
            }
        }

    }
}
