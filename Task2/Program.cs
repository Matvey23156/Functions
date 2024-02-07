// Задайте массив из N случайных чисел (N вводится с клавиатуры)
// Найти кол-во чисел, которые оканчиваются на 1 и деляться нацело на 7
// Пример [1 5 11 21 81 4 0 91 2 3] => 2

int[] GetArrayFromConsole()
{
    System.Console.Write("Size: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    System.Console.WriteLine($"Enter {size} elements");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int[] GetRandomArrayFromConsole()
{
    
}