using System;

namespace MyNamespace
{
    public class MethodsUse
    {
        public  void methodUse()
        {
            String name = "Girish";
            int age = 21;
            methodHelp(name , age);
        }

        static void methodHelp(String name , int age)
        {
            Console.WriteLine("Hello " + name + " How are you !!");
            Console.WriteLine("So you are " + age + " yrs old !");            
        }

        public void Operation()
    {
        double x , y , result;

        Console.WriteLine("Enter the no 1 :");
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the no 2 :");
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the no 3 : ");
        double z = Convert.ToDouble(Console.ReadLine());

        result = Multiply(x ,y );

        double result2 = Multiply(x , y, z);
        Console.WriteLine("The result of the method overloading is : " + result2);
        Console.WriteLine("The result is : " + result );

        double[] var = {2.2 , 2.5 , 5.6 , 4.5};
        double result3 = UseParams(var);
        Console.WriteLine(result3);
    }
    static double Multiply(double x , double y)
    {
        double z = x * y;
        return z; 
    }
    
    static double Multiply(double x , double y , double z) // this is an method overloading where the function name is same and
        {                                                  // the parameters are different
            return x * y * z;
        }


   static double UseParams(params double[] a) // this is the method where the parameters are can handle in the large manner
{                                             // this can reduce to stop creating different methods for handling the different parameters
    double total = 1;

    foreach (double value in a)
    {
        total = total * value;
    }

    return total;
}

    }

    
}