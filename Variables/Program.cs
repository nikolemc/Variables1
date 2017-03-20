using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string projectName = "Hello World";
            int year = 1492;
            bool dogAtHome = true;

            DateTime d = DateTime.Today.Date;

            float burgerCost = 5.45f;
            char letter = 'X';

            int randomNumber;

            // Console.WriteLine(projectName);
            // Console.ReadLine();

            // Console.WriteLine("Columbus Sailed the world in {0}", year.ToString());
            // Console.ReadLine();

            // Console.WriteLine("It is {0} that I have a dog at home.", dogAtHome);
            //  Console.ReadLine();


            //  Console.WriteLine("Today is {0}", d.ToShortDateString());

            //  Console.WriteLine("I spent {0:C} on a chesseburger.", burgerCost);

            // Console.WriteLine("{0} marks the spot.", letter);


            //Level 2
            /*   Console.WriteLine("What is your favorite number?:");
                 string line = Console.ReadLine();
                 int value;
                 if (int.TryParse(line, out value)) 
                 {
                     Console.Write("Your favourite number is: ");
                     Console.WriteLine(value); 
                 }
                 else
                 {
                     Console.WriteLine("This is NOT a number, Try again!");
                 }
             */

            Console.WriteLine("What is your favorite number?:");
            string line = Console.ReadLine();
            int value;
            if (int.TryParse(line, out value))
            {
                Console.Write("Your favourite number is: ");
                Console.WriteLine(value);
            }
            else
            {
                Console.WriteLine("This is NOT a number, Try again!");
                while (!int.TryParse(Console.ReadLine(), out value))
                    Console.WriteLine("The value must be a number");
            }


        }
    }  
}
