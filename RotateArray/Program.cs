using System;

namespace RotateArray
{
    //  https://leetcode.com/problems/rotate-array/
    //    Given an array, rotate the array to the right by k steps, where k is non-negative.

    //Example 1:

    //Input: [1,2,3,4,5,6,7]
    //    and k = 3
    //Output: [5,6,7,1,2,3,4]
    //    Explanation:
    //rotate 1 steps to the right: [7,1,2,3,4,5,6]
    //    rotate 2 steps to the right: [6,7,1,2,3,4,5]
    //    rotate 3 steps to the right: [5,6,7,1,2,3,4]
    //    Example 2:

    //Input: [-1,-100,3,99]
    //    and k = 2
    //Output: [3,99,-1,-100]
    //    Explanation: 
    //rotate 1 steps to the right: [99,-1,-100,3]
    //    rotate 2 steps to the right: [3,99,-1,-100]

    public class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                String[] input = Console.ReadLine().Split(' ');
                int[] nums = new int[input.Length];

                for (int i = 0; i < input.Length; i++)
                {
                    nums[i] = Convert.ToInt16(input[i]);
                }

                int positionsToRotate = Convert.ToInt16(Console.ReadLine());

                // brute
                // RotateBrute(nums, positionsToRotate);
               
                 // faster
                RotateBetter(nums, positionsToRotate);


                for (int i = 0; i < nums.Length; i++)
                {
                    Console.Write(nums[i].ToString() + ' ');
                }
                Console.WriteLine();

            } while (!(Console.ReadLine().Equals("end")));
        }

        public static void RotateBrute(int[] nums, int k) //brute force O(n * k)
        {
            if (k > 0)
            {
                int positionsRotated = 1;
                while (positionsRotated <= k)
                {
                    int valueToRotate = nums[nums.Length - 1];
                    for(int i = nums.Length - 1; i > 0; i--)
                    {
                        nums[i] = nums[i - 1];
                    }
                    nums[0] = valueToRotate;
                    positionsRotated++;
                }
            }
        }

        public static void RotateBetter(int[] nums, int k) //better solution O(n*3) -> O(n)
        {
            k = k % nums.Length;
            Reverse(nums, 0, nums.Length - 1);
            Reverse(nums, 0, k - 1);
            Reverse(nums, k, nums.Length - 1);
        }

        public static void Reverse(int[] nums, int startPosition, int endPosition)
        {
            while (startPosition < endPosition)
            {
                int temp = nums[startPosition];
                nums[startPosition] = nums[endPosition];
                nums[endPosition] = temp;
                startPosition++;
                endPosition--;
            }
        }

    }
}
