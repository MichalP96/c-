using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldCons
{
    class Program
    {

        static void Main(string[] args)
        {
            string songLyrics = "You say goodbye, and I say hello";
            string sayHello = "Hello World!";
            string greeting = "        Hello World!          ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreetings = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreetings}]");

            trimmedGreetings = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreetings}]");

            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            Console.WriteLine(sayHello.ToUpper());
            Console.WriteLine(sayHello.ToLower());

            Console.WriteLine(songLyrics.Contains("goodbye"));

            if (songLyrics.Contains("goodbye") == true)
                Console.WriteLine("I got it !");
            





            Console.ReadLine();
        }
    }

   
}
