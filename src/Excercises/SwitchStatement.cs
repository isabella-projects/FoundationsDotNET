namespace LearnCSharp.Excercises
{
    using Helpers;

    public class SwitchStatement
    {
        public static void EmployeeLevel(bool execute = false)
        {
            if (!execute)
                return;

            int employeeLevel = 100;
            string employeeName = "John Smith";

            string title;

            switch (employeeLevel)
            {
                case 100:
                case 200:
                    title = "Senior Associate";
                    break;
                case 300:
                    title = "Manager";
                    break;
                case 400:
                    title = "Senior Manager";
                    break;
                default:
                    title = "Associate";
                    break;
            }

            Helper.Output($"{employeeName}, {title}");
        }

        public static void ChallengeSwitch(bool execute = false)
        {
            if (!execute)
                return;

            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type;
            string color;
            string size;

            switch (product[0])
            {
                case "01":
                    type = "Sweat shirt";
                    break;
                case "02":
                    type = "T-Shirt";
                    break;
                case "03":
                    type = "Sweat pants";
                    break;
                default:
                    type = "Other";
                    break;
            }

            switch (product[1])
            {
                case "BL":
                    color = "Black";
                    break;
                case "MN":
                    color = "Maroon";
                    break;
                default:
                    color = "White";
                    break;
            }

            switch (product[2])
            {
                case "S":
                    size = "Small";
                    break;
                case "M":
                    size = "Medium";
                    break;
                case "L":
                    size = "Large";
                    break;
                default:
                    size = "One Size Fits All";
                    break;
            }


            Helper.Output($"Product: {size} {color} {type}");
        }

        public static void ChallengeExpression(bool execute = false)
        {
            if (!execute)
                return;

            // SKU = Stock Keeping Unit
            string sku = "01-MN-L";

            string[] product = sku.Split('-');

            string type = product[0] switch
            {
                "01" => "Sweat shirt",
                "02" => "T-Shirt",
                "03" => "Sweat pants",
                _ => "Other",
            };

            string color = product[1] switch
            {
                "BL" => "Black",
                "MN" => "Maroon",
                _ => "White",
            };

            string size = product[2] switch
            {
                "S" => "Small",
                "M" => "Medium",
                "L" => "Large",
                _ => "One Size Fits All",
            };

            Helper.Output($"Product: {size} {color} {type}");
        }
    }
}