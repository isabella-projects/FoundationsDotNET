namespace LearnCSharp
{
    using Excercises;

    public class Program
    {
        // Set method param on true where it's applicable to run the method if needed
        public static void Main(string[] args)
        {
            if (args.Contains("Expressions"))
            {
                Expressions.FlipCoin();
                Expressions.Permissions();
            }

            if (args.Contains("Codeblocks"))
                CodeBlocks.Flags();

            if (args.Contains("SwitchStatement"))
            {
                SwitchStatement.EmployeeLevel();
                SwitchStatement.ChallengeSwitch();
                SwitchStatement.ChallengeExpression();
            }

            if (args.Contains("Iterations"))
            {
                Iterations.LoopPeople();
                Iterations.ChallengeFizzBuzz();
                Iterations.LoopRandom();
                Iterations.ChallengeGameBattle();
                Iterations.UserInput();
                Iterations.ValidateIntegerInput();
                Iterations.ValidateStringInput();
                Iterations.ProcessStringArrContent();
            }

            if (args.Contains("GuidedProjects"))
            {
                GuidedProjects.JaggedArray(false);
                GuidedProjects.AnimalSpecies(false);
            }
        }
    }
}