using System;

namespace HelloWorldApplication {
    // Author : Anil Kadam (akadam@tavisca.in)
   class HelloWorld {
      static void Main(string[] args) {
        //Taking input from user
        string name = Console.ReadLine(); 
        Console.WriteLine("Hello {0}", name);
        Console.ReadKey();
      }
   }
}