using System;

namespace HelloWorldApplication {
   class HelloWorld {
      static void Main(string[] args) {
        //Taking input from user
        string name = Console.ReadLine(); 
        Console.WriteLine("Hello {0}", name);
        Console.ReadKey();
      }
   }
}