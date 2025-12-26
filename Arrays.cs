using System;

namespace MyNamespace
{
    public class ArrayExmp
    {
        public void ArrayExample()
        {
            String[] cars = {"BMW", "Ferrari", "Audi" ,"LykanHyperSport"};
            // Console.WriteLine(cars);
            for(int i = 0 ; i < cars.Length ; i++)
            {
            Console.WriteLine(cars[i]);
            }

            foreach(String s in cars) // It is an for each loop where it jus move forward and access direct elements . It does not traverse 
            {                         // back like normal for loop  .It is just use for the traversing and              
                Console.WriteLine(s);
            }
        }
    }
}