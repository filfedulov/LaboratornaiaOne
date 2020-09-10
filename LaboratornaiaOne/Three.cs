using System;


namespace ThreeName
{
    class Three
    {
        private double b = 0.0001, aKvadrat, bKvadrat, abKvadrat, resultDouble;
        private float resultFloat;
        private int a = 1000;

        public void Menu()
        {
            Console.WriteLine("ЗАДАЧА 3");
            while(true)
            {
                Console.WriteLine("Выберите индекс действие\n1.Вычислить значение выражения для double;\n2.Вычислить для float;\n3.Выход.");
                int choiceIndex = int.Parse(Console.ReadLine());
                if (choiceIndex == 1)
                {
                    Console.WriteLine(SolutionForDouble()+"\n");
                    continue;
                }
                else if (choiceIndex == 2)
                {
                    Console.WriteLine(SolutionForFloat()+"\n");
                    continue;
                }
                else
                    break;
            }
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
