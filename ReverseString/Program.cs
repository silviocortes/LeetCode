using System;

namespace ReverseString
{
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

                ReverseAlternative(input);
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
