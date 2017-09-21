using System;

namespace TipCalculator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Tipper tipper = new Tipper();

            // Infinite loop
            for (;;)
            {
                Console.WriteLine("Amount of bill?");
                tipper.Amount = double.Parse(Console.ReadLine());

                Console.Write("B)ad tip O)k tip G)ood Tip D)ivvy the bill Q)uit: ");
                char operation = Console.ReadLine().ToUpper()[0];

                if (operation == 'D') {
                    Console.WriteLine("# of diners?");
                    int diners = int.Parse(Console.ReadLine());
                    double amount = tipper.Divvy(diners);
                    Console.WriteLine("Each person owes {0:C}", amount);
                }
                else if (operation == 'Q') {
                    break;
                }
                else {
                    double result = 0.0;

                    switch (operation)
                    {
                        case 'B':
                            result = tipper.CalculateTip(10.0);
                            break;
                        case 'O':
                            // Use overloaded version
                            result = tipper.CalculateTip();
                            break;
                        case 'G':
                            result = tipper.CalculateTip(20.0);
                            break;
                    }

                    Console.WriteLine("The tip amount for {0:C} is {1:C} = {2:C}", 
                        tipper.Amount, result, tipper.Amount + result);
                }
            }

        }
    }
}
