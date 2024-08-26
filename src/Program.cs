namespace LearnCSharp
{
    using Excercises;

    public class Program
    {
        /**
        * All Methods are disabled by default
        * To turn and check the method's execution
        * pass 'true' to the method.
        */
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
                GuidedProjects.JaggedArray();
                GuidedProjects.AnimalSpecies();
                GuidedProjects.AnimalSpeciesChallenge();
            }

            if (args.Contains("DataTypes"))
            {
                DataTypes.SignedAndUnsignedITypes();
                DataTypes.FloatingTypes();
                DataTypes.ReferenceTypes();
                DataTypes.DataTypeConversion();
                DataTypes.TryParseMethod(false, "appropriate");
                DataTypes.ChallengeCombineValues();
                DataTypes.ChallengeMathOpNumTypes();

                ArrayOperations.Sorting();
                ArrayOperations.Resizing();
                ArrayOperations.CharArrays();
                ArrayOperations.Joining();
                ArrayOperations.Splitting();
                ArrayOperations.ChallengeReverseWords();
                ArrayOperations.ChallengeParseStrOfOrders();
            }
        }
    }
}