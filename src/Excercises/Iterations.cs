using LearnCSharp.Helpers;

namespace LearnCSharp.Excercises
{
    public class Iterations
    {
        public static void LoopPeople(bool execute = false)
        {
            if (!execute)
                return;

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

        public static void ChallengeFizzBuzz(bool execute = false)
        {
            if (!execute)
                return;

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

        public static void LoopRandom(bool execute = false)
        {
            if (!execute)
                return;

            Random random = new();
            int current;

            do
            {
                current = random.Next(1, 11);

                if (current >= 8) continue;

                Helper.Output(current.ToString());
            } while (current != 7);
        }

        public static void ChallengeGameBattle(bool execute = false)
        {
            if (!execute)
                return;

            int hero = 10;
            int monster = 10;

            Random dice = new();

            do
            {
                int roll = dice.Next(1, 11);
                monster -= roll;
                Helper.Output($"Monster was damaged and lost {roll} HP and now has {monster} HP.");

                if (monster <= 0)
                    continue;

                roll = dice.Next(1, 11);
                hero -= roll;
                Helper.Output($"Hero was damaged and lost {roll} HP and now has {hero} HP.");

            } while (hero > 0 && monster > 0);

            Helper.Output(hero > monster ? "Hero wins!" : "Monster wins!");
        }

        public static void UserInput(bool execute = false)
        {
            if (!execute)
                return;

            string? readResult;
            bool validEntry = false;
            Helper.Output("Enter a string containing at least three characters:");
            do
            {
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    if (readResult.Length >= 3)
                    {
                        validEntry = true;
                        Helper.Output($"Afformative! You wrote '{readResult}'");
                    }
                    else
                    {
                        Helper.Output("Your input must contain at least 3 characters!");
                    }
                }
            } while (validEntry == false);
        }

        public static void ValidateIntegerInput(bool execute = false)
        {
            if (!execute)
                return;

            string? readResult;
            string valueEntered = "";
            int numValue = 0;
            bool validNumber = false;

            Helper.Output("Enter an integer between 5 and 10.");

            do
            {
                readResult = Console.ReadLine();

                if (readResult != null)
                {
                    valueEntered = readResult;
                    Helper.Output(valueEntered);
                }

                validNumber = int.TryParse(valueEntered, out numValue);

                if (validNumber == true)
                {
                    if (numValue <= 5 || numValue >= 10)
                    {
                        validNumber = false;
                        Helper.Output($"You entered {numValue}. Please enter a number between 5 and 10.");
                    }
                }
                else
                {
                    Helper.Output("Sorry, you entered an invalid number, please try again.");
                }

            } while (validNumber == false);

            Helper.Output($"Your input value ({numValue}) has been accepted.");
        }

        public static void ValidateStringInput(bool execute = false)
        {
            if (!execute)
                return;

            string? readResult;
            string roleName = "";
            bool validEntry = false;

            do
            {
                Helper.Output("Enter your role name (Administrator, Manager, or User)");
                readResult = Console.ReadLine();
                if (readResult != null)
                {
                    roleName = readResult.Trim();
                }

                if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user")
                {
                    validEntry = true;
                }
                else
                {
                    Helper.Output($"The role name that you entered, \"{roleName}\" is not valid. ");
                }

            } while (validEntry == false);

            Helper.Output($"Your input value ({roleName}) has been accepted.");
        }

        public static void ProcessStringArrContent(bool execute = false)
        {
            if (!execute)
                return;

            string[] myStrings = ["I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices"];
            int stringsCount = myStrings.Length;
            for (int i = 0; i < stringsCount; i++)
            {
                string myString = myStrings[i];
                int periodLocation = myString.IndexOf(".");
                string mySentence;

                // extract sentences from each string and display them one at a time
                while (periodLocation != -1)
                {

                    // first sentence is the string value to the left of the period location
                    mySentence = myString.Remove(periodLocation);

                    // the remainder of myString is the string value to the right of the location
                    myString = myString.Substring(periodLocation + 1);

                    // remove any leading white-space from myString
                    myString = myString.TrimStart();

                    // update the comma location and increment the counter
                    periodLocation = myString.IndexOf(".");

                    Console.WriteLine(mySentence);
                }

                mySentence = myString.Trim();
                Console.WriteLine(mySentence);
            }
        }
    }
}