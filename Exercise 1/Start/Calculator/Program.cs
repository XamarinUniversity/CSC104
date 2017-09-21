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

            // TODO: create a Calculator object

            while ( true ) {
                Console.Write( "A)dd S)ubtract M)ultiply D)ivide Q)uit: " );
                var operation = Console.ReadLine( ).ToUpper( )[0];

                if ( operation == 'Q' )
                    break;

                switch ( operation ) {
                    case 'A':
                        // TODO: add the two numbers with the calculator
                        break;
                    case 'S':
                        // TODO: subtract the two numbers with the calculator
                        break;
                    case 'M':
                        // TODO: multiply the two numbers with the calculator
                        break;
                    case 'D':
                        // TODO: divide the two numbers with the calculator
                        break;
                    default:
                        Console.WriteLine( "Please enter A, S, M, D or Q" );
                        break;
                } 
                // TODO: output the result from the calculator
            } 
        }
    }
}
