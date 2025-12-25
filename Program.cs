using System;
using System.Runtime.InteropServices;
using MyNamespace;

class Program
{
    static void Main(string[] args)
    {
        // This all are the escape characters 
        // Console.WriteLine("Girish\aThorat"); // It create the beep sound
        // Console.WriteLine("Girish\tThorat"); 
        // Console.WriteLine("Girish\rThorat");
        // Console.WriteLine("Girish\bThorat");
        // Console.WriteLine("Girish\fThorat"); // It write after name on the next line
        // Console.WriteLine("Girish\vThorat"); // Same as the above
        // Console.WriteLine("Girish\'Thorat"); 
        // Console.WriteLine("C:\\File.txt");
        // Console.WriteLine("Girish\"Thorat\""); // It adds the Double Quote
        // Console.WriteLine("Girish \0Throat");
        // Vairable.Usevariable();
        BasicProject obj = new BasicProject();
        // obj.sayHello(); 
        // obj.Hypotenus();
        // obj.NumberGuesses();
        obj.RockPaperScissor();

        // Vairable var = new Vairable();
        // var.stringMethods();

        Conditional cnd  = new Conditional();
        // cnd.checkCondition();
        // cnd.switchCase();
        // cnd.LogicalOperators();
        // cnd.Loops();
        
        Console.ReadKey();
    }
}
 