using System;


namespace Additional_Task
{

    enum ArithmeticOperations
    {
        Addition = 1,
        Subtraction,
        Multiplying,
        Division
    }
    static class Calculator
    {
        delegate double MyDelegate(double a, double b);
        delegate double NumsEnter();
        public static double Num1 { get; private set; }
        public static double Num2 { get; private set; }
        public static void SelectOperation(ArithmeticOperations operations)
        {

            switch ((int)operations)
            {
                case 1:
                    {
                        EnterNums();
                        MyDelegate Addition = (double a, double b) => { return a + b; };
                        double result = Addition(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 2:
                    {
                        EnterNums();
                        MyDelegate Subtraction = (double a, double b) => { return a - b; };
                        double result = Subtraction(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 3:
                    {
                        EnterNums();
                        MyDelegate Multiplying = (double a, double b) => { return a * b; };
                        double result = Multiplying(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
                case 4:
                    {
                        EnterNums();
                        #region Проверка деления на НОЛЬ в лямбда операторе при помощи тернарного оператора
                        MyDelegate Division = (double a, double b) => b != 0 ? a / b : 0;
                        if(Num2 == 0) Console.WriteLine("На ноль делить нельзя, ошибка деления на ноль - обработана");
                        #endregion
                        double result = Division(Num1, Num2);
                        Console.WriteLine($"Ответ:  {result}");
                        break;
                    }
            }

        }
        private static (double, double) EnterNums()
        {
            Console.WriteLine("Введите первое число");
            double x;
            if(double.TryParse(Console.ReadLine(), out x))
            {
                NumsEnter num1 = () => x;
                Num1 = num1();
            }
            else
            {
                Console.WriteLine("Некорректный ввод первого числа, вы ввели пустое значение\n");
            }
            
            Console.WriteLine("Введите второе число");
            double y;
            if (double.TryParse(Console.ReadLine(), out y))
            {
                NumsEnter num2 = () => y;
                Num2 = num2();
            }
            else
            {
                Console.WriteLine("Некорректный ввод второго числа, вы ввели пустое значение\n");
            }
           
            return (Num1, Num2);
        }

    }

}
