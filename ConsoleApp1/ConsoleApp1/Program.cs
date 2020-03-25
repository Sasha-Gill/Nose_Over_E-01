using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            if (6>3)
            { 
            Console.WriteLine("Hello, World!");
                Console.ReadLine();
            }

            string Name;
            string Password;
           Console.WriteLine("Write your name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Write your password: ");
            Password = Console.ReadLine();

            if (Name == "noname" && Password == "nopass")
            {
                Console.WriteLine("Welcome!");
            }
            else 
            {
                Console.WriteLine("Wrong username or password!");
            }

            int i = 0;
            
            while (32>i)
            {
                Console.WriteLine("Hello, World "+i); //lade till + i för att kunna se nummer på varje mening.
                i++;
            }

            while (Name == "noname" && Password == "nopass")
            { 
            
                Console.WriteLine("Write your name: ");
                Name = Console.ReadLine();
                Console.WriteLine("Write your password: ");
                Password = Console.ReadLine();

                if (Name == "noname" && Password == "nopass")
                {
                    Console.WriteLine("Welcome!");
                }
                else
                {
                    Console.WriteLine("Wrong username or password!");
                }
            }


        }
    }
}
