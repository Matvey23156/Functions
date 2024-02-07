// Заполнить массив на N (вводится с консоли, не более 8)
// случайных целых чисел от 0 до 9

// Сформируйте целое число, которое будет состоять из цифр из массива.
// Старший разряд числа находится на 0-ом индексе,
// Младший-на последнем. Например: [ 2 3 1 ]=> 231

int[] GetArray()
{
    System.Console.Write("Size не больше 8: ");

    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];

    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(1, 10);
    }
    return array;
}

int ConvertDigToInt(int []array)
{
    int res = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int temp = array[i] * (int)Math.Pow(10 , array.Length - i - 1);
        res += temp;
    }
    return res;
}

int []array = GetArray();

System.Console.WriteLine($"Результат {ConvertDigToInt(array)} ");