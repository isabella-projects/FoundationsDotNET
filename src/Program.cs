namespace LearnCSharp
{
    using Excercises;
    using Helpers;

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
            {
                CodeBlocks.Flags();
            }

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
                GuidedProjects.AnimalSpeciesChallenge2();
                GuidedProjects.AnimalSpeciesChallenge3();
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

                Formatting.CompositeFormatting();
                Formatting.FormatCurrency();
                Formatting.NumberFormatting();
                Formatting.StringInterpolation();
                Formatting.ChallengeStrInterpolation();

                HelperMethods.IndexOfMethod();
                HelperMethods.LastIndexOf();
                HelperMethods.IndexOfAny();
                HelperMethods.Updating();
                HelperMethods.ChallengeUpdateData();
            }

            if (args.Contains("Methods"))
            {
                Methods.DisplayRandomNumbers();
                Methods.RemoveDuplicateMethods();
                Methods.IsIPAddressValid();
                Methods.ChallengeTellFortune();

                ParamMethods.DisplayAdjustedTimes(6, -6, false);
                ParamMethods.ChallengeDisplayEmail();

                ReturnValMethods.ShowDiscountedPrice();
                ReturnValMethods.ReverseWords();
            }
        }
    }
}