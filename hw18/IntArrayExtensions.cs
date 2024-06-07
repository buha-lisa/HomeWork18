
namespace hw18
{
    public static class IntArrayExtensions
    {
        public static int[] Filter(this int[] array, Predicate<int> predicate)
        {
            int size = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    size++;
                }
            }
            int[] result = new int[size];
            int index = 0;
            foreach (var item in array)
            {
                if (predicate(item))
                {
                    result[index++] = item;
                }
            }
            return result;
        }
    }
}
