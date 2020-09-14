using System;


namespace TwoName
{
    public class Two
    {
        private int xAxis = 5, yAxis = 3, testMax = 10; 
        private bool resultCalculation, blockforFor = false;
        private uint amountTest = 11;
        public int xOne, yOne, xCout, yCout;

        public void Menu()
        {
            Console.Write("Введите координаты точки по x: ");
            xCout = int.Parse(Console.ReadLine());
            Console.Write("Введите координаты точки по y: ");
            yCout = int.Parse(Console.ReadLine());
            blockforFor = false;
        }

        public void CoutResult()
        {
            if (resultCalculation)
                Console.Write("Точка ПРИНАДЛЕЖИТ!\n");
            else
                Console.Write("Точка НЕ ПРИНАДЛЕЖИТ\n");
        }

        public void Answer()
        {
            Console.WriteLine("ЗАДАЧА 2");
            do
            {
                try
                {
                    Console.WriteLine("Введите желаемое количество тестов на принадлежность точки(не болеее 10-ти): ");
                    amountTest = uint.Parse(Console.ReadLine());
                    if (amountTest > testMax)
                        Console.WriteLine("\nВВЕДЕННОЕ КОЛИЧЕСТВО ТЕСТОВ ПРЕВЫШАЕТ ДОПУСТИМОЕ, ПОВТОРИТЕ ВВОД!\n");
                }
                catch(FormatException fEX)
                {
                    Console.WriteLine(fEX.Message);
                }
                
            } while (amountTest > testMax);
                
            for(uint i=0;i<amountTest;i++)
            {
                try
                {
                    if(i==0)
                    Console.WriteLine("\nТест № "+(i+1)+" (данный тест будет определяющим к примеру точка с координатами: х=4, y=2, будет ПРИНАДЛЕЖАТЬ области)");
                    else
                        Console.WriteLine("\nTecт № " + (i + 1));

                    Menu();
                    if (!blockforFor)
                    {
                        if ((yCout <= xAxis - 2 && yCout >= 0) && (xCout <= yAxis + 2 && xCout >= 0))
                        {
                            resultCalculation = true;
                            CoutResult();
                            if (xCout == 4 && yCout == 2 && i == 0)
                            {
                                Console.WriteLine("Тест пройден УДАЧНО!");
                            }
                                
                        }
                        else
                        {
                            resultCalculation = false;
                            CoutResult();
                            if (xCout == 4 && yCout == 2 && i == 0)
                            {
                                Console.WriteLine("Тест пройден НЕУДАЧНО!");
                            }
                        }
                    }
                }
                catch(FormatException fEX)
                {
                    blockforFor = true;
                    i -= 1;
                    Console.WriteLine(fEX.Message);
                }
            }
        }
    }
}
