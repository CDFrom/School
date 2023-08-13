using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LA_1._1
{
    class Program
    {
        public static double Mean(double[] data)
        {
            double sum = 0;
            foreach (var val in data)
                sum += val;
            return sum / data.Length;
        }

        public static double StandardDeviation(double[] data, double mean)
        {
            double num = 0;
            foreach (var val in data)
            {
                var diff = val - mean;
                num += diff * diff;
            }
            return Math.Sqrt(num) / data.Length;
        }

        public static double[] Sort(double[] data)
        {
            var sorted = (double[])data.Clone();
            Array.Sort(sorted);
            return sorted;
        }

        public static double Median(double[] data)
        {
            return data[data.Length / 2];
        }

        public static double Mode(double[] data)
        {
            double mode = 0;
            int count = 0;
            double testMode = 0;
            int testCount = 0;
            for (int i = 0; i < data.Length; i += testCount)
            {
                testMode = data[i];
                testCount = 1;
                for (int j = 1; j + i < data.Length; ++j)
                {
                    if (testMode == data[i + j])
                        ++testCount;
                    else
                        break;
                }
                if (testCount > count)
                {
                    mode = testMode;
                    count = testCount;
                }
            }
            return mode;
        }

        static void Main(string[] args)
        {
            int dataCount = int.Parse(Console.ReadLine());
            var data = new double[dataCount];
            for (int i = 0; i < dataCount; ++i)
                data[i] = double.Parse(Console.ReadLine());

            var meanTask = Task<double>.Run(() => Mean(data));
            var sortTask = Task<double[]>.Run(() => Sort(data));

            Task<double> standardDeviationTask = null;
            Task<double> medianTask = null;
            Task<double> modeTask = null;

            var firstTasks = new Task[2];
            firstTasks[0] = meanTask;
            firstTasks[1] = sortTask;

            var secondTasks = new Task[3];

            int index = Task.WaitAny(firstTasks);
            if (index == 0)
            {
                var mean = meanTask.Result;
                secondTasks[0] = standardDeviationTask = Task.Run(() => StandardDeviation(data, mean));
                Task.WaitAll(firstTasks[1]);
                var sorted = sortTask.Result;
                secondTasks[1] = medianTask = Task.Run(() => Median(sorted));
                secondTasks[2] = modeTask = Task.Run(() => Mode(sorted));
            }
            else
            {
                var sorted = sortTask.Result;
                secondTasks[1] = medianTask = Task.Run(() => Median(sorted));
                secondTasks[2] = modeTask = Task.Run(() => Mode(sorted));
                Task.WaitAll(firstTasks[0]);
                var mean = meanTask.Result;
                secondTasks[0] = standardDeviationTask = Task.Run(() => StandardDeviation(data, mean));
            }

            Console.WriteLine("Mean = " + meanTask.Result);
            Console.WriteLine("Median = " + medianTask.Result);
            Console.WriteLine("Mode = " + modeTask.Result);
            Console.WriteLine("Standard Deviation = " + standardDeviationTask.Result);
        }
    }

}
