namespace LearnCSharp.Excercises
{
    using System.Globalization;
    using Helpers;
    public class DataTypes
    {
        public static void SignedAndUnsignedITypes(bool execute = false)
        {
            if (!execute)
                return;

            Console.WriteLine("Signed integral types:");

            Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
            Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

            Console.WriteLine("");
            Console.WriteLine("Unsigned integral types:");

            Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
            Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
            Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");
        }

        public static void FloatingTypes(bool execute = false)
        {
            if (!execute)
                return;

            Console.WriteLine("");
            Console.WriteLine("Floating point types:");
            Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
            Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
            Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");
        }

        public static void ReferenceTypes(bool execute = false)
        {
            if (!execute)
                return;

            int[] ref_A = new int[1];
            ref_A[0] = 2;
            int[] ref_B = ref_A;
            ref_B[0] = 5;

            Console.WriteLine("--Reference Types--");
            Console.WriteLine($"ref_A[0]: {ref_A[0]}");
            Console.WriteLine($"ref_B[0]: {ref_B[0]}");
        }

        public static void DataTypeConversion(bool execute = false)
        {
            if (!execute)
                return;

            decimal myDecimal = 3.14m;
            Console.WriteLine($"decimal: {myDecimal}");

            int myInt = (int)myDecimal;
            Console.WriteLine($"int: {myInt}");

            Helper.BREAK();

            decimal yourDecimal = 1.23456789m;
            float myFloat = (float)yourDecimal;

            Console.WriteLine($"Decimal: {yourDecimal}");
            Console.WriteLine($"Float  : {myFloat}");

            Helper.BREAK();

            int first = 5;
            int second = 7;
            string message = first.ToString() + second.ToString();
            Console.WriteLine(message);

            Helper.BREAK();

            string firstStr = "5";
            string secondStr = "7";
            int sum = int.Parse(firstStr) + int.Parse(secondStr);
            Console.WriteLine(sum);

            Helper.BREAK();

            // Using the Convert class is safer from the .NET Class Library
            string value1 = "5";
            string value2 = "7";
            int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
            Console.WriteLine(result);

            Helper.BREAK();

            int val = (int)1.5m; // casting truncates
            Console.WriteLine(val);

            int val1 = Convert.ToInt32(1.5m); // converting rounds up
            Console.WriteLine(val1);
        }

        public static void TryParseMethod(bool execute = false, string usageCase = "appropriate")
        {
            if (!execute)
                return;

            string value;

            switch (usageCase)
            {
                case "appropriate":
                    value = "102";

                    if (int.TryParse(value, out int result))
                    {
                        Console.WriteLine($"Measurement: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Unable to report the measurement.");
                    }

                    Console.WriteLine($"Measurement (w/ offset): {50 + result}");
                    break;
                case "bad":
                    value = "bad";

                    if (int.TryParse(value, out result))
                    {
                        Console.WriteLine($"Measurement: {result}");
                    }
                    else
                    {
                        Console.WriteLine("Unable to report the measurement.");
                    }

                    if (result > 0)
                        Console.WriteLine($"Measurement (w/ offset): {50 + result}");
                    break;
            }
        }

        public static void ChallengeCombineValues(bool execute = false)
        {
            if (!execute)
                return;

            string[] values = ["12.3", "45", "ABC", "11", "DEF"];

            decimal total = 0m;
            string message = "";

            foreach (var value in values)
            {
                if (decimal.TryParse(value, CultureInfo.InvariantCulture, out decimal number))
                {
                    total += number;
                }
                else
                {
                    message += value;
                }
            }

            Helper.Output($"Message: {message}");
            Helper.Output($"Total: {total}");
        }

        public static void ChallengeMathOpNumTypes(bool execute = false)
        {
            if (!execute)
                return;

            int value1 = 11;
            decimal value2 = 6.2m;
            float value3 = 4.3f;

            int result1 = Convert.ToInt32(value1 / value2);
            Helper.Output($"Divide value1 by value2, display the result as an int: {result1}");

            decimal result2 = value2 / (decimal)value3;
            Helper.Output($"Divide value2 by value3, display the result as a decimal: {result2}");

            float result3 = value3 / value1;
            Helper.Output($"Divide value3 by value1, display the result as a float: {result3}");
        }

    }

    public class ArrayOperations
    {
        public static void Sorting(bool execute = false)
        {
            if (!execute)
                return;

            string[] pallets = ["B14", "A11", "B12", "A13"];

            Console.WriteLine("Sorted...");

            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Helper.BREAK();

            Console.WriteLine("Reversed...");

            Array.Reverse(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            Helper.BREAK();

            Array.Clear(pallets, 0, 2);

            Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }

            // ToLower and so on..
        }

        public static void Resizing(bool execute = false)
        {
            if (!execute)
                return;

            string[] pallets = ["B14", "A11", "B12", "A13"];

            Helper.BREAK();

            Array.Clear(pallets, 0, 2);
            Helper.Output($"Clearing 2 ... count: {pallets.Length}");
            foreach (var pallet in pallets)
            {
                Helper.Output($"-- {pallet}");
            }

            Helper.BREAK();

            Array.Resize(ref pallets, 6);
            Helper.Output($"Resizing 6 ... count: {pallets.Length}");

            pallets[4] = "C01";
            pallets[5] = "C02";

            foreach (var pallet in pallets)
            {
                Helper.Output($"-- {pallet}");
            }
        }

