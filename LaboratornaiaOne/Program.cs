using System;
using OneName;
using TwoName;
using ThreeName;


namespace MainName
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                One objectOne = new One();
                objectOne.SolutionTaskOne();
                Console.WriteLine();

                Two objectTwo = new Two();
                objectTwo.Answer();
                Console.WriteLine();

                Three objectThree = new Three();
                objectThree.Menu();
                Console.WriteLine();
            }
            catch(Exception)
            {
                Console.WriteLine("НЕПРЕДВИДЕННЫЕ ПРОБЛЕМЫ.");
            }
        }
    }
}
