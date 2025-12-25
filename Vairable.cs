using System;
using System.Runtime.CompilerServices;
class Vairable {
     public static void Usevariable(){
        // This all are the variable;
            // int a = 5 ;
            // int b = 6;
            // int z = a + b;
            // Console.WriteLine(z);
            // char c = '@';
            // Console.WriteLine(c);

            // String name = "Girish";
            // String Username = c + name;
            // Console.WriteLine(Username);

            // bool alive = true;
            // Console.WriteLine("Are you Alive" + alive);

            // double height = 175.45;
            // Console.WriteLine("Height is :" + height);


            // // Constant : These are the immutable thing which cannot be change the value of that variabkle
            // const int value = 45;
            // Console.WriteLine(value);
            // // value = 55;


            // // Typecasting : The typecasting is that where we can change the one datatype of the variable to another datatype

            // int varI = 123;
            // String varS = Convert.ToString(varI);
            // Console.WriteLine(varS);
            // Console.WriteLine(varS.GetType());

            // String varS1 = "123";
            // int varI1= Convert.ToInt32(varS1);
            // Console.WriteLine(varI1);
            // Console.WriteLine(varI1.GetType());
        
            // bool varb = true; // return 1
            // int varb1 = Convert.ToInt32(varb);
            // Console.WriteLine(varb1);
            // Console.WriteLine(varb1.GetType());


            // // Handling the UserInput 

            // Console.WriteLine("Hello ! What is your Name");
            // String name1 = Console.ReadLine(); // this always return the string so for the other datatype convert into the required datatype
    
            // Console.WriteLine("What is ypur age : ");
            // int age1 = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Hello " + name1 + " you are " + age1 + " yrs old");


            // Math class

            // double math1 = 25.00;
            // double math2 = 21.23;
            // double a1  = Math.Abs(math1); // It return the absolute value i.e close to zero 
            // double a2 = Math.Pow(math1 , 2); // It give the power of the variable
            // double a3 = Math.Floor(math1); // It give the the value above the actual value where the value as any decimal numbers rather than zero
            // double a4 = Math.Ceiling(math1); // It give the value without zero
            // double a5 = Math.Sqrt(math1); // It give the sqrt
            // double a6 = Math.Max(math1 , math2);
            // double a7 = Math.Min(math1 ,math2);

            // Console.WriteLine(a1); 
            // Console.WriteLine(a2);
            // Console.WriteLine(a3);
            // Console.WriteLine(a4);
            // Console.WriteLine(a5);
            // Console.WriteLine(a6);
            // Console.WriteLine(a7);


            // Random 

            Random random = new Random();
            int num = random.Next(1 ,6); // It give the value between the range of the 1 , 5 the 6 is not include in it
            Console.WriteLine(num); // 
            

            double num2 = random.NextDouble(); // It give the value betweent the 0 to 1 
            Console.WriteLine(num2);
        }
        public void stringMethods(){

            String name = "Girish Throat";
            String phoneNumber = "782-228-18958";

            String demo1 = name.ToLower();
            Console.WriteLine(demo1);

            String demo2 = name.ToUpper();
            Console.WriteLine(demo2); 

            phoneNumber = phoneNumber.Replace("-" , "");
            Console.WriteLine(phoneNumber);
         

            String demo3 = name.Replace(" ", "");
            Console.WriteLine(demo3);

            Console.WriteLine(demo3.Length);

            String demo4 = name.Substring(0 , 4); // This will return the no of charactres from the given index (0 , 4 )
            Console.WriteLine(demo4);             // 0 -> is the starting index. 4 -> is the no of characters   

            String demo5 = name.Substring(5 , 4);
            Console.WriteLine(demo5);

            Console.WriteLine(demo1.OrderDescending());
        }
}
