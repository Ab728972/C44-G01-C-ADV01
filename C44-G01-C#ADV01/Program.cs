namespace C44_G01_C_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
        }
        #region SortingAlgorithms
        public class SortingAlgorithms
        {
            public static void OptimizedBubbleSort<T>(T[] array) where T : IComparable<T>
            {
                bool swapped;
                int n = array.Length;

                for (int i = 0; i < n - 1; i++)
                {
                    swapped = false;

                    // Last i elements are already in place
                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            // Swap elements
                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            swapped = true;
                        }
                    }

                    // If no swaps occurred, array is sorted
                    if (!swapped) break;
                }
                #endregion
            }
        }
    }
}
