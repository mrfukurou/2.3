using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                
                int i = 10;
                Console.Write("n=");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n > 0 && n >= 10)
                {
                    Console.Write("for: ");
                    for (i = 10; i <= n && i <= 99; i++)
                        if (i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88 && i != 99)
                        { Console.Write(i + " "); }
                    Console.Write("\n");
                    i = 9;
                    Console.Write("while: ");
                    while (i < n)
                    {
                        i++;
                        if (i <= 99 && i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88 && i != 99)
                        { Console.Write(i + " "); }
                    }
                    Console.Write("\n");
                    i = 9;
                    Console.Write("do while: ");
                    do
                    {
                        i++;
                        if (i <= 99 && i != 11 && i != 22 && i != 33 && i != 44 && i != 55 && i != 66 && i != 77 && i != 88 && i != 99)
                        { Console.Write(i + " "); }
                    }
                    while (i < n);
                }
                else Console.Write("Некорректный ввод!");
            }
            catch { Console.Write("Некорректный ввод!"); }
        }
    }
}
