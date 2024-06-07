
namespace hw18
{
    public class DaytimeTemperature
    {
        public double Highest { get; set; }
        public double Lowest { get; set; }
    }

    public static class DaytimeTemperatureExtensions
    {
        public static int DayTemperatureDifference(this DaytimeTemperature[] temperatures)
        {
            int DiffIndex = 0;
            double maxDifference = temperatures[0].Highest - temperatures[0].Lowest;

            for (int i = 1; i < temperatures.Length; i++)
            {
                double difference = temperatures[i].Highest - temperatures[i].Lowest;
                if (difference > maxDifference)
                {
                    maxDifference = difference;
                    DiffIndex = i;
                }
            }
            return DiffIndex;
        }
    }
}
