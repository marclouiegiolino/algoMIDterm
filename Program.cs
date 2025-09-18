using System;

class BubbleSortDemo
{


    static void ShowSort(int[] array)
    {
        Console.WriteLine("Original: " + string.Join(" , ", array));

        BubbleSort(array);

        Console.WriteLine("Sorted: " + string.Join(" , ", array));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }
    static void Main()
    {

        Console.WriteLine("Enter Number separated with spaces");
        string input = Console.ReadLine();

        int[] userArray = new int[5];

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        userArray = Array.ConvertAll(parts, int.Parse);

        Console.WriteLine("Bubble Sort Demonstration\n");

        Console.WriteLine($"\nUser Input: { input}\n");
        ShowSort(userArray);

    }
}

