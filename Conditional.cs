using System;
using System.Runtime.CompilerServices;

namespace MyNamespace
{
    public class Conditional
    {
        public void checkCondition()
        {
            Console.WriteLine("Enter your name");
            String name = Console.ReadLine();    
            if(name != "")
            {
                Console.WriteLine("Hello " + name); 
            }
            
            else
            {
               Console.WriteLine("You did not enter the name !!");
            }

        }

        public void switchCase()

        {
            Console.WriteLine("Enter the Day");
            String day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                        Console.WriteLine("Today is Monday");
                        break;
                case "Tuesday":
                        Console.WriteLine("Today is Tuesday");
                        break;
                case "Wednesday":
                        Console.WriteLine("Today is Wednesday");
                        break;
                case "Thursday":
                        Console.WriteLine("Today is Thursday");
                        break;
                case "Friday":
                        Console.WriteLine("Today is Friday");
                        break;
                case "Saturday":
                        Console.WriteLine("Today is Saturday");
                        break;
                case "Sunday":
                        Console.WriteLine("Today is Sunday");
                        break;
                default :
                        Console.WriteLine("This is not a day");
                        break;
            }
            
        }

        public void LogicalOperators()
        {
            Console.WriteLine("Enter the Tempreature");
            double temp = Convert.ToDouble(Console.ReadLine());


            if(temp >= 30 && temp <= 50)
            {
                Console.WriteLine("The tempreature is in the range ");
            }
            else
            {
                Console.WriteLine("The tempreature is not in range ");   
            }

            Console.WriteLine("Enter the Another Tempreature");
            double temp2 = Convert.ToDouble(Console.ReadLine());

            if(temp2 >= 20 || temp <= 50)
            {
                Console.WriteLine("Tempreature is in the range of the 20 to 50"); 
            }
            else
            {
                Console.WriteLine("Tempreature is not in the range");
            }
        }

        public void Loops()
        {
            // String name = "";
            // while(name == "")
            // {
            //    Console.WriteLine("Enter your name here");
            //    name = Console.ReadLine(); 
            // }

            int height = 5;
            int width = 5;

            for (int i = 1; i <= height; i++) {
            if (i == 1 || i == height) {
                // top and bottom border
                for (int j = 1; j <= width; j++) {
                    Console.Write("🤖");
                }
            } else {
                // middle rows
                Console.Write("🤖");
                for (int j = 1; j <= width * 2 - 3; j++) {
                    Console.Write(" ");
                }
                Console.Write("🤖");
            }
            Console.WriteLine();
        }

        }
    }
}