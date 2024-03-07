using System.Diagnostics;

namespace SortingAlghoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Bubble sort");
            int[] arr = new int[] { 2, 4, -5, 1, 10, 6 };
            BubbleSort(arr);
            Console.WriteLine(string.Join(" ",arr));
            sw.Stop();
            Console.WriteLine();
            Console.WriteLine($"Time:  {sw} ");
            Stopwatch st = Stopwatch.StartNew();
            Console.WriteLine();
            Console.WriteLine("Selection Sort");
            int[] arr1 = new int[] { 2, 4, -5, 1, 6, 7 };
            SelectionSort(arr1);
            Console.WriteLine(string.Join(" ", arr1));
            st.Stop();
            Console.WriteLine($"Time:  {st} ");
            Console.WriteLine();
            Stopwatch ss = Stopwatch.StartNew();
            Console.WriteLine("Insertion Sort");
            int[] arr2 = { 2, 4, -5, 1, 9, 12 };
            InsertionSort(arr2);
            Console.WriteLine(string.Join(" ", arr2));
            ss.Stop();
            Console.WriteLine($"Time:  {ss} ");
        }
        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int swapVar = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = swapVar;
                    }
                }
            }
        }
        static void SelectionSort(int[] arr1)
        {
            for (int i = 0; i < arr1.Length - 1; i++)
            {
                int k = i;
                for (int j = i + 1; j < arr1.Length; j++)
                {
                    if (arr1[j] < arr1[k])
                        k = j;
                }
                int swapVar = arr1[i];
                arr1[i] = arr1[k];
                arr1[k] = swapVar;
            }
        }
        static void InsertionSort(int[] arr2)
        {
            for (int i = 0; i < arr2.Length; i++)
            {
                int swapVar = arr2[i];
                int index = i;
                while (index > 0 && arr2[index - 1] >= swapVar)
                {
                    arr2[index] = arr2[index - 1];
                    index--;
                }
                arr2[index] = swapVar;
            }
        }
    }
}
