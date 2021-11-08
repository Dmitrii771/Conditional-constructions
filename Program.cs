using System;

namespace Conditional_constructions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            //int a, b;
            //int.TryParse(Console.ReadLine(), out a);
            //int.TryParse(Console.ReadLine(), out b);
            //if (a > b)
            //{
            //    Console.Write("Первое число больше второго");
            //}
            //else if (a < b)
            //{
            //    Console.Write("Первое число меньше второго");
            //}
            //else
            //{
            //    Console.Write("Два числа равны");
            //}
            #endregion
            #region Exercise 2
            //int a;
            //int.TryParse(Console.ReadLine(), out a);
            //if (a > 5 && a < 10)
            //{
            //    Console.Write("Число больше 5 и меньше 10");
            //}
            //else
            //    Console.Write("Неизвестное число");
            #endregion
            #region Exercise 3
            //int a;
            //int.TryParse(Console.ReadLine(), out a);
            //if (a == 5 || a == 10)
            //{
            //    Console.Write("Число либо равно 5, либо равно 10");
            //}
            //else
            //    Console.Write("Неизвестное число");
            #endregion
            #region Exercise 4
            double a;
            var sum = 0.0;
            a = Convert.ToDouble(Console.ReadLine());
            if (a < 100)
            {
                sum = a + (a * 0.05);
               

            }
            if (a > 100 && a < 200)
            {
                sum = a + (a * 0.07);
               
            }
            if (a > 200)
            {
                sum = a + (a * 0.1);
                
            }
            Console.Write(sum);
            #endregion
            #region Exercise 6,7
            //Console.WriteLine("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
            //int o = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите два числа");
            //int a,b;
            //int.TryParse(Console.ReadLine(), out a);
            //int.TryParse(Console.ReadLine(), out b);
            //switch (o)
            //{
            //    case 1:
            //        Console.WriteLine("Сложение");
            //        Console.Write(a+b);
            //        break;
            //    case 2:
            //        Console.WriteLine("Вычитание");
            //        Console.Write(a - b);
            //        break;
            //    case 3:
            //        Console.WriteLine("Умножение");
            //        Console.Write(a * b);
            //        break;
            //    default:
            //        Console.WriteLine("Такой операции не существует");
            //        break;
            //}
            #endregion
            // Циклы
            #region Ex1
            //int kol;
            //int.TryParse(Console.ReadLine(), out kol);
            //decimal sum = Convert.ToDecimal(Console.ReadLine());

            #endregion
        }
    }
}
