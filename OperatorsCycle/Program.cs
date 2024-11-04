using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsCycle
{
    internal class Program
    {
        static void Main(string[] args)
        {   //1
            for (int i = 2; i <= 20; i+=2) 
                Console.WriteLine(i);
            //2
            int Summ = 0; ;
            for (int i = 1;i <= 100;i++)
                Summ = Summ+i;
                Console.WriteLine(Summ);
            //3
           Console.WriteLine("Введіть число: ");
            int N = int.Parse(Console.ReadLine()); 
            for (int i = 1; i <= 10; i++)
                Console.WriteLine($"{N}*{i}={N*i}");
            //4
            Console.WriteLine("Введіть число: ");
            int Num = int.Parse(Console.ReadLine());
            int f = 1;
            for (int i = 1; i <= Num; i++)
                f = f * i;
            Console.WriteLine(f);

            // 5. Знайти суму всіх простих чисел в межах від 1 до 50
            int sum = 0;
            for (int num = 2; num <= 50; num++)
            {
                if (IsPrime(num))
                {
                    sum += num;
                }
            }
            Console.WriteLine($"Сума всіх простих чисел від 1 до 50: {sum}");

            // 6. Перевести число в двійкову систему числення
            Console.Write("Введіть число для переведення в двійкову систему: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Число {number} в двійковій системі: {Convert.ToString(number, 2)}");

            // 7. Сума чисел Фібоначчі, яка менша заданого числа
            Console.Write("Введіть число для обчислення суми Фібоначчі: ");
            int limit = int.Parse(Console.ReadLine());
            (int fibSum, int count) = FibonacciSum(limit);
            Console.WriteLine($"Сума чисел Фібоначчі, які менші {limit}: {fibSum}, Кількість елементів: {count}");

            // 8. Найбільший спільний дільник (НСД)
            Console.Write("Введіть перше число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Введіть друге число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Найбільший спільний дільник чисел {a} та {b}: {GCD(a, b)}");
            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }

        static (int sum, int count) FibonacciSum(int limit)
        {
            int sum = 0;
            int a = 0, b = 1;
            int count = 0;

            while (b < limit)
            {
                sum += b;
                count++;
                int temp = a;
                a = b;
                b = temp + b;
            }
            return (sum, count);
        }

        static int GCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }
        
    }
}
