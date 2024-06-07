
namespace hw18
{
    public static class IntExtensions
    {
        public static bool FibonacciCheck(this int num)
        {
            return Math.Sqrt(5 * Math.Pow(num, 2) - 4) % 1 == 0 || Math.Sqrt(5 * Math.Pow(num, 2) + 4) % 1 == 0;
        }
    }
}
