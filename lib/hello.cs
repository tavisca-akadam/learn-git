using System;
using ConsoleApp1.greeter;

namespace HelloWorldApplication {
    // Author : Anil Kadam (akadam@tavisca.in)
   class HelloWorld {
      static void Main(string[] args) {
      //Taking input from user
      string name = Console.ReadLine(); 
      // Creating object of greeter class
      greeter greet = new greeter(name);
      Console.WriteLine(greet.greetMsg());

      Console.ReadKey();
      }
   }
}