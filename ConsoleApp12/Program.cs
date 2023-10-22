using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void task1()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            foreach (int num in numbers)
            {
                Console.WriteLine(num);
            }

        }

        static void task2()
        {
            int[] numbers = { 1, 5, 3, 7, 2 };
            int maxIndex = Array.IndexOf(numbers, numbers.Max());
            Console.WriteLine("Индекс максимального значения: " + maxIndex);

        }

        static void task3()
        {
            int[] numbers = { 1, 5, 8, 7, 2 };
            int maxEvenIndex = Array.IndexOf(numbers, numbers.Where(x => x % 2 == 0).Max());
            Console.WriteLine("Индекс максимального четного значения: " + maxEvenIndex);

        }

        static void task4()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int indexToRemove = 2; // Индекс элемента для удаления
            numbers = numbers.Where((val, index) => index != indexToRemove).ToArray();
            Console.WriteLine(string.Join(", ", numbers));


        }

        static void task5()
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            int valueToRemove = 3; // Значение для удаления
            numbers = numbers.Where(val => val != valueToRemove).ToArray();//
            Console.WriteLine(string.Join(", ", numbers));


        }

        static void task6()
        {
            List<int> numbersList = new List<int> { 1, 2, 3, 5 };
            int valueToInsert = 4;
            int indexToInsert = 3;
            numbersList.Insert(indexToInsert, valueToInsert);
            int[] numbers = numbersList.ToArray();
            Console.WriteLine(string.Join(", ", numbers));


        }

        static void task7()
        {
            int[] numbers = { 1, 2, 2, 3, 4, 4, 5 };
            numbers = numbers.GroupBy(x => x).Where(g => g.Count() != 2).SelectMany(g => g).ToArray();
            Console.WriteLine(string.Join(", ", numbers));


        }

        static void task8()
        {
            Console.WriteLine("Введите строку с словами: ");
            string inputString = Console.ReadLine();
            

            string[] words = inputString.Split(' ');
            var resultWords = words.Where(word => !word.Contains('a')).ToArray();
            string result = string.Join(" ", resultWords);
            Console.WriteLine(result);



        }

        static void task9()
        {
            Console.WriteLine("Введите строку с словами: ");
            string inputString = Console.ReadLine();
           

            string[] words = inputString.Split(' ');
            string lastWord = words.Last();
            string result = string.Join(" ", words.Where(word => !word.Contains(lastWord.First())));
            Console.WriteLine(result);


        }

        static void task10()
        {
            Console.WriteLine("Введите строку с словами: ");
            string inputString = Console.ReadLine();
            

            string[] words = inputString.Split(' ');
            string result = string.Join(" ", words.Select(word =>
                word.Length > 1 && word.First() == word.Last()
                ? "[" + word + "]"
                : word));
            Console.WriteLine(result);


        }

        static void task11()
        {
            int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, i] % 2 == 0)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        static void task12()
        {
            int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9}
};

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (matrix[j, j] % 2 == 0)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        static void task13()
        {
            int[,] matrix = {
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 8}
};

            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                bool hasDuplicate = false;
                for (int i = 0; i < matrix.GetLength(0) - 1; i++)
                {
                    for (int k = i + 1; k < matrix.GetLength(0); k++)
                    {
                        if (matrix[i, j] == matrix[k, j])
                        {
                            hasDuplicate = true;
                            break;
                        }
                    }
                    if (hasDuplicate)
                    {
                        break;
                    }
                }

                if (hasDuplicate)
                {
                    for (int i = 0; i < matrix.GetLength(0); i++)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }


        }

        static void task14()
        {
            string input = Console.ReadLine();
            int spaceCount = input.Count(c => c == ' ');
            Console.WriteLine("Количество пробелов: " + spaceCount);

        }

        static void task15()
        {
            string ticketNumber = Console.ReadLine();
            if (ticketNumber.Length == 6)
            {
                int sumFirstThree = ticketNumber.Take(3).Sum(c => c - '0');
                int sumLastThree = ticketNumber.Skip(3).Sum(c => c - '0');

                if (sumFirstThree == sumLastThree)
                {
                    Console.WriteLine("Счастливый билет!");
                }
                else
                {
                    Console.WriteLine("Обычный билет.");
                }
            }

        }
        static void Main(string[] args)
        {
            task10();
            Console.ReadKey();
        }
    }
}
