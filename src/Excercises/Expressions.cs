namespace LearnCSharp.Excercises
{
    using Helpers;
    public class Expressions
    {
        public static void FlipCoin(bool execute = false)
        {
            if (!execute)
                return;

            Random coin = new();
            int flip = coin.Next(0, 2);

            Helper.Output((flip == 0) ? "heads" : "tails");
        }

        public static void Permissions(bool execute = false)
        {
            if (!execute)
                return;

            string permission = "Admin|Manager";
            int level = 55;

            if (permission.Contains("Admin"))
            {
                if (level > 55)
                {
                    Helper.Output("Welcome, Super Admin user.");
                }
                else if (level <= 55)
                {
                    Helper.Output("Welcome, Admin user.");

                }
            }

            else if (permission.Contains("Manager"))
            {
                if (level >= 20)
                {
                    Helper.Output("Contact an Admin for access.");
                }
                else if (level < 20)
                {
                    Helper.Output("You do not have sufficient privileges.");

                }
            }
            else
            {
                Helper.Output("You do not have sufficient privileges.");
            }
        }
    }
}