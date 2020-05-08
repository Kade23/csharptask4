using System;
using System.Text;
using System.Collections;
using System.Data;

namespace squareroottask
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number1, Number2;  

            Console.WriteLine("Enter the Number 1");  
            Number1 = Convert.ToInt32(Console.ReadLine());
            double SqrtNumber1 = Math.Sqrt(Number1);

            Console.WriteLine("Enter the Number 2");  
            Number2 = Convert.ToInt32(Console.ReadLine());  
            double SqrtNumber2 = Math.Sqrt(Number2);
            
            if (SqrtNumber1 > SqrtNumber2)
            {
                Console.Write("The Number " + Number1 + " with square root of " + (Math.Sqrt(Number1)) + " has a higher square root than the number " + Number2 + " with square root of " + (Math.Sqrt(Number2)));
            }
            else if (SqrtNumber1 < SqrtNumber2)
            {
                 Console.Write("The Number " + Number2 + " with square root of " + (Math.Sqrt(Number2)) + " has a higher square root than the number " + Number1 + " with square root of " + (Math.Sqrt(Number1)));
            }
            else if ( (SqrtNumber1 == SqrtNumber2) && (SqrtNumber2 == SqrtNumber1 ) )
            {
                Console.Write("The Numbers provided have thesame squareroot. Please Click the ENTER button and input another value");
            }
            else if (SqrtNumber1  < 0 || SqrtNumber2  < 0)
            {
                Console.Write("The Numbers provided are not root numbers. Please Enter another value");
            }
            else
            {
                Console.Write("Invalid Input. Please Enter a proper value ");
            }
            Console.WriteLine();  
            Console.ReadLine();  
        }
    }
}
