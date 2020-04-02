using System;

namespace SimpleCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1;
            int a2;
            string firstArgument;
            string secondArgument;
            bool successFirstArgument;
            bool successSecondArgument;
            string operationSymbol;
            
            Console.WriteLine("Добро пожаловать!!! \nВы работаете с простым калькулятором :-)!\n");

            Console.WriteLine("Введите числовое значение первого аргумента (А1) :");
            Console.Write("A1 = ");
            firstArgument = Console.ReadLine();

            Console.WriteLine("Введите числовое значение второго аргумента (А2) :");
            Console.Write("A2 = ");
            secondArgument = Console.ReadLine();

            successFirstArgument = Int32.TryParse(firstArgument, out a1);
            successSecondArgument = Int32.TryParse(secondArgument, out a2);

            if (successFirstArgument && successSecondArgument)
            {
                Console.Write("Введите знак арифметического действия ('+' '-' '*' '/') : ");
                operationSymbol = Console.ReadLine();

                switch (operationSymbol)
                {
                    case "+":
                        Console.WriteLine($"\nРезультат:\nА1 + А2 = {a1 + a2}");
                        break;

                    case "-":
                        Console.WriteLine($"\nРезультат:\nА1 - А2 = {a1 - a2}");
                        break;

                    case "*":
                        Console.WriteLine($"\nРезультат:\nА1 * А2 = {a1 * a2}");
                        break;

                    case "/":
                        if (a2 != 0)
                        {
                            Console.WriteLine($"\nРезультат:\nА1 / А2 = {a1 / a2}");                            
                        }
                        else
                        {
                            Console.WriteLine("На ноль делить нельзя. Начните заново!");
                        }
                        break;

                    default:
                        Console.WriteLine("Вы ввели неверный знак арифметического действия. Начните заново!");
                        break;

                }
                    
            }
            else
            {
                Console.WriteLine("Вы ввели нечисловые значения. Начните заново!");
                return;
            }


        }
    }
}
