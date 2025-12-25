
using System;
using System.Data;
using System.Reflection.Metadata;
using System.Text.Json;


public class BasicProject
    {
        public void sayHello()
        {
            Console.WriteLine("Hello");
        }
        public void Hypotenus(){
            Console.WriteLine("Enter the one side of the Triangle");
            double side1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the  side of the Triangle");
            double side2 = Convert.ToDouble(Console.ReadLine());

            side1 = Math.Pow(side1 , 2);
            side2 = Math.Pow(side2 , 2);
            double side3 = side1 + side2;

            double hypo = Math.Sqrt(side3);
            Console.WriteLine(hypo);

        }

        public void NumberGuesses()
    {
        Random random =  new Random();
        int min = 1 ;
        int max = 100;
        int number;
        int guess;
        int guesses;
        bool playAgain = true;
        while (playAgain)
        {
            number = random.Next(min , max + 1);
            guess = 0;
            guesses = 0;
        
            String play;

            if(guess <= min && guess >= max)
            {
                Console.WriteLine("Wrong Input");
            }
            while(guess != number)
            {
                
                Console.WriteLine("Enter the number to guess between " + min + " - " + max + " : " );
                guess = Convert.ToInt32(Console.ReadLine());
                if(guess < number)
                {
                    Console.WriteLine("Your Guess is " + guess + " very Low");       
                }
                if(guess > number)
                {
                    Console.WriteLine("Your Guess "+ guess + " is very high");
                }
                guesses++;
            }
            Console.WriteLine("Number " + number + " Your Guess" + guess + " Both are equal");
            Console.WriteLine("You Win !!!");
            Console.WriteLine("Guesses" + guesses);

            Console.WriteLine("If you want Play again (Y/N)");
            play = Console.ReadLine();
            play = play.ToUpper();

            if(play == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for the Playing");
    }
    }
