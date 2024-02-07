// Задайте одномерный массив, заполненный случайными числами.
// Определите количество простых чисел в этом массиве.
// Наприимер [1 3 4 19 3] => 2


// Определение простое число или нет
bool IsPrime(int number)
{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        return false;
    }
    return true;
}

// функция для записи размера массива с клавиатуры
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

// функция для создания массива
int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int j = 0; j < array.Length; j++)
    {
        array[j] = rnd.Next(minValue, maxValue + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (int number in array)
    {
        System.Console.Write(number + " ");
    }
    System.Console.WriteLine("]");
}

int CountPrimeNumbers(int[] array)
{
     int count = 0;
 foreach (var e in array)
 {
     if (IsPrime(e))
     {
         count++;
     }
 }
 return count;
}



int[] array = GetRandomArray(6, 1, 99);
PrintArray(array);
int[] array2 = GetArrayFromConsole();
PrintArray(array2);


 
 System.Console.Write($"Результат: {CountPrimeNumbers(array)} ");
 System.Console.Write($"Результат: {CountPrimeNumbers(array2)} ");
