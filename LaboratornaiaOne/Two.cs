using System;


namespace TwoName
{
    public class Two
    {
        private int xAxis = 5, yAxis = 3, testMax = 10; private bool resultCalculation;
        public int xOne, yOne, xCout, yCout;

        public void Menu()
        {
            Console.Write("Введите координаты точки по x: ");
            xCout = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки по y: ");
            yCout = int.Parse(Console.ReadLine());
        }

        public void CoutResult()
        {
            if (resultCalculation)
                Console.WriteLine("Точка ПРИНАДЛЕЖИТ!\n");
            else
                Console.WriteLine("Точка НЕ ПРИНАДЛЕЖИТ");
        }

        public void Answer()
        {
            Console.WriteLine("ЗАДАЧА 2");
            while (true)
            {
                Console.WriteLine("Введите желаемое количество тестов на принадлежность точки(не болеее 10-ти): ");
                uint amountTest = uint.Parse(Console.ReadLine());
                if(amountTest>testMax)
                {
                    Console.WriteLine("\nВВЕДЕННОЕ КОЛИЧЕСТВО ТЕСТОВ ПРЕВЫШАЕТ ДОПУСТИМОЕ, ПОВТОРИТЕ ВВОД!\n");
                    continue;
                }

                else
                {
                    for(uint i=0;i<amountTest;i++)
                    {
                        Menu();
                        if ((yCout <= xAxis - 2 && yCout >= 0) && (xCout <= yAxis + 2 && xCout >= 0))
                        {
                            resultCalculation = true;
                            CoutResult();
                        }
                        else
                        {
                            resultCalculation = false;
                            CoutResult();
                        }   
                    }
                    break;
                }
            }
        }
    }
}
