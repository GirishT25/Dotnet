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
            // Console.WriteLine(cars.GetLength(1));
            int[,] arr = { {10}, {20}, {30}, {40} };

            Console.WriteLine(arr.Length);        // ✅ Preferred → 4
            Console.WriteLine(arr.GetLength(0));  // ✅ Also works → 4
            Console.WriteLine(arr.GetLength(1));

            String[,] SportsCar =
            {
                {
                    "Lykan Hypersport" , "Ferrari" , "Lambmorgini" 
                },
                {
                    "Mercedes" , "Audi"  , "BMW"
                },
                {
                    "Maserti" , "Ford Mustang" , "Shelby GT"
                }
            };

            // foreach(String var in SportsCar)
            // {
            //     Console.WriteLine(var);
            // }

            for(int i = 0 ; i < SportsCar.GetLength(0) ; i++)
            {
                for(int j = 0 ; j < SportsCar.GetLength(1); j++)
                {
                    Console.Write(SportsCar[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}