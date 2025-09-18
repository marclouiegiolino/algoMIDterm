using System;

class BubbleSortDemo
{
    static void Main()
    {
        Console.WriteLine("\nEnter Words Separated by Spaces: ");
        string words = Console.ReadLine();

        string[] wordArray = new string[5];
        string[] parts = words.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine($"\nUser Input: {words}");
        ShowSort(parts);
    }

    static void ShowSort(string[] array)
    {
        Console.WriteLine("Original: " + string.Join(", ", array));
        BubbleSort(array);
        Console.WriteLine("Sorted:   " + string.Join(", ", array));
    }

    static void BubbleSort(string[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
             
                if (string.Compare(arr[j], arr[j + 1]) > 0)
                {
                   
                    string temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    swapped = true;
                }
            }

          
            if (!swapped)
                break;
        }
    }
}
