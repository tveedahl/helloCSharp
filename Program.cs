using System;

namespace helloCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Print hello world, date, and time
            Console.WriteLine("Hello World!" + "\n");
            Console.WriteLine("The current date and time is " + DateTime.Now + "\n");

            //Do some integer math
            int a = 18;
            int b = 6;
            int c = a + b;
            Console.WriteLine(c);
        }
    }
}