        public static void CharArrays(bool execute = false)
        {
            if (!execute)
                return;

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);

            string result = new(valueArray);
            Helper.Output(result);
        }

        public static void Joining(bool execute = false)
        {
            if (!execute)
                return;

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);

            string result = string.Join(",", valueArray);
            Console.WriteLine(result);
        }

        public static void Splitting(bool execute = false)
        {
            if (!execute)
                return;

            string value = "abc123";
            char[] valueArray = value.ToCharArray();
            Array.Reverse(valueArray);

            string result = String.Join(",", valueArray);

            string[] items = result.Split(',');
            foreach (string item in items)
            {
                Console.WriteLine(item);
            }
        }

        public static void ChallengeReverseWords(bool execute = false)
        {
            if (!execute)
                return;

            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            foreach (string item in message)
            {
                Helper.Output(item);
            }

            string[] newMessage = new string[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray();
                Array.Reverse(letters);
                newMessage[i] = new string(letters);
            }

            string result = string.Join(' ', newMessage);
            Helper.Output(result);
        }

        public static void ChallengeParseStrOfOrders(bool execute = false)
        {
            if (!execute)
                return;

            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] orderIDs = orderStream.Split(',');
            Array.Sort(orderIDs);

            for (int i = 0; i < orderIDs.Length; i++)
            {
                if (orderIDs[i].Length != 4)
                {
                    Console.WriteLine($"{orderIDs[i]}\t - Error");
                }
                else
                {
                    Console.WriteLine(orderIDs[i]);
                }
            }
        }
    }

    public class Formatting
    {
        public static void CompositeFormatting(bool execute = false)
        {
            if (!execute)
                return;

            string first = "Hello";
            string second = "World";
            string result = string.Format("{0} {1}!", first, second);
            string otherResult = string.Format("{0} {0} {0}!", first, second);
            Helper.Output(result);
            Helper.Output(otherResult);
        }

        public static void FormatCurrency(bool execute = false)
        {
            if (!execute)
                return;

            decimal price = 123.45m;
            int discount = 50;
            Helper.Output($"Price: {price:C} (Save {discount:C})");
        }

        public static void NumberFormatting(bool execute = false)
        {
            if (!execute)
                return;

            decimal measurement = 123456.78912m;
            Helper.Output($"Measurement: {measurement:N4} units");

            Helper.BREAK();

            decimal tax = .36785m;
            Helper.Output($"Tax rate: {tax:P2}");

            Helper.BREAK();

            decimal price = 67.55m;
            decimal salePrice = 59.99m;

            string yourDiscount = string.Format("You saved {0:C2} off the regular {1:C2} price. ", price - salePrice, price);

            yourDiscount += $"A discount of {(price - salePrice) / price:P2}!"; //inserted
            Helper.Output(yourDiscount);
        }

        public static void StringInterpolation(bool execute = false)
        {
            if (!execute)
                return;

            int invoiceNumber = 1201;
            decimal productShares = 25.4568m;
            decimal subtotal = 2750.00m;
            decimal taxPercentage = .15825m;
            decimal total = 3185.19m;

            Helper.Output($"Invoice Number: {invoiceNumber}");
            Helper.Output($"   Shares: {productShares:N3} Product");
            Helper.Output($"     Sub Total: {subtotal:C}");
            Helper.Output($"           Tax: {taxPercentage:P2}");
            Helper.Output($"     Total Billed: {total:C}");

            Helper.BREAK();

            string input = "Pad this";
            Console.WriteLine(input.PadLeft(12, '-'));
            Console.WriteLine(input.PadRight(12, '-'));

            Helper.BREAK();

            string paymentId = "769C";
            string payeeName = "Mr. Stephen Ortega";
            string paymentAmount = "$5,000.00";

            var formattedLine = paymentId.PadRight(6);
            formattedLine += payeeName.PadRight(24);
            formattedLine += paymentAmount.PadLeft(10);

            Helper.Output("1234567890123456789012345678901234567890");
            Helper.Output(formattedLine);
        }

        public static void ChallengeStrInterpolation(bool execute = false)
        {
            if (!execute)
                return;

            string customerName = "Ms. Barros";

            string currentProduct = "Magic Yield";
            int currentShares = 2975000;
            decimal currentReturn = 0.1275m;
            decimal currentProfit = 55000000.0m;

            string newProduct = "Glorious Future";
            decimal newReturn = 0.13125m;
            decimal newProfit = 63000000.0m;

            Console.WriteLine($"Dear {customerName},\nAs a customer of our {currentProduct} offering we are excited to tell you about new financial product that would dramatically increase your return.");
            Helper.BREAK();
            Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.");
            Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

            Console.WriteLine("Here's a quick comparison:\n");

            string comparisonMessage = "";

            comparisonMessage = currentProduct.PadRight(20);
            comparisonMessage += string.Format("{0:P}", currentReturn).PadRight(10);
            comparisonMessage += string.Format("{0:C}", currentProfit).PadRight(20);

            comparisonMessage += "\n";
            comparisonMessage += newProduct.PadRight(20);
            comparisonMessage += string.Format("{0:P}", newReturn).PadRight(10);
            comparisonMessage += string.Format("{0:C}", newProfit).PadRight(20);

            Console.WriteLine(comparisonMessage);
        }
    }
}