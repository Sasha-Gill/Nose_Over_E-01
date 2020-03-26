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
            

                 string Name2 = "";
                 string Password2 = "";

            
            while (Name2 != "noname" && Password2 != "nopass") //loopen körs så länge name och pass inte är "noname" samt "Nopass"
            {

                Console.WriteLine("Write your name: ");
                    Name2 = Console.ReadLine();
                Console.WriteLine("Write your password: ");
                    Password2 = Console.ReadLine();

                if (Name2 == "noname" && Password2 == "nopass")
                {
                    Console.WriteLine("Welcome " +Name2 + "!");
                    Console.ReadLine();
                }
                else 
                {
                    Console.WriteLine("Wrong username or password!");
                    Console.ReadLine();
                }
            }


        }
    }
}
