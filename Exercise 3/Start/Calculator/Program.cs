using System;

namespace Calculator
{
    public class Program
    {
        public static void Main ( string[] args )
        {
            Console.Write( "First number? " );
            float first = float.Parse( Console.ReadLine( ) );
            Console.Write( "Second number? " );
            float second = float.Parse( Console.ReadLine( ) );

            Calculator calc = new Calculator();

            while ( true ) {
                Console.Write( "A)dd S)ubtract M)ultiply D)ivide, I)nteger division, Q)uit: " );
                var operation = Console.ReadLine( ).ToUpper( )[0];

                if ( operation == 'Q' )
                    break;

                int remainder = 0;

                switch ( operation ) {
                    case 'A':
                        calc.Add(first, second);
                        break;
                    case 'S':
                        calc.Subtract(first, second);
                        break;
                    case 'M':
                        calc.Multiply(first, second);
                        break;
                    case 'D':
                        calc.Divide(first, second);
                        break;
                    case 'I':
                        remainder = calc.Divide((int)first, (int)second);
                        break;
                    default:
                        Console.WriteLine( "Please enter A, S, M, D, I or Q" );
                        break;
                } 

                if (remainder != 0) {
                    Console.WriteLine("Your answer is {0} with a remainder of {1}", calc.Answer, remainder);

                } else {
                    Console.WriteLine("Your answer is {0}", calc.Answer);
                }
            } 
        }
    }
}
