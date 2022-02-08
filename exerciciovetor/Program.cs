using System;
using System.Globalization;

namespace exerciciovetor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberChoose = int.Parse(Console.ReadLine());
            double[] heightPeaplo = new double[numberChoose];

            for (int i = 0; i < numberChoose; i++)
            {
                heightPeaplo[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);    
            }

            double sum = 0.0;
            for(int i = 0; i < numberChoose; i++)
            {
                 sum += heightPeaplo[i];
            }

            double avaregeHeight = sum / numberChoose;

            Console.WriteLine("Avarege Height = "+ avaregeHeight.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
