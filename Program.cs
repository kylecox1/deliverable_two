using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello human, I would like to chat.");
            bool chatting = true;
            bool r1 = false;
            bool r2 = false;
            bool r3 = false;
            while (chatting == true)
            {
                Console.WriteLine("Please say something...");
                string input = Console.ReadLine().ToLower();
                                           
                if (input == "hello" && r1 == false)
                {
                    Console.WriteLine("Hi good to see you");
                    r1 = true;
                }
                else if (input == "hello" && r1)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else if (input == "sup" && r2 == false)
                {
                    Console.WriteLine("I am good");
                    r2 = true;
                }
                else if (input == "sup" && r2)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else if (input == "hello there" && r3 == false)
                {
                    Console.WriteLine("General Kenobi");
                    r3 = true;
                }
                else if (input == "hello there" && r3)
                {
                    Console.WriteLine("I'm sorry but you have already said that");
                }
                else if (input == "bye")
                {
                    Console.WriteLine("Good bye!");
                    chatting = false;
                } 
            }
        }
    }
}
