void Zadacha34()
{
    //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
    //Напишите программу, которая покажет количество чётных чисел в массиве.

    Console.Write("Цифра: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);

    void PrintArray(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine();
    }

    void FillArray(int[] array)
    {
        int size = array.Length;
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(100, 1000);
        }
    }

    int count = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }

    Console.WriteLine(count);
}

//Zadacha34();

void Zadacha36()
{
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. 
    //Найдите сумму элементов, стоящих на нечётных позициях.

    Console.Write("Цифра: ");
    int size = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[size];

    FillArray(array);
    PrintArray(array);

    void PrintArray(int[] array)
    {
        int size = array.Length;
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
        Console.WriteLine();
    }

    void FillArray(int[] array)
    {
        int size = array.Length;
        Random random = new Random();

        for (int i = 0; i < size; i++)
        {
            array[i] = random.Next(1, 20);
        }
    }

    int sum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 != 0)
        {
            sum += array[i];
        }
    }
    Console.WriteLine(sum);
}

//Zadacha36();

void Zadacha38()
{
    //Задача 38: Задайте массив вещественных чисел. 
    //Найдите разницу между максимальным и минимальным элементов массива.

    Console.Write("Цифра: ");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    Random random = new Random();

    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(random.NextDouble() * 100 - 50, 2); // -50 ... 50
    }

    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine();

    double min = array[0];
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if(array[i] > max) max = array[i];
        else if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"{max} максимальное число, {min} минимальное число, и их вычитание {max - min}");

}

Zadacha38();