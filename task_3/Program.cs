Console.Write("Введите количество элементов массива:\t");
int elementsCount = int.Parse(Console.ReadLine());

int[] arr = new int[elementsCount];
void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}:\t ");
        arr[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Вывод массива:");
    Console.WriteLine($"{string.Join(", ", arr)}");

}


PrintArray(arr);
