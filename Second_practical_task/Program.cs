namespace Second_practical_task
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напишите через пробел число и основание системы счисления:");
            string arguments = Console.ReadLine();
            string[] argArray = arguments.Split();

            if (argArray.Length < 2)
            {
                Console.WriteLine("Ошибка: не указаны необходимые данные.");
                return;
            }

            int number = 0;
            if (!int.TryParse(argArray[0], out number))
            {
                Console.WriteLine("Ошибка: неверный формат числа.");
                return;
            }

            int baseNumber = 0;
            if (!int.TryParse(argArray[1], out baseNumber) || baseNumber < 2 || baseNumber > 20)
            {
                Console.WriteLine("Ошибка: неверный формат основания системы счисления.");
                return;
            }

            string result = ConvertToBase(number, baseNumber);
            Console.WriteLine(result);
        }

        static string ConvertToBase(int number, int baseNumber)
        {
            if (number == 0)
            {
                return "0";
            }

            string result = "";
            while (number > 0)
            {
                int digit = number % baseNumber;
                char digitChar = (char)((digit < 10) ? ('0' + digit) : ('A' + digit - 10));
                result = digitChar + result;
                number /= baseNumber;
            }
            return result;
        }
    }
}