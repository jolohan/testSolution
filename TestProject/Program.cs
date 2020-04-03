using System;

namespace TestProject
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("hello world");
            bool loopCondition = true;
            while (loopCondition)
            {
                string mystring = null; 
                Console.WriteLine("Enter your input or write 'exit' to quit: ");
                mystring = Console.ReadLine();
                switch (mystring?.ToLower())
                {
                    case "exit":
                        Console.WriteLine("Invalid Entry.. Exiting");
                        loopCondition = false;
                        break;
                    case "bla":
                        Console.WriteLine("You cannot write bla!!!");
                        break;
                    default:
                        Console.WriteLine(mystring);
                        break;
                }
            }
        }
    }

    
}
