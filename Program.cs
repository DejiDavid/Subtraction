using System;

namespace Subtraction {
    class Program {
        static void Main (string[] args) {
            int firstNumber = 0;
            int secondNumber = 0;
            int results = 0;

            Console.Write ("Please enter your first number: ");
            firstNumber = int.Parse (Console.ReadLine ());

            Console.Write ("Please enter the second number: ");
            secondNumber = int.Parse (Console.ReadLine ());

            results = firstNumber - secondNumber;
            Console.WriteLine ("The answer is " + results);
        }
    }
}