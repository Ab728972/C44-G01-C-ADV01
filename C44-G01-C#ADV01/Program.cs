using static C44_G01_C_ADV01.SortingAlgorithms;

namespace C44_G01_C_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 4, 2 };
            Console.WriteLine("Before sorting: " + string.Join(", ", numbers));

            SortingAlgorithms.OptimizedBubbleSort(numbers);
            Console.WriteLine("After sorting: " + string.Join(", ", numbers));

            // Range Test
            var intRange = new Range<int>(10, 20);
            Console.WriteLine($"Range: {intRange}");
            Console.WriteLine($"Is 15 in range? {intRange.IsInRange(15)}");
            Console.WriteLine($"Range length: {intRange.Length()}");

            var dateRange = new Range<DateTime>(
                new DateTime(2023, 1, 1),
                new DateTime(2023, 12, 31));
            Console.WriteLine($"Is July in range? {dateRange.IsInRange(new DateTime(2023, 7, 1))}");
        }
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


                    for (int j = 0; j < n - i - 1; j++)
                    {
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {

                            T temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                            swapped = true;
                        }
                    }


                    if (!swapped) break;
                }
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
    


