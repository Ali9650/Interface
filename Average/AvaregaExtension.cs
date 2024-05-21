

namespace Average
{
    internal static class AvaregaExtension
    {
        public static double CalculateAverage(this int[] array)
        {
            int sum = 0;
            foreach (int num in array)
            {
                sum += num;
            }
            return (double)sum / array.Length;
        }
    }
}
