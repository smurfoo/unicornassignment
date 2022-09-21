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
            string donorName, unicornName;
            char options, optionTotal;
            double monthAmount;
            // inputs
            // menu
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
                    break;
                case 'M':
                    Console.Write("How much per month?");
                    monthAmount = double.Parse(Console.ReadLine());
                    // in other switch ask how many months and multiply it by amount per month
                    break;
                case 'O':
                    Console.Write("Enter the one time donation amount: ");
                    monthAmount = double.Parse(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
            


            switch (optionTotal)
            {
                case 'U'
                    consoe
            }

        }
    }
}