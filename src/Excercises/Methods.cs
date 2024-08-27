namespace LearnCSharp.Excercises
{
    using Helpers;

    public class Methods
    {
        public static void DisplayRandomNumbers(bool execute = false)
        {
            if (!execute)
                return;

            Console.WriteLine("Generating random numbers:");

            Random random = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"{random.Next(1, 100)} ");
            }
        }

        public static void RemoveDuplicateMethods(bool execute = false)
        {
            if (!execute)
                return;

            int[] times = { 800, 1200, 1600, 2000 };
            int diff = 0;

            Console.WriteLine("Enter current GMT");
            int currentGMT = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Current Medicine Schedule:");

            DisplayTimes(times);

            Console.WriteLine("Enter new GMT");

            int newGMT = Convert.ToInt32(Console.ReadLine());

            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
                AdjustTimes(times, diff);
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
                AdjustTimes(times, diff);
            }

            Console.WriteLine("New Medicine Schedule:");
            DisplayTimes(times);
        }

        private static void DisplayTimes(int[] times)
        {
            foreach (int val in times)
            {
                string time = val.ToString();
                int len = time.Length;

                if (len >= 3)
                {
                    time = time.Insert(len - 2, ":");
                }
                else if (len == 2)
                {
                    time = time.Insert(0, "0:");
                }
                else
                {
                    time = time.Insert(0, "0:0");
                }

                Console.Write($"{time} ");
            }

            Console.WriteLine();
        }

        private static void AdjustTimes(int[] times, int diff)
        {
            for (int i = 0; i < times.Length; i++)
            {
                times[i] = (times[i] + diff) % 2400;
            }
        }

        public static void IsIPAddressValid(bool execute = false)
        {
            if (!execute)
                return;

            Console.WriteLine("Enter IP addresses separated by spaces:");
            string? input = Console.ReadLine();
            string[] ipv4Input = input?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();

            foreach (string ip in ipv4Input)
            {
                string[] address = ip.Split('.', StringSplitOptions.RemoveEmptyEntries);

                bool validLength = ValidateLength(address);
                bool validZeroes = ValidateZeroes(address);
                bool validRange = ValidateRange(address);

                if (validLength && validZeroes && validRange)
                {
                    Console.WriteLine($"{ip} is a valid IPv4 address");
                }
                else
                {
                    Console.WriteLine($"{ip} is an invalid IPv4 address");
                }
            }
        }

        private static bool ValidateLength(string[] address)
        {
            return address.Length == 4;
        }

        private static bool ValidateZeroes(string[] address)
        {
            foreach (string number in address)
            {
                if (number.Length > 1 && number.StartsWith("0"))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool ValidateRange(string[] address)
        {
            foreach (string number in address)
            {
                if (!int.TryParse(number, out int value) || value < 0 || value > 255)
                {
                    return false;
                }
            }
            return true;
        }

        public static void ChallengeTellFortune(bool execute = false)
        {
            if (!execute)
                return;

            Random random = new Random();
            int luck = random.Next(100);

            string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
            string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
            string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
            string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

            TellFortune(luck, text, good, bad, neutral);
        }

        private static void TellFortune(int luck, string[] text, string[] good, string[] bad, string[] neutral)
        {
            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = luck > 75 ? good : (luck < 25 ? bad : neutral);
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
        }
    }

    public class ParamMethods
    {
        private static readonly int[] schedule = { 800, 1200, 1600, 2000 };

        public static void DisplayAdjustedTimes(int currentGMT, int newGMT, bool execute = false)
        {
            if (!execute)
                return;

            int diff = 0;
            if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
            {
                Console.WriteLine("Invalid GMT");
            }
            else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0)
            {
                diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            }
            else
            {
                diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            }

            for (int i = 0; i < schedule.Length; i++)
            {
                int newTime = (schedule[i] + diff) % 2400;
                Console.WriteLine($"{schedule[i]} -> {newTime}");
            }
        }

        public static void ChallengeDisplayEmail(bool execute = false)
        {
            if (!execute)
                return;

            string[,] corporate =
            {
                {"Robert", "Bavin"}, {"Simon", "Bright"},
                {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
                {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
            };

            string[,] external =
            {
                {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
                {"Shay", "Lawrence"}, {"Daren", "Valdes"}
            };

            string externalDomain = "hayworth.com";

            for (int i = 0; i < corporate.GetLength(0); i++)
            {
                Helper.Output(corporate[i, 0]);
                Helper.Output(corporate[i, 1]);
                DisplayEmail(corporate[i, 0], corporate[i, 1]);
            }

            for (int i = 0; i < external.GetLength(0); i++)
            {
                Helper.Output(external[i, 0]);
                Helper.Output(external[i, 1]);
                DisplayEmail(external[i, 0], external[i, 1], externalDomain);
            }
        }

        private static void DisplayEmail(string first, string last, string domain = "contoso.com")
        {
            string email = first.Substring(0, 2) + last;
            email = email.ToLower();
            Helper.Output($"{email}@{domain}");
        }
    }

    public class ReturnValMethods
    {
        private static double total = 0;
        private static readonly double minimumSpend = 30.00;

        private static readonly double[] items = { 15.97, 3.50, 12.25, 22.99, 10.98 };
        private static readonly double[] discounts = { 0.30, 0.00, 0.10, 0.20, 0.50 };

        private const string word = "snake";

        public static void ShowDiscountedPrice(bool execute = false)
        {
            if (!execute)
                return;

            for (int i = 0; i < items.Length; i++)
            {
                total += GetDiscountedPrice(i);
            }

            total -= TotalMeetsMinimum() ? 5.00 : 0.00;
            Helper.Output($"Total: ${FormatDecimal(total)}");
        }

        private static double GetDiscountedPrice(int itemIndex)
        {
            return items[itemIndex] * (1 - discounts[itemIndex]);
        }

        private static bool TotalMeetsMinimum()
        {
            return total >= minimumSpend;
        }

        private static string FormatDecimal(double input)
        {
            return input.ToString().Substring(0, 5);
        }

        public static string ReverseWords(string reverseString = word, bool execute = false)
        {
            if (!execute)
                return string.Empty;

            string result = "";

            for (int i = reverseString.Length - 1; i >= 0; i--)
            {
                result += reverseString[i];
            }

            return result;
        }
    }
}