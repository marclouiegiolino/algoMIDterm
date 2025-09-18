using System;



class SelectionSortDemo
{
    static void ShowSort(int[] array)
    {
        Console.WriteLine("Original: " + string.Join(" , ", array));
        SelectionSort(array);

        Console.WriteLine("Sorted: " + string.Join(" , ", array));

    }

    static void SelectionSort(int[] arr)
    {
        int n = arr.Length;

        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;

            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }

            int temp = arr[minIndex];

            arr[minIndex] = arr[i];
            arr[i] = temp;
        }
    }

    static void Main()
    {

        Console.WriteLine("Enter Numbers Separated with spaces");
        string input = Console.ReadLine();

        int[] userInput = new int[5];

        string[] parts = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        userInput = Array.ConvertAll(parts, int.Parse);

        Console.WriteLine($"User Input: {userInput}");
        ShowSort(userInput);
    }
}