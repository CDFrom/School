using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
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

        public static double[] Sort(double[] data)
        {
            var sorted = (double[])data.Clone();
            Array.Sort(sorted);
            return sorted;
        }

        public static int GreaterThanEqualToMean(double[] data, double mean)
        {
            int count = 0;
            foreach (var value in data)
            {
                if (value >= mean)
                {
                    count++;
                }
            }
            return count++;
        }

        public static double MinimumValue(double[] data)
        {
            return data[0];
        }

        public static double MaximumValue(double[] data)
        {
            return data[data.Length - 1];
        }

        static void Main(string[] args)
        {
            Console.Write("Total number of values: ");
            int dataCount = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            var data = new double[dataCount];
            for (int i = 0; i < dataCount; ++i)
                data[i] = double.Parse(Console.ReadLine());

            var meanTask = Task<double>.Run(() => Mean(data));
            var sortTask = Task<double[]>.Run(() => Sort(data));

            Task<int> greaterThanEqualToMeanTask = null;
            Task<double> minimumValueTask = null;
            Task<double> maximumValueTask = null;

            var firstTasks = new Task[2];
            firstTasks[0] = meanTask;
            firstTasks[1] = sortTask;

            var secondTasks = new Task[3];

            int index = Task.WaitAny(firstTasks);
            if (index == 0)
            {
                var mean = meanTask.Result;
                secondTasks[0] = greaterThanEqualToMeanTask = Task.Run(() => GreaterThanEqualToMean(data, mean));
                Task.WaitAll(firstTasks[1]);
                var sorted = sortTask.Result;
                secondTasks[1] = minimumValueTask = Task.Run(() => MinimumValue(sorted));
                secondTasks[2] = maximumValueTask = Task.Run(() => MaximumValue(sorted));
            }
            else
            {
                var sorted = sortTask.Result;
                secondTasks[1] = minimumValueTask = Task.Run(() => MinimumValue(sorted));
                secondTasks[2] = maximumValueTask = Task.Run(() => MaximumValue(sorted));
                Task.WaitAll(firstTasks[0]);
                var mean = meanTask.Result;
                secondTasks[0] = greaterThanEqualToMeanTask = Task.Run(() => GreaterThanEqualToMean(data, mean));
            }

            Console.WriteLine();
            Console.WriteLine("Max: " + maximumValueTask.Result);
            Console.WriteLine("Min: " + minimumValueTask.Result);
            Console.WriteLine();
            Console.WriteLine("Number of values greater than mean: " + greaterThanEqualToMeanTask.Result);
        }
    }

}
