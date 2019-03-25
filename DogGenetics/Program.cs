using System;
using System.Collections.Generic;


namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your dogs name?");
            string dogname = Console.ReadLine();

            Console.WriteLine("Well then, I have this highly reliable report on");
            Console.Write(dogname);
            Console.WriteLine("'s prestigious background right here");

            Console.WriteLine("Press ENTER to continue.");

            Console.ReadLine();

            Random random = new Random();
            int rInt = random.Next(0, 100);
            int maxValue = 0;
            int[] values = new int[5];


            for (int i = 0; i < 4; i++)
            {
                int currentValue = random.Next(1, 25);

                maxValue = maxValue + currentValue;

                values[i] = currentValue;

            }

            values[4] = 100 - maxValue;

            int Bernard = values[0];
            int Chihuahua = values[1];
            int Pug = values[2];
            int Cur = values[3];
            int Doberman = values[4];






            Console.WriteLine("{0}% St. Bernard", Bernard);

            Console.WriteLine("{0}% Chihuahua", Chihuahua);

            Console.WriteLine("{0}% Dramatic RedNosed Asian Pug", Pug);

            Console.WriteLine("{0}% Common Cur", Cur);

            Console.WriteLine("{0}% King Doberman", Doberman);

            Console.WriteLine("Wow, that's quite the dog!");

            Console.ReadLine();




        }
    }
}

