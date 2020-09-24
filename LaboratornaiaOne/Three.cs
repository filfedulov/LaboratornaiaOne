using System;
using System.Linq.Expressions;

namespace ThreeName
{
    class Three
    {
        private double b = 0.0001, aKvadrat, bKvadrat, abKvadrat, resultDouble;
        private float resultFloat;
        private int a = 1000, choiceIndex, iD, iF;
        private const double DOUBLE_ANSWER = 1.00117176771164, FLOAT_ANSWER = -1250000;
        private string forThreeTestd_, forThreeTestf_;

        public void Menu()
        {
            forThreeTestd_ = Convert.ToString(DOUBLE_ANSWER);
            forThreeTestf_ = Convert.ToString(FLOAT_ANSWER);
            Console.WriteLine("ЗАДАЧА 3(Протестируем данные значения, они должны соответствовать при double = 1,00117176771164, при преобразовании во float = -1250000.)");
              
                do
                {
                try
                {
                    Console.WriteLine("Выберите индекс действие\n1.Вычислить значение выражения для double;\n2.Вычислить для float;\n3.Выход.");
                    choiceIndex = int.Parse(Console.ReadLine());
                    switch (choiceIndex)
                    {
                        case 1:
                            Console.WriteLine(SolutionForDouble() + "\n");
                            if (iD == 0)
                            {
                                if (Convert.ToString(SolutionForDouble()) == forThreeTestd_)
                                    Console.WriteLine("Double значение УДАЧНО прошло тест\n");
                                else
                                    Console.WriteLine("Double значение НЕУДАЧНО прошло тест\n");
                            }
                            iD++;
                            break;
                        case 2:
                            Console.WriteLine(SolutionForFloat() + "\n");
                            if (iF == 0)
                            {
                                if (Convert.ToString(SolutionForFloat()) == forThreeTestf_)
                                    Console.WriteLine("Float значение УДАЧНО прошло тест\n");
                                else
                                    Console.WriteLine("Float значение НЕУДАЧНО прошло тест\n");
                            }
                            iF++;
                            break;
                        default:
                            if (choiceIndex != 3)
                                Console.WriteLine("Нет действия под данным индексом! Повторите ввод...\n");
                            break;

                    }
                }
                catch(FormatException fEX)
                {
                    Console.WriteLine(fEX.Message);
                }
                } while (choiceIndex != 3);
            
            
           
        }
        public double SolutionForDouble()
        {
            aKvadrat = Math.Pow(a, 2);
            bKvadrat = Math.Pow(b, 2);
            abKvadrat = aKvadrat + 2 * a * b + bKvadrat;
            resultDouble = (abKvadrat - (aKvadrat + 2 * a * b)) / bKvadrat;

            return resultDouble;
        }
        public float SolutionForFloat()
        {
            aKvadrat = Math.Pow(a, 2);
            bKvadrat = Math.Pow(b, 2);
            abKvadrat = (float)(aKvadrat + 2 * a * b + bKvadrat);
            resultFloat = (float)((abKvadrat - (aKvadrat + 2 * a * b)) / bKvadrat);

            return resultFloat;
        }
    }
}
