using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomMatrix
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            Console.Write("Введите количество строк в будущей матрице: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в будущей матрице: ");
            int col = int.Parse(Console.ReadLine());

            int [,] arr2d = new int [row,col]; // объявляем и инициализируем двумерный массив
                                              // с заданным пользователем количеством строк и столбцов

            int sum = 0;  // переменная для суммы элементов массива

            Random r = new Random(); // инициализируем генератор рандомных чисел

            for (int i=0; i<row; i++) // задаем вложенный цикл для строк
            {
                

                for (int j=0; j<col; j++) // задаем вложенный цикл для столбцов
                {
                    arr2d [i,j] = r.Next(10); // заполняем матрицу рандомными числами

                    sum += arr2d[i, j]; // в сумму добавляем значения всех элементов

                    Console.Write($"{arr2d [i,j], 2}"); // выводим матрицу на экран
                    
                }
                Console.WriteLine();
               
            }
            Console.WriteLine($"Сумма всех элементов в матрице: {sum}");

            Console.ReadKey();
        } 
    }
}


