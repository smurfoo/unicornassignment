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
            char options, optionTotal = ' ', penOptions = ' ', gateOptions = ' ', gateBoolean = ' ', paintIf = ' ', mealBoolean = ' ', mealUpgrade = ' ';
            double monthAmount = 0, months = 0, donationAmount = 0, wallWidth = 0, backWallWidth = 0, gateWidth = 0, gateHeight = 0,
                wallPrice = 0, wallArea = 0, gateArea = 0, gatePrice = 0, mealPrice = 0, area = 0;
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
            if (gateArea < backWallWidth)
            {
                gateArea = ((backWallWidth - gateWidth) * (12 * 4));
            }
            else
            {
                Console.WriteLine("Gate cannot be wider than back wall width");
                Environment.Exit(0);    
            }
          
          
           

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


                    break;
                case 'S':
                    break;
                case 'G':
                    break;
            }
            // (must use if and switch, if will be used when asking to change gate paint or a meal upgrade yes or no
            // gate paint change option
            Console.Write("Would you like to change the gate paint (Y/N)?");
            gateBoolean = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));

            switch (gateBoolean)
            {
                case 'Y':
                    Console.WriteLine("Available paints");
                    Console.WriteLine("\tM - Mood: Changes colour based on mood ($200)");
                    Console.WriteLine("\tA - Magic: Changes colour several times a day ($300)");
                    Console.WriteLine("\tR - Reflective: Reflects like a mirror ($150)");
                    break;




            }
            // option if structure
            Console.Write("Option: ");
            paintIf = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
            if (paintIf == 'M')
            {
                gatePrice += 200;
            }
            else if (paintIf == 'A')
            {
                gatePrice += 300;

            }
            else
            {
                gatePrice += 150;
            }
            // meal upgrade menu
            Console.WriteLine("***** Meal Upgrade *****");
            Console.Write("Would you like a meal upgrade (Y/N)? ");
            mealBoolean = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
            // meal upgrade if structure
            if (mealBoolean == 'Y')
            {
                Console.WriteLine("Available meal upgrades:");
                Console.WriteLine("\tR - Add rainbow cookie treats ($1000)");
                Console.WriteLine("\tS - Special appetizers ($500)");
                mealUpgrade = char.Parse(Console.ReadLine().ToUpper().Substring(0, 1));
                switch (mealUpgrade)
                {
                    case 'R':
                        mealPrice += 1000;
                        break;
                    case 'S':
                       
                }

            }
    
            
            /*      switch (gateBoolean)
            {
                case 'Y':
                Console.WriteLine("Available meal upgrades:");
                Console.WriteLine("\tR - Add rainbow cookie treats ($1000)");
                Console.WriteLine("\tS - Special appetizers ($500)");
                    break;





            }

*/





            Console.WriteLine($"Wall Price is now {wallPrice} for {squareFeet} ");




        }
    }
}