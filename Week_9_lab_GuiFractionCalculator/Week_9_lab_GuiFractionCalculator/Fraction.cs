using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week_9_lab_GuiFractionCalculator
{
    public class Fraction
    {
        public int Top { get; }
        public int Bottom { get; }
        
        /**
        * This constructor takes two optional int
        * arguments and assigns them to the 
        * appropriate properties
        */
        public Fraction(int top = 0, int bottom = 1)
        => (Top, Bottom) = (top, bottom);

        /*
        * Add another constructor that takes two optional string
        * arguments and assigns them to the appropriate
        * properties (of course after conversion).
         */
        public Fraction(string topString = "0", string bottomString = "1")
        {
            Top = int.Parse(topString);
            Bottom = int.Parse(bottomString);
        }


        public static Fraction operator +(Fraction lhs, Fraction rhs)
        {
            return new Fraction(lhs.Top * rhs.Bottom + rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);
        }

        public static Fraction operator -(Fraction lhs, Fraction rhs)
        {
            return new Fraction(lhs.Top * rhs.Bottom - rhs.Top * lhs.Bottom, lhs.Bottom * rhs.Bottom);
        }


        //Add two more methods for multiply and divide
        public static Fraction operator *(Fraction lhs, Fraction rhs)
        {
            return new Fraction(lhs.Top * rhs.Top, lhs.Bottom * rhs.Bottom);
        }

        public static Fraction operator /(Fraction lhs, Fraction rhs)
        {

            return new Fraction(lhs.Top * rhs.Bottom, lhs.Bottom * rhs.Top);
        }

        public override string ToString()
        {
            return $"[{Top}, {Bottom}]";
        }

        /*
        * This Deconstructor allows you to get both properties
        * with a single statement.
        */

        public void Deconstruct(out string top, out string bottom)
      => (top, bottom) = ($"{Top}", $"{Bottom}");

        // Add a method to calculate the greatest common divisor (GCD) of two integers
        private static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;  //Update b to the remainder of a divided by b
                a = temp; //Swap a and b for the next iteration
            }
            return a;
        }

        // Add a method to simplify the fraction
        public Fraction Simplify()
        {
            // Calculate the GCD of the numerator and denominator
            int gcd = GCD(Top, Bottom);
            return new Fraction(Top / gcd, Bottom / gcd);
        }
    }
}
