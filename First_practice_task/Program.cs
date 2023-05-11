namespace First_practice_task
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
        
            string sequenceString = Console.ReadLine();
            if (sequenceString.Length == 0)
            {
                Console.WriteLine("Ошибка: строка не указана в аргументах командной строки.");
                return;
            }

            int maxLength = 0;
            int currentLength = 0;
            char previousChar = '\0';

            foreach (char c in sequenceString)
            {
                if (c != previousChar)
                {
                    currentLength++;
                    if (currentLength > maxLength) maxLength = currentLength;
                }
                else currentLength = 1;

                previousChar = c;
            }

            Console.WriteLine("Максимальное количество неодинаковых последовательных символов в строке: " + maxLength);
        }
    }
}