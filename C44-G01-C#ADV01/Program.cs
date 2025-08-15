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
                #region Range T 
                public class Range<T> where T : IComparable<T>
            {
                public T Minimum { get; }
                public T Maximum { get; }

                public Range(T min, T max)
                {
                    if (min.CompareTo(max) > 0)
                        throw new ArgumentException("Minimum cannot be greater than maximum");

                    Minimum = min;
                    Maximum = max;
                }

                public bool IsInRange(T value)
                {
                    return value.CompareTo(Minimum) >= 0 && value.CompareTo(Maximum) <= 0;
                }

                public T Length()
                {
                    // For numeric types, we'd need to use dynamic or other approaches
                    // This simple implementation assumes T supports subtraction
                    // A more complete solution would require additional constraints
                    dynamic min = Minimum;
                    dynamic max = Maximum;
                    return max - min;
                }

                public override string ToString()
                {
                    return $"[{Minimum} - {Maximum}]";
                }
            }
            #endregion 
        }
    }
    }

