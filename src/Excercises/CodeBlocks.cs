namespace LearnCSharp.Excercises
{
    using Helpers;
    public class CodeBlocks
    {
        public static void Flags()
        {
            int[] numbers = [4, 8, 15, 16, 23, 42];
            int total = 0;
            bool found = false;

            foreach (int number in numbers)
            {
                total += number;

                if (number == 42)
                {
                    found = true;
                }

            }

            if (found)
            {
                Helper.Output("Set contains 42");

            }

            Helper.Output($"Total: {total}");
        }
    }
}