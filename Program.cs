namespace Lab_9b
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 6, 7, 8, 9, 10 };

            int[] resultArray = AddArrays(array1, array2);

            Console.WriteLine("Array 1: " + string.Join(", ", array1));
            Console.WriteLine("Array 2: " + string.Join(", ", array2));
            Console.WriteLine("Result Array: " + string.Join(", ", resultArray));
        }

        static int[] AddArrays(int[] array1, int[] array2)
        {
            int length = Math.Min(array1.Length, array2.Length);
            int[] result = new int[length];

            for (int i = 0; i < length; i++)
            {
                result[i] = array1[i] + array2[i];
            }

            return result;
        }
    }
}