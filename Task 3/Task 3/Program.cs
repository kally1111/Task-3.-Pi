using System;
using System.Threading;
namespace Task_3
{
    class Program
    {
        static void Main()
        {
            int totalPoints = 3_000_000;
            int a = 0;
            int pointsCircle = 0;
            Random rnd = new Random();
            double min = -0.5;
            double max = 0.5;
            while (a<=totalPoints)
            {
                double x = rnd.NextDouble() * (max - min) + min; 
                double y = rnd.NextDouble() * (max - min) + min;
                double distance = Math.Sqrt(x * x + y * y);

                if (distance<=max)
                {
                    pointsCircle++;
                }
                a++;
            }

            double pi=4.0*pointsCircle / totalPoints ;
            Console.Write($"Pi is: {Math.Round(pi, 15)}");
        }

    }
}
