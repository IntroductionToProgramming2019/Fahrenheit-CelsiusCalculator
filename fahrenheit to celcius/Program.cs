/* #############################
 * 
 * Author: Johnathon Mc Grory
 * Date :
 * Description : simple Fahrenheit to Celsius calculator
 * 
 * ############################# */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fahrenheit_to_celcius
{
    class Program
    {
        static void Main(string[] args)
        { Console.WriteLine("Please enter degrees Fahrenheit: " );
            int Fahrenheit = int.Parse(Console.ReadLine());
            int Celsius = 5*(Fahrenheit - 32) / 9;
            Console.WriteLine(Celsius + "  degrees");
        }
    }
}
