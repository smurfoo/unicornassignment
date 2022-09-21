/*  
 Purpose:Purpose – To create a system to reflect the costs of financially sponsoring a Unicorn at the
Unicorn Rescue Society. The society works to promote the wellbeing and care of Unicorns
which, once thought to be extinct, are now making a comeback!


Input: numbers
Output: bill
 Author: Ilyas G
Date: Sept 19 2022
 */


namespace unicornassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string donorName = "", unicornName = "";
            char options, optionTotal = ' ', penOptions = ' ', gateOptions = ' ';
            double monthAmount = 0, months = 0, donationAmount = 0, wallWidth = 0, backWallWidth = 0, gateWidth = 0, gateHeight = 0,
                wallPrice = 0, squareFeet = 0;
            // inputs
            // menu donation type
            Console.WriteLine("***** Welcome to the Unicorn Rescue Society Sponsor Estimator *****");

            Console.Write("What is the sponsor's name?");
            donorName = Console.ReadLine();
            Console.Write("What would you like to call the unicorn?");
            unicornName = Console.ReadLine();
            Console.WriteLine("All sponsors must make a donation");
            Console.WriteLine("What type would you like to make?");
            Console.WriteLine("\tU - Unlimited");
            Console.WriteLine("\tM - Monthly");
            Console.WriteLine("\tO - One Time");
            Console.Write("Option: ");
            options = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));

            // options
            switch (options)
            {
                case 'U':
                    Console.Write("How much per month?");
                    monthAmount = double.Parse(Console.ReadLine());
                    donationAmount = (monthAmount * 1);
                    Console.WriteLine($"The total donation amount is ${donationAmount:f2}");
                    break;
                case 'M':
                    Console.Write("How much per month?");
                    monthAmount = double.Parse(Console.ReadLine());
                    Console.Write("How many months?");
                    months = double.Parse(Console.ReadLine());
                    donationAmount = (monthAmount * months);
                    Console.WriteLine($"The total donation amount is ${donationAmount:f2} ");
                    // in other switch ask how many months and multiply it by amount per month
                    break;
                case 'O':
                    Console.Write("Enter the one time donation amount: ");
                    monthAmount = double.Parse(Console.ReadLine());
                    donationAmount = monthAmount;
                    Console.WriteLine($"The total donation amount is ${donationAmount:f2} ");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }

            // menu pen accomodations
            Console.WriteLine("***** Pen Accommodations *****");
            Console.Write("What is the width of the 2 walls (in feet)? ");
            wallWidth = double.Parse(Console.ReadLine());
            Console.Write("What is the width of the back wall (in feet)? ");
            backWallWidth = double.Parse(Console.ReadLine());
            Console.Write("What is the width of the gate? ");
            gateWidth = double.Parse(Console.ReadLine());
            Console.Write("What is the height of the gate? ");
            gateHeight = double.Parse(Console.ReadLine());



            // wall price calculations
            // length x width  = square feet
            squareFeet = (wallWidth * backWallWidth);
            wallPrice = (squareFeet * 4);

            // gate menu
            Console.WriteLine("***** Gate Style ******");
            Console.WriteLine("Available gates (prices epr square foot):");
            Console.WriteLine("\tW- Wooden ($3) ");
            Console.WriteLine("\tS- Silver ($8) ");
            Console.WriteLine("\tG- Gold ($15) ");
            Console.Write("Option: ");
            gateOptions = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));

            // gate options

            switch (gateOptions)
            {
                case 'W':
                    

                    break;
                case 'S':
                    break;
                case 'G':
                    break;
            }

            Console.WriteLine($"Wall Price is now {wallPrice} for {squareFeet} ");

        }
    }
}