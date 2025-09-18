// using System;

// class BubbleSortDemo
// {
//     static void Main()
//     {
//         string[] bestCase = { "alpha", "beta", "charlie", "delta", "echo" };
//         string[] averageCase = { "beta", "charlie", "echo", "alpha", "delta" };
//         string[] worstCase = { "echo", "delta", "charlie", "beta", "alpha" };

//         Console.WriteLine("Bubble Sort Demonstration\n");

//         Console.WriteLine("Best Case (Already Sorted):");
//         ShowSort(bestCase);

//         Console.WriteLine("\nAverage Case (Random Order):");
//         ShowSort(averageCase);

//         Console.WriteLine("\nWorst Case (Reverse Sorted):");
//         ShowSort(worstCase);
//     }

//     static void ShowSort(string[] array)
//     {
//         Console.WriteLine("Original: " + string.Join(", ", array));
//         BubbleSort(array);
//         Console.WriteLine("Sorted:   " + string.Join(", ", array));
//     }

//     static void BubbleSort(string[] arr)
//     {
//         int n = arr.Length;
//         bool swapped;

//         for (int i = 0; i < n - 1; i++)
//         {
//             swapped = false;

//             for (int j = 0; j < n - i - 1; j++)
//             {
             
//                 if (string.Compare(arr[j], arr[j + 1]) > 0)
//                 {
                   
//                     string temp = arr[j];
//                     arr[j] = arr[j + 1];
//                     arr[j + 1] = temp;
//                     swapped = true;
//                 }
//             }

          
//             if (!swapped)
//                 break;
//         }
//     }
// }
