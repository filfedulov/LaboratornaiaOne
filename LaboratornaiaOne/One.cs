using System;


namespace OneName
{
    public class One
    {
        public int n, m, n_, m_;
        private int resultOne, testMax = 10; 
        private bool resultFree, resultTwo; 
        private double x, x_, xSin, xKub, xKvadrat, resultFour;
        private uint amountTest = 11;
        private const double X = 2.3414709848079;
        private string forFourTest;
        public void Menu()
        {
            Console.WriteLine("ЗАДАЧА 1");
            Console.WriteLine("Проведем один тест к примеру, при n = 1, m = 2, их значения, после всех операций будут\n n = 1, m = 1.");
            Console.Write("Введите значение n: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Значение m: ");
            m = int.Parse(Console.ReadLine());
            n_ = n;
            m_ = m;
        }
        public void SolutionTaskOne()
        {
            while(true) // на случай, если будет не корректный ввод, чтобы не выходить из программы(непонятно сколько раз будет произведен некорректный ввод)
            {
                try
                {
                    Menu();
                    resultOne = n++ + m;
                    Console.Write("\n1.) ");
                    Console.WriteLine("Данное выражение n++ + m является арифметическим, и = " + resultOne + ".");
                    Console.WriteLine("Значение на данный момент: n = " + (n) + "; m = " + (m) + ".\n");

                    Console.Write("2.) ");
                    resultTwo = m-- > n;
                    Console.WriteLine("Данное выражение m-- > n является отношением, и = " + resultTwo + ".");
                    Console.WriteLine("Значение на данный момент: n = " + (n) + "; Значение m = " + (m) + ".\n");

                    Console.Write("3.) ");
                    resultFree = n-- > m;
                    Console.WriteLine("Данное выражение n-- > m является отношением, и = " + resultFree + ".");
                    Console.WriteLine("Значение, после всех операций: n = " + (n) + "; Значение m = " + (m) + ".\n");
                    
                    if(n_==1 && m_==2) // потому-что тест предназначен именно для этих значений n=1 m=2
                    {
                        if (n == 1 && m == 1)
                            Console.WriteLine("Тест пройден УДАЧНО!\n");
                        else
                            Console.WriteLine("Тест пройден НЕУДАЧНО(\n");
                    }

                    break;
                }
                catch (FormatException fEX)
                {
                    Console.WriteLine(fEX.Message);
                }
            }
            
            Console.Write("4.) ");
            do
            {
                try
                {
                    Console.Write("Введите желаемое количество тестов над x(количество тестов не более 10-ти): ");
                    amountTest = uint.Parse(Console.ReadLine());
                    if(amountTest>testMax)
                        Console.WriteLine("\nВВЕДЕННОЕ КОЛИЧЕСТВО ТЕСТОВ ПРЕВЫШАЕТ ДОПУСТИМОЕ, ПОВТОРИТЕ ВВОД!\n");
                }
                catch(FormatException fEX)
                {
                    Console.WriteLine(fEX.Message);
                }
                
            } while (amountTest>testMax);
                
                
            for (int i = 0; i < amountTest; i++)
            {
                if(i == 0) 
                {
                    forFourTest = Convert.ToString(X);
                    Console.WriteLine("\nTecт № " + (i + 1) + " (данный тест будет определяющим к примеру при x = 1 значение выражения\n sin(x) + x^3 + 1/x^2 + 1 = 2,3414709848079.)");
                }
                else
                    Console.WriteLine("\nTecт № " + (i + 1));

                Console.Write("Введите значение x: ");
                try
                {
                    x = double.Parse(Console.ReadLine());
                    x_ = x;
                    xSin = Math.Sin(x);
                    xKub = Math.Pow(x, 3);
                    xKvadrat = Math.Pow(x, 2);
                    resultFour = xSin + xKub + 1 / (xKvadrat + 1);
                    Console.WriteLine("Значение данного выражения sin(x) + x^3 + 1/x^2 + 1, при x = " + (x) + ", = " + resultFour + ".");
                    if(x_ == 1 && i == 0)
                    {
                        if (Convert.ToString(resultFour) == forFourTest)
                            Console.WriteLine("Тест пройден УДАЧНО!");
                        else 
                            Console.WriteLine("Тест пройден НЕУДАЧНО(");
                    }
                }
                catch(FormatException fEx)
                {
                    i -= 1;
                    Console.WriteLine(fEx.Message);
                }
            }
        }
    }
}

