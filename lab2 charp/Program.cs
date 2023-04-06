namespace lab2_charp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // task 1
            DisplayArrayStatistics.DisplayArrayStatisticsFunc(args);

            //task 2
            CountValuesLessThanThreshold.CountValuesLessThanThresholdFunc(args);

            //task 3 
            CountSequenceOccurrences.CountSequenceOccurrencesFunc(args);

            //task 4
            FindUniqueCommonValues.FindUniqueCommonValuesFunc(args);

            //task 5
            GetMinMaxValues.GetMinMaxValuesFunc(args);

            //task 6 
            GetWordCount.GetWordCountFunc(args);
        }
    }
}