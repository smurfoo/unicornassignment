/*  
 Purpose:Purpose – To create a system to reflect the costs of financially sponsoring a Unicorn at the
Unicorn Rescue Society. The society works to promote the wellbeing and care of Unicorns
which, once thought to be extinct, are now making a comeback!


Input: name sponsorname donation
Output: bill
 Author: Ilyas G
Date: Sept 23 2022
 */


namespace unicornassignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare variables
            string donorName = "", 
                unicornName = "";
            char options, 
                gateOptions = ' ', 
                gatePaint = ' ', 
                mealUpgrade = ' ', 
                mealPriceOption = ' ', 
                paintOption = ' ';
            double monthAmount = 0, 
                months = 0, 
                donationAmount = 0, 
                wallWidth = 0, 
                backWallWidth = 0, 
                gateWidth = 0, 
                gateHeight = 0,
                wallPrice = 0, 
                wallArea = 0, 
                gateArea = 0,
                gatePrice = 0, 
                mealPrice = 0, 
                backWallArea = 0, 
                backGateArea = 0, 
                paintPrice = 0, 
                totalPrice = 0, 
                gateSquareFeet = 0;
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
            Console.Write("What is the height of the gate (in feet)? ");
            gateHeight = double.Parse(Console.ReadLine());
            // wall price calculations
              if (gateWidth < backWallWidth)
            {
                gateArea = ((backWallWidth - gateWidth) * (12 * 4));
            }
            else
            {
                Console.WriteLine("Gate cannot be wider than back wall width");
                Environment.Exit(0);
            }
            wallArea = ((wallWidth * 2) * (12 * 4));
            backWallArea = ((backWallWidth) * (12 * 4));
            backGateArea = ((backWallWidth - gateWidth) * (12 * 4));
            wallPrice = wallArea + backWallArea + backGateArea;
            gateSquareFeet = (gateWidth * gateHeight);
             // gate menu
            Console.WriteLine("***** Gate Style ******");
            Console.WriteLine("Available gates (prices per square foot):");
            Console.WriteLine("\tW- Wooden ($3) ");
            Console.WriteLine("\tS- Silver ($8) ");
            Console.WriteLine("\tG- Gold ($15) ");
            Console.Write("Option: ");
            gateOptions = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
            // gate options
            switch (gateOptions)
            {
                case 'W':
                    gatePrice = gateSquareFeet * 3;

                    break;
                case 'S':
                    gatePrice = gateSquareFeet * 8;
                    break;
                case 'G':
                    gatePrice = gateSquareFeet * 15;
                    break;
            }
            // (must use if and switch, if will be used when asking to change gate paint or a meal upgrade yes or no
            // gate paint change option
            Console.Write("Would you like to change the gate paint (Y/N)?");
            gatePaint = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
            switch (gatePaint)
            {
                case 'Y':
                    Console.WriteLine("Available paints");
                    Console.WriteLine("\tM - Mood: Changes colour based on mood ($200)");
                    Console.WriteLine("\tA - Magic: Changes colour several times a day ($300)");
                    Console.WriteLine("\tR - Reflective: Reflects like a mirror ($150)");
                    Console.Write("Option: ");
                    paintOption = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
                    switch (paintOption)
                    {
                        case 'M':
                            paintPrice = paintPrice + 200;
                            break;
                        case 'A':
                            paintPrice = paintPrice + 300;
                            break;
                        case 'R':
                            paintPrice = paintPrice + 150;
                            break;
                        default:
                            Console.WriteLine("Invalid selection, please try again.");
                            Environment.Exit(0);
                            break;

                    }
                       break;
            }
            // meal upgrade menu
            Console.WriteLine("***** Meal Upgrade *****");
            Console.Write("Would you like a meal upgrade (Y/N)? ");
            mealUpgrade = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
            // meal upgrade switch
            switch (mealUpgrade)
            {
                case 'Y':
                    Console.WriteLine("Available meal upgrades:");
                    Console.WriteLine("\tR - Add rainbow cookie treats ($1000)");
                    Console.WriteLine("\tS - Special appetizers ($500)");
                    mealPriceOption = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
                    switch (mealPriceOption)
                    {
                        case 'R':
                            mealPrice = mealPrice + 1000;
                            break;
                        case 'S':
                            mealPrice = mealPrice + 500;
                            break;
                        default:
                            Console.WriteLine("Invalid Selection");
                            Environment.Exit(0);
                            break;
                    }
                    break;
            }
             // total price
            totalPrice = (donationAmount) + (wallPrice) + (gatePrice) + (paintPrice) + (mealPrice);
             // summary
            Console.WriteLine("***** Summary *****");
            Console.WriteLine($" Donor                            {donorName}");
            Console.WriteLine($" Unicorn Name                     {unicornName}");
            Console.WriteLine($" Donation Amount                 ${donationAmount:f2}");
            Console.WriteLine($" Wall Cost                       ${wallPrice:f2}");
            Console.WriteLine($" Gate Cost                       ${gatePrice:f2}");
            if (paintPrice > 0)
            {
                Console.WriteLine($"Gate Paint Cost                 ${paintPrice:f2}");
            }
            else
            {
                Console.WriteLine("Gate Paint Cost                    Original");
            }
            if (mealPrice > 0)
            {
                Console.WriteLine($"Meal Upgrade                    ${mealPrice:f2}");
            }
            else
            {
                Console.WriteLine("Meal Upgrade                      None");
            }
            Console.WriteLine($"{donorName}, the total cost to sponsor {unicornName} is ${totalPrice:f2}");

        }
    }
}









