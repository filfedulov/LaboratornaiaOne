using System;


namespace OneName
{
    public class One
    {
        public int m, n;
        private int resultOne, testMax = 10; private bool resultFree, resultTwo; private double x, xSin, xKub, xKvadrat, resultFour;
        public void Menu()
        {
            Console.WriteLine("ЗАДАЧА 1");
            Console.Write("Введите значение n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Значение m: ");
            m = int.Parse(Console.ReadLine());
        }
        public void SolutionTaskOne(int n, int m)
        {
            resultOne = n++ + m; 
            Console.Write("\n1.) ");
            Console.WriteLine("Данное выражение n++ + m является арифметическим, и = " + resultOne + ".");

            Console.Write("2.) ");
            resultTwo = m-- > n;
            Console.WriteLine("Данное выражение m-- > n является отношением, и = " + resultTwo + ".");

            Console.Write("3.) ");
            resultFree = n-- > m;
            Console.WriteLine("Данное выражение n-- > m является отношением, и = " + resultFree + ".");

            Console.Write("4.) ");
            while(true)
            {
                Console.Write("Введите желаемое количество тестов над x(количество тестов не более 10-ти): ");
                uint amountTest = uint.Parse(Console.ReadLine());
                
                if (amountTest > testMax)
                {
                    Console.WriteLine("\nВВЕДЕННОЕ КОЛИЧЕСТВО ТЕСТОВ ПРЕВЫШАЕТ ДОПУСТИМОЕ, ПОВТОРИТЕ ВВОД!\n");
                    continue;
                }
                
                else
                {
                    for (int i = 0; i < amountTest; i++)
                    {
                        Console.WriteLine("Tecт № " + (i + 1));
                        Console.Write("Введите значение x: ");
                        x = double.Parse(Console.ReadLine());
                        xSin = Math.Sin(x);
                        xKub = Math.Pow(x, 3);
                        xKvadrat = Math.Pow(x, 2);
                        resultFour = xSin + xKub + 1 / xKvadrat + 1;

                        if (x == 0)
                            Console.WriteLine("Значение данного выражения sin(x) + x^3 + 1/x^2 + 1, при x = " + (x) + ", стремится к бесконечности.");
                        else
                            Console.WriteLine("Значение данного выражения sin(x) + x^3 + 1/x^2 + 1, при x = " + (x) + ", = " + resultFour + ".");
                    }
                    break;
                }
            }
        }
    }
}

