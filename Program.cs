// Задача 1
// Console.WriteLine("Введите числа через пробел:");
// string M = Console.ReadLine();
// string[] numS = M.Split(' ', StringSplitOptions.RemoveEmptyEntries);
// Console.WriteLine($"[{String.Join(",", numS)}]");
// Console.WriteLine($"{CountPosNum(numS)}");

// Задача 2
// int[] array = GetArray(10, 0, 100);
// Console.WriteLine($"[{String.Join(",", array)}]");
// SelectionSort(array);
// Console.WriteLine($"[{String.Join(",", array)}]");

// -----------Methods--------------
int CountPosNum(string[] arr)
{
    int res = 0;
    int count = 0;

    foreach (var el in arr)
    {
        res = Convert.ToInt32(Convert.ToString(el));
        if (res > 0)
            count++;
    }
    return count;
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}