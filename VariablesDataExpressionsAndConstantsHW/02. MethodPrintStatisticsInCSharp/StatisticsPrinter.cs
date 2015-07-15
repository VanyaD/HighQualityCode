namespace _02.MethodPrintStatisticsInCSharp
{
    using System;

    public class StatisticsPrinter
    {
        public void PrintStatistics(double[] numbers, int count)
        {
            double largestNumber = numbers[0];
            double smallestNumber = numbers[0];
            double sum = 0;
            
            for (int i = 1; i < count; i++)
            {
                if (numbers[i] > largestNumber)
                {
                    largestNumber = numbers[i];
                }

                if (numbers[i] < smallestNumber)
                {
                    smallestNumber = numbers[i];
                }

                sum += numbers[i];
            }

            this.LargestNumber(largestNumber);      
            this.SmallestNumber(smallestNumber);

            double average = sum / count;
            this.Average(average);        
        }

        private void Average(double average)
        {
            Console.WriteLine("The average of the numbers is: {0}", average);
        }

        private void SmallestNumber(double minResult)
        {
            Console.WriteLine("The smallest number is: {0}", minResult);
        }

        private void LargestNumber(double maxResult)
        {
            Console.WriteLine("The largest number is: {0}", maxResult);
        }
    }
}
