// Контрольная работа №1.

/* Задача: Написать программу, которая из имеющегося массива 
строк формирует новый массив из строк, длина которых меньше,
либо равна 3 символам. Первоначальный массив можно ввести с 
клавиатуры, либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, 
 лучше обойтись исключительно массивами.*/

 
void Main()
{
    bool isWork = true;
    while (isWork)
    {
        Console.WriteLine("Введите команду:"); 
        Console.WriteLine("task1 - если хотите создать массив");
        Console.WriteLine("task2 - если выбираете заданный массив");
        Console.WriteLine(" out = закончить  ");
        string command = System.Console.ReadLine();
        switch (command)
        {
            case "task1":
                task1();
                break;
            case "task2":
                task2();
                break;
            case "out":
                isWork = false;
                break;
        }
    }
}
Main();


void task1()
{
    int component = 5;
    string [] OridinalArray = CreateArray(component);
    Console.WriteLine("Первоначальный массив: ");
    Console.WriteLine($"[{String.Join(", ", OridinalArray.Select(s => $"\"{s}\""))}]");
    Console.WriteLine("Отсортированный массив: ");
    Console.WriteLine($"[{string.Join(", ", SortMassive(OridinalArray))}]");
}


void task2()
{
    string[] OridinalArray1 = new string[] {"Hello", "2", "world", ":-)"};
    string[] OridinalArray2 = new string[] {"1234", "1567", "-2", "computer science"};
    string[] OridinalArray3 = new string[] {"Russia", "Denmark", "Kazan"};
    Console.WriteLine("Первоначальный массив 1: ");
    PrintArray(OridinalArray1);
    Console.WriteLine("Отсортированный массив 1: ");
    Console.WriteLine($"[{string.Join(", ", SortMassive(OridinalArray1))}]");
    Console.WriteLine("Первоначальный массив 2: ");
    PrintArray(OridinalArray2);
    Console.WriteLine("Отсортированный массив 2: ");
    Console.WriteLine($"[{string.Join(", ", SortMassive(OridinalArray2))}]");
    Console.WriteLine("Первоначальный массив 3: ");
    PrintArray(OridinalArray3);
    Console.WriteLine("Отсортированный массив 3: ");
    Console.WriteLine($"[{string.Join(", ", SortMassive(OridinalArray3))}]");
}

string[] CreateArray(int m)
{
    string [] array = new string[m];
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write("Введите строку массива: ");
        array[i] = Console.ReadLine()!;
    }
    return array;
 }

string[] SortMassive( string [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)count++;
    }
    string[] FinalArray = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) 
        {
            FinalArray[j] = array[i];
            j++;
        }
    }
    return FinalArray;   
}

void PrintArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

