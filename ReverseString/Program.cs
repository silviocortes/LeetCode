using System;

namespace ReverseString
{

    //      Write a function that reverses a string. The input string is given as an array of characters char[].

    //      Do not allocate extra space for another array, you must do this by modifying the input array in-place with O(1) extra memory.

    //      You may assume all the characters consist of printable ascii characters.

 

    //      Example 1:

    //      Input: ["h","e","l","l","o"]
    //      Output: ["o","l","l","e","h"]
    //      Example 2:

    //      Input: ["H","a","n","n","a","h"]
    //      Output: ["h","a","n","n","a","H"]
    class MainClass
    {
        public static void Main(string[] args)
        {
            do
            {
                char[] input = Console.ReadLine().ToCharArray();

                ReverseBrute(input);
                Console.WriteLine(new string(input));

                ReverseC(input);
                Console.WriteLine(new string(input));


            } while (!(Console.ReadLine().Equals("end")));
        }

        public static void ReverseBrute(Char[] s)
        {
            int startPosition = 0;
            int endPosition = s.Length - 1;
            while (startPosition < endPosition)
            {
                char temp = s[startPosition];
                s[startPosition] = s[endPosition];
                s[endPosition] = temp;
                startPosition++;
                endPosition--;
            }
        }

        //using C# builtin function
        public static void ReverseC(char[] s)
        {
            Array.Reverse(s);
        }

        }
    }
}
