using LearnCSharp.Helpers;

namespace LearnCSharp.Excercises
{
    public class Iterations
    {
        public static void LoopPeople()
        {
            string[] names = ["Alex", "Eddie", "David", "Michael"];

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i] == "David")
                {
                    names[i] = "Sammy";
                }
            }

            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }

        public static void ChallengeFizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                string result = (i % 3, i % 5) switch
                {
                    (0, 0) => "FizzBuzz",
                    (0, _) => "Fizz",
                    (_, 0) => "Buzz",
                    _ => i.ToString(),
                };

                Helper.Output(result == i.ToString() ? result : $"{i} - {result}");
            }
        }
    }
}