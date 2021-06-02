using System;


namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Операция сложения");
            Console.WriteLine();
            Calculator.SelectOperation(ArithmeticOperations.Addition);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
            Console.WriteLine("Операция вычитания");
            Console.WriteLine();
            Calculator.SelectOperation(ArithmeticOperations.Subtraction);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
            Console.WriteLine("Операция умножения");
            Console.WriteLine();
            Calculator.SelectOperation(ArithmeticOperations.Multiplying);
            Console.WriteLine(new string('-', 50));
            Console.WriteLine();
            Console.WriteLine("Операция деления");
            Console.WriteLine();
            Calculator.SelectOperation(ArithmeticOperations.Division);
            Console.WriteLine(new string('-', 50));
            Console.ReadKey();
        }
    }
}
